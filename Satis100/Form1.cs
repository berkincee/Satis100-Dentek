using Satis100.Data;
using Satis100.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace Satis100
{
    public partial class Form1 : Form
    {
        public BindingList<GridView> GridViewItems;
        public Form1()
        {
            InitializeComponent();
            GridViewItems = new BindingList<GridView>();
            dataGridView1.DataSource = GridViewItems;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dataGridView1.Columns["Model"].Visible = false;
            dataGridView1.Columns["Make"].Visible = false;
            dataGridView1.Columns["Cost"].Visible = false;


            modelCmbBox.Enabled = false;
            using (var dbContext = new MyDatabaseContext())
            {
                List<Make> makes = dbContext.GetMakes();

                makeCmbBox.DataSource = makes;
                makeCmbBox.DisplayMember = "Name";
                makeCmbBox.ValueMember = "Id";

                List<Customer> customers = dbContext.GetCustomers();

                customerCmbBox.DataSource = customers;
                customerCmbBox.DisplayMember = "Name";
                customerCmbBox.ValueMember = "Id";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RemoveButtonClick(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                // Assuming the DataBoundItem is of type Person
                GridView selectedItem = (GridView)row.DataBoundItem;
                GridViewItems.Remove(selectedItem);
            }
            int totalCost = GridViewItems.Sum(obj => obj.Model.Cost);
            totalCostLabel.Text = "Total Cost: " + totalCost;
            if (GridViewItems.Count == 0)
            {
                customerCmbBox.Enabled = true;
            }
        }

        private void SubmitButtonClick(object sender, EventArgs e)
        {
            if (GridViewItems.Count > 0 )
            {


                List<Model> modelList = GridViewItems.Select(dataGrid => dataGrid.Model).ToList();
                Customer customer = GridViewItems.Select(s => s.Customer).FirstOrDefault();
                int totalCost = GridViewItems.Sum(s => s.Model.Cost);
                Facture facture = new Facture
                {
                    Models = modelList,
                    Customer = customer,
                    TotalCost = totalCost,
                    Date = saleDatePicker.Value
                };

                using (var context = new MyDatabaseContext())
                {
                    context.InsertFacture(facture);
                }
                GridViewItems.Clear();
                totalCostLabel.Text = "Total Cost: 0";
            }
        }
        private void madeCmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string a = makeCmbBox.SelectedValue.ToString();
            int _madeId;
            if (int.TryParse(a, out _madeId))
            {
                modelCmbBox.Enabled = true;
                using (var dbContext = new MyDatabaseContext())
                {
                    List<Model> models = dbContext.GetModels(_madeId);
                    modelCmbBox.DataSource = models;
                    modelCmbBox.DisplayMember = "Name";
                    modelCmbBox.ValueMember = "Id";

                }
            }


        }

        private void addBtn_Click(object sender, EventArgs e)
        {

            if (modelCmbBox.SelectedValue != null)
            {

                var selectedModel = modelCmbBox.SelectedItem as Model;
                var selectedMake = makeCmbBox.SelectedItem as Make;
                var selectedCustomer = customerCmbBox.SelectedItem as Customer;
                var GridItem = new GridView
                {
                    Model = selectedModel,
                    Make = selectedMake,
                    Customer = selectedCustomer,
                    CustomerName = selectedCustomer.Name,
                    ModelName = selectedModel.Name,
                    MakeName = selectedMake.Name,
                    Cost = selectedModel.Cost

                };
                GridViewItems.Add(GridItem);

                int totalCost = GridViewItems.Sum(obj => obj.Model.Cost);

                totalCostLabel.Text = "Total Cost: " + totalCost;

            }
            if (GridViewItems.Count > 0)
            {
                customerCmbBox.Enabled = false;
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.Show();

            this.Hide();
            // Close the current form if needed
            

        }
    }
}
