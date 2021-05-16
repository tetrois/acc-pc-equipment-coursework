using System;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace БД_Контрольная
{
    public partial class Form1 : Form
    {
        public SqlConnection conn;

        public SqlDataAdapter adapEquipment, adapExport;
        public DataTable Equipment, Export;
        public int Option;

        BindingSource bsEquipment, bsExport;

        string filterField = "Name";
        string filterField2 = "";
        public string addExportStr = "";

        bool statusExport = false;



        public Form1()
        {
            InitializeComponent();
        }

        //Создание подключения к БД
        public void createConnect(DataGridView dataGridView)
        {
            //Строка для подключения к БД
            string strConn = "Data Source=(LocalDB)\\MSSQLLocalDB;" +
                             "AttachDbFilename='C:\\Users\\Руслан\\AppData\\Local\\Microsoft\\Microsoft SQL Server Local DB\\Instances\\v11.0\\MyBase.mdf';" +
                             "Integrated Security=True;" +
                             "Connect Timeout=30;";
            //Создаем подключение
            conn = new SqlConnection(strConn);
            //Открываем подключение
            conn.Open();


            string strCmd = "SELECT Id, Name, Type, Quantity, Department, Cabinet, InstallDate, SN, Username FROM Equipment";
            SqlCommand cmd = new SqlCommand(strCmd, conn);

            adapEquipment = new SqlDataAdapter(cmd);

            Equipment = new DataTable();
            adapEquipment.Fill(Equipment);

            bsEquipment = new BindingSource();
            bsEquipment.DataSource = Equipment;
            dataGridView.DataSource = bsEquipment;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Size = new Size(1270, 725);
            //Подключаемся к БД
            createConnect(dataGridView1);


            //---------------Блок для заполнения данными comboBox-----------------

            //Строки для вывода уникальных значений из столбцов
            string strListTypes = "SELECT DISTINCT Type FROM Equipment";
            string strListDepartmens = "SELECT DISTINCT Department FROM Equipment";
            string strListCabinets = "SELECT DISTINCT Cabinet FROM Equipment";
            string strListNames = "SELECT DISTINCT UserName FROM Equipment";

            //Создаем SQL команды
            SqlCommand cmdTypes = new SqlCommand(strListTypes, conn);
            SqlCommand cmdDepartmens = new SqlCommand(strListDepartmens, conn);
            SqlCommand cmdCabinets = new SqlCommand(strListCabinets, conn);
            SqlCommand cmdNames = new SqlCommand(strListNames, conn);


            //Заполнение данными combobox
            //Для типов
            SqlDataReader reader1 = cmdTypes.ExecuteReader();
            comboBox1.Items.Add("Все типы устройств");
            while (reader1.Read()) {
                comboBox1.Items.Add(reader1.GetValue(0));
            }
            reader1.Close();
            comboBox1.SelectedIndex = 0;

            //Для департаментов
            SqlDataReader reader2 = cmdDepartmens.ExecuteReader();
            comboBox2.Items.Add("Все департаменты");
            while (reader2.Read())
            {
                comboBox2.Items.Add(reader2.GetValue(0));
            }
            reader2.Close();
            comboBox2.SelectedIndex = 0;

            //Для Кабинетов
            SqlDataReader reader3 = cmdCabinets.ExecuteReader();
            comboBox3.Items.Add("Все кабинеты");
            while (reader3.Read())
            {
                comboBox3.Items.Add(reader3.GetValue(0));
            }
            reader3.Close();
            comboBox3.SelectedIndex = 0;

            //Для ФИО
            SqlDataReader reader4 = cmdNames.ExecuteReader();
            comboBox4.Items.Add("Все сотрудники");
            while (reader4.Read())
            {
                comboBox4.Items.Add(reader4.GetValue(0));
            }
            reader4.Close();
            comboBox4.SelectedIndex = 0;

            //---------------Конец Блока для заполнения данными comboBox-----------------

        }

        //Заполняем/инициализируем таблицу Export
        private void setDataTableExport()
        {
            dataGridView1_CellClick(null,null);
            string queryExport = "SELECT Id, Name, Type, Quantity, Department, Cabinet, InstallDate, SN, Username FROM Export";

            SqlCommand cmd = new SqlCommand(queryExport, conn);

            adapExport = new SqlDataAdapter(cmd);
            Export = new DataTable();
            adapExport.Fill(Export);

            bsExport = new BindingSource();
            bsExport.DataSource = Export;
            dataGridView2.DataSource = bsExport;
        }

        //Заполнение данными textbox при клике в таблицу 
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow currentRow = dataGridView1.CurrentRow;

            string id          = currentRow.Cells["Id"].Value.ToString();
            string name        = currentRow.Cells["Name"].Value.ToString();
            string type        = currentRow.Cells["Type"].Value.ToString();
            string quantity    = currentRow.Cells["Quantity"].Value.ToString();
            string department  = currentRow.Cells["Department"].Value.ToString();
            string cabinet     = currentRow.Cells["Cabinet"].Value.ToString();
            string installDate = currentRow.Cells["InstallDate"].Value.ToString();
            string sn          = currentRow.Cells["SN"].Value.ToString();
            string userName    = currentRow.Cells["UserName"].Value.ToString();

            textBox0.Text = id;
            textBox1.Text = name;
            textBox2.Text = type;
            textBox3.Text = quantity;
            textBox4.Text = department;
            textBox5.Text = cabinet;
            textBox6.Text = installDate;
            textBox7.Text = sn;
            textBox8.Text = userName;

            addExportStr = "INSERT INTO Export " +
                                "(Id, Name, Type, Quantity, Department, Cabinet, InstallDate, SN, Username) " +
                                "VALUES (" + id + ", N'" + name + "', N'" + type + "', N'" + quantity + "', N'" + department + "', N'" + cabinet + "', N'" + installDate + "', N'" + sn + "', N'" + userName + "')";


        }

        //Удаление элемента
        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox0.Text.Length > 0 )
            {
                int id = int.Parse(textBox0.Text);
                string deleteStr = "DELETE FROM Equipment WHERE Id = " + id;

                SqlCommand deleteCmd = new SqlCommand(deleteStr, conn);
                deleteCmd.ExecuteNonQuery();
        
                // Вывод данных обновленной таблицы
                Equipment.Clear();
                adapEquipment.Fill(Equipment);
            }
        }

        //Открываем форму для добавления новых позиций
        private void button1_Click(object sender, EventArgs e)
        {
            Option = 1;
            
            Form2 form2 = new Form2();
            this.Enabled = false;
            form2.mainForm1 = this;

            form2.Show();
        }

        //Кнопка обновления/редактирования данных
        private void button2_Click(object sender, EventArgs e)
        {
            string id           = textBox0.Text;
            string name         = textBox1.Text;
            string type         = textBox2.Text;
            string quantity     = textBox3.Text;
            string department   = textBox4.Text;
            string cabinet      = textBox5.Text;
            string installDate  = textBox6.Text;
            string sn           = textBox7.Text;
            string userName     = textBox8.Text;

            string updateStr = "UPDATE Equipment SET  " +

                           "Name = @name, " +
                           "Type = @type, " +
                           "Quantity = @quantity, " +
                           "Department = @department, " +
                           "Cabinet = @cabinet, " +
                           "InstallDate = @installDate, " +
                           "SN = @sn, " +
                           "UserName = @userName " +
                          "WHERE  Id = @id ";
            SqlCommand updateCmd = new SqlCommand(updateStr, conn);

            //Добавление параметров в коллекцию Parameters
            updateCmd.Parameters.Add("@name", SqlDbType.NVarChar, 50);
            updateCmd.Parameters.Add("@type", SqlDbType.NVarChar, 50);
            updateCmd.Parameters.Add("@quantity", SqlDbType.NVarChar, 50);
            updateCmd.Parameters.Add("@department", SqlDbType.NVarChar, 50);
            updateCmd.Parameters.Add("@cabinet", SqlDbType.NVarChar, 50);
            updateCmd.Parameters.Add("@installDate", SqlDbType.NVarChar, 50);
            updateCmd.Parameters.Add("@sn", SqlDbType.NVarChar, 50);
            updateCmd.Parameters.Add("@userName", SqlDbType.NVarChar, 50);

            updateCmd.Parameters.Add("@id", SqlDbType.Int);

            // Определение значений параметров 
            updateCmd.Parameters["@name"].Value = name;
            updateCmd.Parameters["@type"].Value = type;
            updateCmd.Parameters["@quantity"].Value = quantity;
            updateCmd.Parameters["@department"].Value = department;
            updateCmd.Parameters["@cabinet"].Value = cabinet;
            updateCmd.Parameters["@installDate"].Value = installDate;
            updateCmd.Parameters["@sn"].Value = sn;
            updateCmd.Parameters["@userName"].Value = userName;
            updateCmd.Parameters["@ID"].Value = id;

            updateCmd.ExecuteNonQuery();

            // Вывод данных обновленной таблицы
            Equipment.Clear();
            adapEquipment.Fill(Equipment);
        }

        private void textBox9_TextChanged_1(object sender, EventArgs e)
        {
            bsEquipment.Filter = filterField + " LIKE '" + textBox9.Text + "%'";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            filterField = "Name";
            bsEquipment.Filter = filterField + " LIKE '" + textBox9.Text + "%'";
            textBox9.Focus();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            filterField = "Department";
            bsEquipment.Filter = filterField + " LIKE '" + textBox9.Text + "%'";
            textBox9.Focus();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            filterField = "Cabinet";
            bsEquipment.Filter = filterField + " LIKE '" + textBox9.Text + "%'";
            textBox9.Focus();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            filterField = "InstallDate";
            bsEquipment.Filter = filterField + " LIKE '" + textBox9.Text + "%'";
            textBox9.Focus();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            filterField = "UserName";
            bsEquipment.Filter = filterField + " LIKE '" + textBox9.Text + "%'";
            textBox9.Focus();
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            filterField = "Type";
            bsEquipment.Filter = filterField + " LIKE '" + textBox9.Text + "%'";
            textBox9.Focus();
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            filterField = "SN";
            bsEquipment.Filter = filterField + " LIKE '" + textBox9.Text + "%'";
            textBox9.Focus();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBox1.SelectedIndex;
            string changeType = comboBox1.Items[index].ToString();
            if (index > 0)
            {
                filterField2 = filterField2 + " ( Type = '" + changeType + "') AND";   
            }
            else {
                //bsEquipment.RemoveFilter();
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBox2.SelectedIndex;
            string changeType = comboBox2.Items[index].ToString();
            if (index > 0)
            {
                filterField2 = filterField2 + " ( Department = '" + changeType + "') AND";
            }
            else {
                //bsEquipment.RemoveFilter();
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBox3.SelectedIndex;
            string changeType = comboBox3.Items[index].ToString();
            if (index > 0)
            {
                filterField2 = filterField2 + " ( Cabinet = '" + changeType + "') AND";
            }
            else
            {
                //bsEquipment.RemoveFilter();
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBox4.SelectedIndex;
            string changeType = comboBox4.Items[index].ToString();
            if (index > 0)
            {
                filterField2 = filterField2 + " ( UserName = '" + changeType + "') AND";

            }
            else {
                //bsEquipment.RemoveFilter();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox9.Text = "";
        }
        //Кнопка применения правил выборки
        private void button5_Click(object sender, EventArgs e)
        {
            if (filterField2.Length > 0) { 
                bsEquipment.Filter = filterField2.Remove(filterField2.Length - 3, 3);
            }
            comboBox1.Enabled = false;
            comboBox2.Enabled = false;
            comboBox3.Enabled = false;
            comboBox4.Enabled = false;
            button5.Enabled   = false;
        }

        //Удаление всех данных из таблицы Export
        private void clearExportData()
        {
            string clearExport = "DELETE FROM Export";
            SqlCommand cmdClearExport = new SqlCommand(clearExport, conn);
            cmdClearExport.ExecuteNonQuery();
        }

        //Кнопка очистки таблицы Экспорта
        private void button9_Click(object sender, EventArgs e)
        {
            clearExportData();
            Export.Clear();
            adapExport.Fill(Export);
        }

        //Кнопка добавления в Экспорт
        private void button11_Click(object sender, EventArgs e)
        {
            SqlCommand addCmd = new SqlCommand(addExportStr, conn);
            addCmd.ExecuteNonQuery();
            
            // Вывод данных обновленной таблицы
            Export.Clear();
            adapExport.Fill(Export);
        }

        //Кнопка удаления 1 элемента из Экспорта
        private void btnDeleteExportOnce_Click(object sender, EventArgs e)
        {
            DataGridViewRow currentRow = dataGridView2.CurrentRow;

            string deleteStr = "DELETE FROM Export WHERE Id = " + currentRow.Cells["Id"].Value.ToString();

            SqlCommand deleteCmd = new SqlCommand(deleteStr, conn);
            deleteCmd.ExecuteNonQuery();

            // Вывод данных обновленной таблицы
            Export.Clear();
            adapExport.Fill(Export);


        }

        //Вывод файла csv
        private void button8_Click(object sender, EventArgs e)
        {
            StreamWriter file = new StreamWriter("Export.csv", false, Encoding.UTF8);
            string queryExport = "SELECT Id, Name, Type, Quantity, Department, Cabinet, InstallDate, SN, Username FROM Export";

            try
            {
                SqlCommand command = new SqlCommand(queryExport, conn);
                SqlDataReader SQLreader = command.ExecuteReader();

                file.WriteLine(
                @"""Id"";""Name"";""Type"";""Quantity"";""Department"";""Cabinet"";""InstallDate"";""SN"";""Username""");
                if (SQLreader.HasRows)
                {
                    while (SQLreader.Read())
                    {
                        file.WriteLine(@"""" +
                             SQLreader.GetValue(0).ToString() +
                             @""";""" +
                             SQLreader.GetValue(1).ToString() +
                             @""";""" +
                             SQLreader.GetValue(2).ToString() +
                             @""";""" +
                             SQLreader.GetValue(3).ToString() +
                             @""";""" +
                             SQLreader.GetValue(4).ToString() +
                             @""";""" +
                             SQLreader.GetValue(5).ToString() +
                             @""";""" +
                             SQLreader.GetValue(6).ToString() +
                             @""";""" +
                             SQLreader.GetValue(7).ToString() +
                             @""";""" +
                             SQLreader.GetValue(8).ToString() +
                             @"""");
                    }
                }
                else
                    file.WriteLine(
                         "No one row is in \"Credits\" table");
                file.WriteLine("End of file");
                file.Close();
                SQLreader.Close();
                MessageBox.Show("Файл Export.csv сохранен.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Close();

        }

        //Кнопка очистки выборки
        private void button6_Click(object sender, EventArgs e)
        {
            bsEquipment.RemoveFilter();
            filterField2 = "";
            comboBox1.Enabled = true; comboBox1.SelectedIndex = 0;
            comboBox2.Enabled = true; comboBox2.SelectedIndex = 0;
            comboBox3.Enabled = true; comboBox3.SelectedIndex = 0;
            comboBox4.Enabled = true; comboBox4.SelectedIndex = 0;
            button5.Enabled = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (statusExport) {
                statusExport = !statusExport;
                Size = new Size(1270, 725);
                button7.Text = "Режим выгрузки выкл";
                groupBox3.Visible = false;

            } else
            {
                statusExport = !statusExport;
                setDataTableExport();
                Size = new Size(1270, 1025);
                button7.Text = "Режим выгрузки вкл";
                groupBox3.Visible = true;


            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}