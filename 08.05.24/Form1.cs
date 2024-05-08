using System;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
using System.Data;

namespace _08._05._24
{
    public partial class Form1 : Form
    {
        private String Задание08.05;
        private SQLiteConnection m_dbConn;
        private SQLiteCommand m_sqlCmd;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
