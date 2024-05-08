using System;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
using System.Data;

namespace _08._05._24
{
   
    public partial class Form1 : Form
    {
        //static string path = Path.GetFullPath("Zavod");
        //static string connection = "Data Sourse=" + path;
        //SQLiteConnection inconnection = new SQLiteConnection(connection);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
        }
    }
}
