namespace WindowsFormsApp26
{
    partial class Form5
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.restoranDataSet1 = new WindowsFormsApp26.restoranDataSet1();
            this.dishBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dishTableAdapter = new WindowsFormsApp26.restoranDataSet1TableAdapters.DishTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calorieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sostavDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriesIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.photoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restoranDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.calorieDataGridViewTextBoxColumn,
            this.sostavDataGridViewTextBoxColumn,
            this.vesDataGridViewTextBoxColumn,
            this.categoriesIDDataGridViewTextBoxColumn,
            this.photoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dishBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(867, 286);
            this.dataGridView1.TabIndex = 0;
            // 
            // restoranDataSet1
            // 
            this.restoranDataSet1.DataSetName = "restoranDataSet1";
            this.restoranDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dishBindingSource
            // 
            this.dishBindingSource.DataMember = "Dish";
            this.dishBindingSource.DataSource = this.restoranDataSet1;
            // 
            // dishTableAdapter
            // 
            this.dishTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // calorieDataGridViewTextBoxColumn
            // 
            this.calorieDataGridViewTextBoxColumn.DataPropertyName = "Calorie";
            this.calorieDataGridViewTextBoxColumn.HeaderText = "Calorie";
            this.calorieDataGridViewTextBoxColumn.Name = "calorieDataGridViewTextBoxColumn";
            // 
            // sostavDataGridViewTextBoxColumn
            // 
            this.sostavDataGridViewTextBoxColumn.DataPropertyName = "Sostav";
            this.sostavDataGridViewTextBoxColumn.HeaderText = "Sostav";
            this.sostavDataGridViewTextBoxColumn.Name = "sostavDataGridViewTextBoxColumn";
            // 
            // vesDataGridViewTextBoxColumn
            // 
            this.vesDataGridViewTextBoxColumn.DataPropertyName = "Ves";
            this.vesDataGridViewTextBoxColumn.HeaderText = "Ves";
            this.vesDataGridViewTextBoxColumn.Name = "vesDataGridViewTextBoxColumn";
            // 
            // categoriesIDDataGridViewTextBoxColumn
            // 
            this.categoriesIDDataGridViewTextBoxColumn.DataPropertyName = "CategoriesID";
            this.categoriesIDDataGridViewTextBoxColumn.HeaderText = "CategoriesID";
            this.categoriesIDDataGridViewTextBoxColumn.Name = "categoriesIDDataGridViewTextBoxColumn";
            // 
            // photoDataGridViewTextBoxColumn
            // 
            this.photoDataGridViewTextBoxColumn.DataPropertyName = "Photo";
            this.photoDataGridViewTextBoxColumn.HeaderText = "Photo";
            this.photoDataGridViewTextBoxColumn.Name = "photoDataGridViewTextBoxColumn";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "Добавть";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 356);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 35);
            this.button2.TabIndex = 2;
            this.button2.Text = "Удалить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 397);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(145, 35);
            this.button3.TabIndex = 3;
            this.button3.Text = "Редактировать";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restoranDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private restoranDataSet1 restoranDataSet1;
        private System.Windows.Forms.BindingSource dishBindingSource;
        private restoranDataSet1TableAdapters.DishTableAdapter dishTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn calorieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sostavDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriesIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn photoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}