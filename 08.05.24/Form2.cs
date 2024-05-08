using System;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data;

namespace _08._05._24
{
    public partial class Form2 : Form
    {
        //static string path = Path.GetFullPath("Zavod");
        //static string connection = "Data Sourse=" + path;
        //SQLiteConnection inconnection = new SQLiteConnection(connection);
        private String Zavod;
        private SQLiteConnection m_dbConn;
        private SQLiteCommand m_sqlCmd;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            m_dbConn = new SQLiteConnection();
            m_sqlCmd = new SQLiteCommand();
            Zavod = "Zavod.db";
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            m_dbConn = new SQLiteConnection("Data Source=Zavod.db;Version=3;");
            m_dbConn.Open();
            m_sqlCmd.Connection = m_dbConn;
            DataTable dTable = new DataTable();
            String sqlQuery;
            if (m_dbConn.State != ConnectionState.Open)
            {
                MessageBox.Show("Open connection with database");
            }

            try
            {
                sqlQuery = "SELECT * FROM MetalProductsPlant";
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sqlQuery, m_dbConn);
                adapter.Fill(dTable);
                if (dTable.Rows.Count >= 0)
                {
                    for (int i = 0; i < dTable.Rows.Count; i++)
                    {
                        dataGridView1.Rows.Add(dTable.Rows[0].ItemArray);
                    }
                }
                else
                    MessageBox.Show("Database is empty");
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
