namespace Satis100
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.customerCmbBox = new System.Windows.Forms.ComboBox();
            this.saleDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.makeCmbBox = new System.Windows.Forms.ComboBox();
            this.modelCmbBox = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.addBtn = new System.Windows.Forms.Button();
            this.removeBtn = new System.Windows.Forms.Button();
            this.totalCostLabel = new System.Windows.Forms.Label();
            this.submitBtn = new System.Windows.Forms.Button();
            this.historyBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.flowLayoutPanel1.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 57);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1238, 85);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(46, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Müşteri";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(46, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tarih";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // customerCmbBox
            // 
            this.customerCmbBox.FormattingEnabled = true;
            this.customerCmbBox.Location = new System.Drawing.Point(151, 156);
            this.customerCmbBox.Name = "customerCmbBox";
            this.customerCmbBox.Size = new System.Drawing.Size(169, 21);
            this.customerCmbBox.TabIndex = 3;
            this.customerCmbBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // saleDatePicker
            // 
            this.saleDatePicker.Location = new System.Drawing.Point(151, 213);
            this.saleDatePicker.Name = "saleDatePicker";
            this.saleDatePicker.Size = new System.Drawing.Size(169, 20);
            this.saleDatePicker.TabIndex = 4;
            this.saleDatePicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(590, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Marka";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(590, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Model";
            // 
            // makeCmbBox
            // 
            this.makeCmbBox.FormattingEnabled = true;
            this.makeCmbBox.Location = new System.Drawing.Point(688, 158);
            this.makeCmbBox.Name = "makeCmbBox";
            this.makeCmbBox.Size = new System.Drawing.Size(182, 21);
            this.makeCmbBox.TabIndex = 7;
            this.makeCmbBox.SelectedIndexChanged += new System.EventHandler(this.madeCmbBox_SelectedIndexChanged);
            // 
            // modelCmbBox
            // 
            this.modelCmbBox.FormattingEnabled = true;
            this.modelCmbBox.Location = new System.Drawing.Point(688, 216);
            this.modelCmbBox.Name = "modelCmbBox";
            this.modelCmbBox.Size = new System.Drawing.Size(182, 21);
            this.modelCmbBox.TabIndex = 8;
            this.modelCmbBox.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(0, 313);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1224, 215);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(961, 156);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 10;
            this.addBtn.Text = "Ekle";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // removeBtn
            // 
            this.removeBtn.Location = new System.Drawing.Point(961, 216);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(75, 23);
            this.removeBtn.TabIndex = 11;
            this.removeBtn.Text = "Çıkar";
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.RemoveButtonClick);
            // 
            // totalCostLabel
            // 
            this.totalCostLabel.AutoSize = true;
            this.totalCostLabel.Location = new System.Drawing.Point(-3, 541);
            this.totalCostLabel.Name = "totalCostLabel";
            this.totalCostLabel.Size = new System.Drawing.Size(35, 13);
            this.totalCostLabel.TabIndex = 12;
            this.totalCostLabel.Text = "0TRY";
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(961, 559);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(75, 23);
            this.submitBtn.TabIndex = 13;
            this.submitBtn.Text = "ONAY";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.SubmitButtonClick);
            // 
            // historyBtn
            // 
            this.historyBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.historyBtn.ForeColor = System.Drawing.Color.Black;
            this.historyBtn.Location = new System.Drawing.Point(0, 0);
            this.historyBtn.Name = "historyBtn";
            this.historyBtn.Size = new System.Drawing.Size(125, 61);
            this.historyBtn.TabIndex = 15;
            this.historyBtn.Text = "GEÇMİŞ FATURALAR GÖR";
            this.historyBtn.UseVisualStyleBackColor = false;
            this.historyBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 710);
            this.Controls.Add(this.historyBtn);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.totalCostLabel);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.modelCmbBox);
            this.Controls.Add(this.makeCmbBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.saleDatePicker);
            this.Controls.Add(this.customerCmbBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox customerCmbBox;
        private System.Windows.Forms.DateTimePicker saleDatePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox makeCmbBox;
        private System.Windows.Forms.ComboBox modelCmbBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.Label totalCostLabel;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Button historyBtn;
    }
}

