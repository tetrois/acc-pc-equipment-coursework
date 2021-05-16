using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace БД_Контрольная
{
    public partial class Form2 : Form
    {
        public Form1 mainForm1;


        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = textBox0.Text + ", ";
            string name = "N'" + textBox1.Text + "', ";
            string type = "N'" + textBox2.Text + "', ";
            string quantity = "N'" + textBox3.Text + "', ";
            string department = "N'" + textBox4.Text + "', ";
            string cabinet = "N'" + textBox5.Text + "', ";
            string installDate = "N'" + textBox6.Text + "', ";
            string sn = "N'" + textBox7.Text + "', ";
            string userName = "N'" + textBox8.Text + "' ";

            string insertStr = "INSERT INTO Equipment " +
                                "(Id, Name, Type, Quantity, Department, Cabinet, InstallDate, SN, Username) " +
                                "VALUES (" + id + name + type + quantity + department + cabinet + installDate + sn + userName + ")";

            SqlCommand insertCmd = new SqlCommand(insertStr, mainForm1.conn);
            insertCmd.ExecuteNonQuery();

            // Вывод данных обновленной таблицы
            mainForm1.Equipment.Clear();
            mainForm1.adapEquipment.Fill(mainForm1.Equipment);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainForm1.Option = 2;
            mainForm1.Enabled = true;

        }

        private void Form2_Activated(object sender, EventArgs e)
        {
            
            string insertStr = "SELECT max(Id) FROM Equipment";
            SqlCommand cmdLengthTable = new SqlCommand(insertStr, mainForm1.conn);

            SqlDataReader reader = cmdLengthTable.ExecuteReader();
            reader.Read();
            int a = Convert.ToInt32(reader.GetValue(0));
            reader.Close();

            textBox0.Text = Convert.ToString(a + 1);
        }
    }
}
