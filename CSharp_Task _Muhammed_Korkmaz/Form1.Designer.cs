namespace CSharp_Task__Muhammed_Korkmaz
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
            this.components = new System.ComponentModel.Container();
            this.dgvBookList = new System.Windows.Forms.DataGridView();
            this.gbOperations = new System.Windows.Forms.GroupBox();
            this.btnDeleteBooksOutOfStock = new System.Windows.Forms.Button();
            this.btnReadData = new System.Windows.Forms.Button();
            this.gbData = new System.Windows.Forms.GroupBox();
            this.ofdReadFile = new System.Windows.Forms.OpenFileDialog();
            this.gcDescription = new System.Windows.Forms.DataGridViewButtonColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ınStockDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bdgvBindingList = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bindingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookList)).BeginInit();
            this.gbOperations.SuspendLayout();
            this.gbData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBookList
            // 
            this.dgvBookList.AllowUserToAddRows = false;
            this.dgvBookList.AllowUserToOrderColumns = true;
            this.dgvBookList.AutoGenerateColumns = false;
            this.dgvBookList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBookList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titleDataGridViewTextBoxColumn,
            this.authorDataGridViewTextBoxColumn,
            this.yearDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.ınStockDataGridViewCheckBoxColumn,
            this.bdgvBindingList,
            this.descriptionDataGridViewTextBoxColumn,
            this.gcDescription});
            this.dgvBookList.DataSource = this.bookBindingSource;
            this.dgvBookList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBookList.Location = new System.Drawing.Point(3, 16);
            this.dgvBookList.Name = "dgvBookList";
            this.dgvBookList.ReadOnly = true;
            this.dgvBookList.Size = new System.Drawing.Size(672, 319);
            this.dgvBookList.TabIndex = 0;
            this.dgvBookList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBookList_CellClick);
            this.dgvBookList.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // gbOperations
            // 
            this.gbOperations.Controls.Add(this.btnDeleteBooksOutOfStock);
            this.gbOperations.Controls.Add(this.btnReadData);
            this.gbOperations.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbOperations.Location = new System.Drawing.Point(0, 0);
            this.gbOperations.Name = "gbOperations";
            this.gbOperations.Size = new System.Drawing.Size(678, 51);
            this.gbOperations.TabIndex = 1;
            this.gbOperations.TabStop = false;
            this.gbOperations.Text = "Operations";
            // 
            // btnDeleteBooksOutOfStock
            // 
            this.btnDeleteBooksOutOfStock.Location = new System.Drawing.Point(93, 19);
            this.btnDeleteBooksOutOfStock.Name = "btnDeleteBooksOutOfStock";
            this.btnDeleteBooksOutOfStock.Size = new System.Drawing.Size(175, 23);
            this.btnDeleteBooksOutOfStock.TabIndex = 1;
            this.btnDeleteBooksOutOfStock.Text = "Delete Books Out of Stock";
            this.btnDeleteBooksOutOfStock.UseVisualStyleBackColor = true;
            this.btnDeleteBooksOutOfStock.Click += new System.EventHandler(this.btnDeleteBooksOutOfStock_Click);
            // 
            // btnReadData
            // 
            this.btnReadData.Location = new System.Drawing.Point(12, 19);
            this.btnReadData.Name = "btnReadData";
            this.btnReadData.Size = new System.Drawing.Size(75, 23);
            this.btnReadData.TabIndex = 0;
            this.btnReadData.Text = "Read Data";
            this.btnReadData.UseVisualStyleBackColor = true;
            this.btnReadData.Click += new System.EventHandler(this.btnReadData_Click);
            // 
            // gbData
            // 
            this.gbData.Controls.Add(this.dgvBookList);
            this.gbData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbData.Location = new System.Drawing.Point(0, 51);
            this.gbData.Name = "gbData";
            this.gbData.Size = new System.Drawing.Size(678, 338);
            this.gbData.TabIndex = 2;
            this.gbData.TabStop = false;
            this.gbData.Text = "Data";
            // 
            // ofdReadFile
            // 
            this.ofdReadFile.FileName = "openFileDialog1";
            // 
            // gcDescription
            // 
            this.gcDescription.HeaderText = "Description";
            this.gcDescription.Name = "gcDescription";
            this.gcDescription.ReadOnly = true;
            this.gcDescription.Text = "Description";
            this.gcDescription.ToolTipText = "Description";
            this.gcDescription.UseColumnTextForButtonValue = true;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // authorDataGridViewTextBoxColumn
            // 
            this.authorDataGridViewTextBoxColumn.DataPropertyName = "Author";
            this.authorDataGridViewTextBoxColumn.HeaderText = "Author";
            this.authorDataGridViewTextBoxColumn.Name = "authorDataGridViewTextBoxColumn";
            this.authorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // yearDataGridViewTextBoxColumn
            // 
            this.yearDataGridViewTextBoxColumn.DataPropertyName = "Year";
            this.yearDataGridViewTextBoxColumn.HeaderText = "Year";
            this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            this.yearDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ınStockDataGridViewCheckBoxColumn
            // 
            this.ınStockDataGridViewCheckBoxColumn.DataPropertyName = "InStock";
            this.ınStockDataGridViewCheckBoxColumn.HeaderText = "InStock";
            this.ınStockDataGridViewCheckBoxColumn.Name = "ınStockDataGridViewCheckBoxColumn";
            this.ınStockDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // bdgvBindingList
            // 
            this.bdgvBindingList.DataPropertyName = "Binding";
            this.bdgvBindingList.DataSource = this.bindingsBindingSource;
            this.bdgvBindingList.HeaderText = "Binding";
            this.bdgvBindingList.Name = "bdgvBindingList";
            this.bdgvBindingList.ReadOnly = true;
            this.bdgvBindingList.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.bdgvBindingList.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.bdgvBindingList.ValueMember = "Binding";
            // 
            // bindingsBindingSource
            // 
            this.bindingsBindingSource.DataSource = typeof(CSharp_Task__Muhammed_Korkmaz.Bindings);
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn.Visible = false;
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataSource = typeof(CSharp_Task__Muhammed_Korkmaz.Book);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 389);
            this.Controls.Add(this.gbData);
            this.Controls.Add(this.gbOperations);
            this.Name = "Form1";
            this.Text = "Book Store";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookList)).EndInit();
            this.gbOperations.ResumeLayout(false);
            this.gbData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBookList;
        private System.Windows.Forms.GroupBox gbOperations;
        private System.Windows.Forms.Button btnReadData;
        private System.Windows.Forms.GroupBox gbData;
        private System.Windows.Forms.Button btnDeleteBooksOutOfStock;
        private System.Windows.Forms.OpenFileDialog ofdReadFile;
        private System.Windows.Forms.BindingSource bindingsBindingSource;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ınStockDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn bdgvBindingList;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn gcDescription;
    }
}

