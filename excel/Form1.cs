using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace excel
{
    public partial class Form1 : Form
    {

        private const string V = "Tytul,Autor,ID\n";
        public static string tytul, autor, id;
        public static int index, maxrow;
        public static DataTable dt = new DataTable();



        public Form1()
        {
            InitializeComponent();
        }


        DataSet result;

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        public static DataTable readCSV(string filePath)
        {
            dt = new DataTable();
            foreach (var headerLine in File.ReadLines(filePath).Take(1))
            {
                foreach (var headerItem in headerLine.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    dt.Columns.Add(headerItem.Trim());
                }
            }
            foreach (var line in File.ReadLines(filePath).Skip(1))
            {
                dt.Rows.Add(line.Split(','));
            }

            return dt;
        }






        private void button3_Click(object sender, EventArgs e)
        {
            Form2 finfo = new Form2(this);
            finfo.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog ofd = new OpenFileDialog() { Filter="Excel|*xls", ValidateNames = true })
            {
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    FileStream fs = File.Open(ofd.FileName, FileMode.Open, FileAccess.Read);
                     

                }
            }
        }
    }
}
