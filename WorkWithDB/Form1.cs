using System;
using System.Windows.Forms;

namespace WorkWithDB
{
    public partial class Form1 : Form
    {
        private WorkWithDBClass db;
        public Form1()
        {
            InitializeComponent();
            string exept = "";
            db = new WorkWithDBClass("CompanyWorkers.db3", out exept);
            labelEx.Text += exept;
            db.CreateTableWorker(out exept);
            labelEx.Text += exept;
            db.CreateTableSpeciality(out exept);
            labelEx.Text += exept;
            db.AddDataToTableSpeciality(0, "chief medical officer", out exept);
            db.AddDataToTableSpeciality(1, "doctor", out exept);
            labelEx.Text += exept;
            db.AddDataToTableWorker(0, "Bob", null, 0, 1, out exept);
            db.AddDataToTableWorker(1, "John", 0, 1, 0, out exept);
            db.AddDataToTableWorker(2, "Eliot", 0, 1, 0, out exept);
            labelEx.Text += exept;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
             string exept = "";
            label1.Text+= db.ShowTableWorkers(out exept);
            labelEx.Text += exept;
            label1.Text += db.ShowTableBosses(out exept);
            labelEx.Text += exept;

        }

      
    }

    
}
