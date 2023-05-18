using Satis100.Data;
using Satis100.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Satis100
{
    public partial class Form2 : Form
    {
        private Form1 parentForm;
        public BindingList<GridView> GridViewFactureItems;
        public Form2()
        {
            InitializeComponent();
            using (var dbContext = new MyDatabaseContext())
            {
                List<FactureDetail> factures = dbContext.GetAllFactureDetails();

                dataGridView1.DataSource = factures;
            }



        }
        public Form2(Form1 parentform) : this()
        {
            parentForm = parentform;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            parentForm.Show();
            parentForm.Focus();
        }
    }

}
