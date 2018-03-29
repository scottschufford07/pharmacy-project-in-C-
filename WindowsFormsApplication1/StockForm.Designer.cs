namespace WindowsFormsApplication1
{
    partial class StockForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgStock = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productExpiryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet1 = new WindowsFormsApplication1.DatabaseDataSet1();
            this.button1 = new System.Windows.Forms.Button();
            this.StkextBtn = new System.Windows.Forms.Button();
            this.stockPanel = new System.Windows.Forms.Panel();
            this.productTableTableAdapter = new WindowsFormsApplication1.DatabaseDataSet1TableAdapters.ProductTableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet1)).BeginInit();
            this.stockPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(171, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Stock Of Medicine";
            // 
            // dgStock
            // 
            this.dgStock.AutoGenerateColumns = false;
            this.dgStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.productExpiryDataGridViewTextBoxColumn,
            this.textDateDataGridViewTextBoxColumn});
            this.dgStock.DataSource = this.productTableBindingSource;
            this.dgStock.Location = new System.Drawing.Point(3, 3);
            this.dgStock.Name = "dgStock";
            this.dgStock.Size = new System.Drawing.Size(443, 284);
            this.dgStock.TabIndex = 1;
            this.dgStock.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "ProductName";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            // 
            // productExpiryDataGridViewTextBoxColumn
            // 
            this.productExpiryDataGridViewTextBoxColumn.DataPropertyName = "ProductExpiry";
            this.productExpiryDataGridViewTextBoxColumn.HeaderText = "ProductExpiry";
            this.productExpiryDataGridViewTextBoxColumn.Name = "productExpiryDataGridViewTextBoxColumn";
            // 
            // textDateDataGridViewTextBoxColumn
            // 
            this.textDateDataGridViewTextBoxColumn.DataPropertyName = "TextDate";
            this.textDateDataGridViewTextBoxColumn.HeaderText = "TextDate";
            this.textDateDataGridViewTextBoxColumn.Name = "textDateDataGridViewTextBoxColumn";
            // 
            // productTableBindingSource
            // 
            this.productTableBindingSource.DataMember = "ProductTable";
            this.productTableBindingSource.DataSource = this.databaseDataSet1;
            // 
            // databaseDataSet1
            // 
            this.databaseDataSet1.DataSetName = "DatabaseDataSet1";
            this.databaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(373, 372);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 25);
            this.button1.TabIndex = 2;
            this.button1.Text = "Show";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // StkextBtn
            // 
            this.StkextBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StkextBtn.Location = new System.Drawing.Point(454, 372);
            this.StkextBtn.Name = "StkextBtn";
            this.StkextBtn.Size = new System.Drawing.Size(75, 25);
            this.StkextBtn.TabIndex = 2;
            this.StkextBtn.Text = "Exit";
            this.StkextBtn.UseVisualStyleBackColor = true;
            this.StkextBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // stockPanel
            // 
            this.stockPanel.Controls.Add(this.dgStock);
            this.stockPanel.Location = new System.Drawing.Point(43, 55);
            this.stockPanel.Name = "stockPanel";
            this.stockPanel.Size = new System.Drawing.Size(450, 290);
            this.stockPanel.TabIndex = 3;
            // 
            // productTableTableAdapter
            // 
            this.productTableTableAdapter.ClearBeforeFill = true;
            // 
            // StockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(558, 409);
            this.Controls.Add(this.stockPanel);
            this.Controls.Add(this.StkextBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "StockForm";
            this.Text = "StockForm";
            this.Load += new System.EventHandler(this.StockForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet1)).EndInit();
            this.stockPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgStock;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button StkextBtn;
        private System.Windows.Forms.Panel stockPanel;
        private DatabaseDataSet1 databaseDataSet1;
        private System.Windows.Forms.BindingSource productTableBindingSource;
        private DatabaseDataSet1TableAdapters.ProductTableTableAdapter productTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productExpiryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn textDateDataGridViewTextBoxColumn;
    }
}