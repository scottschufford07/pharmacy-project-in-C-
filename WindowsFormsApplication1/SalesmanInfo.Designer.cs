namespace WindowsFormsApplication1
{
    partial class SalesManInfo
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
            this.SalesmanName = new System.Windows.Forms.Label();
            this.SMextBtn = new System.Windows.Forms.Button();
            this.dgSalesman = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesmanNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesmanQualificationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesmanCityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesmanPhoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesManTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet2 = new WindowsFormsApplication1.DatabaseDataSet2();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtQualification = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.salesmanQualification = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.salesmanPanel = new System.Windows.Forms.Panel();
            this.salesmanshowBtn = new System.Windows.Forms.Button();
            this.salesManTableTableAdapter = new WindowsFormsApplication1.DatabaseDataSet2TableAdapters.SalesManTableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgSalesman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesManTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet2)).BeginInit();
            this.salesmanPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SalesmanName
            // 
            this.SalesmanName.AutoSize = true;
            this.SalesmanName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesmanName.Location = new System.Drawing.Point(79, 56);
            this.SalesmanName.Name = "SalesmanName";
            this.SalesmanName.Size = new System.Drawing.Size(35, 13);
            this.SalesmanName.TabIndex = 0;
            this.SalesmanName.Text = "Name";
            this.SalesmanName.Click += new System.EventHandler(this.label1_Click);
            // 
            // SMextBtn
            // 
            this.SMextBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SMextBtn.Location = new System.Drawing.Point(295, 204);
            this.SMextBtn.Name = "SMextBtn";
            this.SMextBtn.Size = new System.Drawing.Size(66, 25);
            this.SMextBtn.TabIndex = 2;
            this.SMextBtn.Text = "Exit";
            this.SMextBtn.UseVisualStyleBackColor = true;
            this.SMextBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgSalesman
            // 
            this.dgSalesman.AutoGenerateColumns = false;
            this.dgSalesman.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSalesman.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.salesmanNameDataGridViewTextBoxColumn,
            this.salesmanQualificationDataGridViewTextBoxColumn,
            this.salesmanCityDataGridViewTextBoxColumn,
            this.salesmanPhoneNumberDataGridViewTextBoxColumn});
            this.dgSalesman.DataSource = this.salesManTableBindingSource;
            this.dgSalesman.Location = new System.Drawing.Point(0, 0);
            this.dgSalesman.Name = "dgSalesman";
            this.dgSalesman.Size = new System.Drawing.Size(348, 99);
            this.dgSalesman.TabIndex = 3;
            this.dgSalesman.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSalesman_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // salesmanNameDataGridViewTextBoxColumn
            // 
            this.salesmanNameDataGridViewTextBoxColumn.DataPropertyName = "SalesmanName";
            this.salesmanNameDataGridViewTextBoxColumn.HeaderText = "SalesmanName";
            this.salesmanNameDataGridViewTextBoxColumn.Name = "salesmanNameDataGridViewTextBoxColumn";
            // 
            // salesmanQualificationDataGridViewTextBoxColumn
            // 
            this.salesmanQualificationDataGridViewTextBoxColumn.DataPropertyName = "SalesmanQualification";
            this.salesmanQualificationDataGridViewTextBoxColumn.HeaderText = "SalesmanQualification";
            this.salesmanQualificationDataGridViewTextBoxColumn.Name = "salesmanQualificationDataGridViewTextBoxColumn";
            // 
            // salesmanCityDataGridViewTextBoxColumn
            // 
            this.salesmanCityDataGridViewTextBoxColumn.DataPropertyName = "SalesmanCity";
            this.salesmanCityDataGridViewTextBoxColumn.HeaderText = "SalesmanCity";
            this.salesmanCityDataGridViewTextBoxColumn.Name = "salesmanCityDataGridViewTextBoxColumn";
            // 
            // salesmanPhoneNumberDataGridViewTextBoxColumn
            // 
            this.salesmanPhoneNumberDataGridViewTextBoxColumn.DataPropertyName = "SalesmanPhoneNumber";
            this.salesmanPhoneNumberDataGridViewTextBoxColumn.HeaderText = "SalesmanPhoneNumber";
            this.salesmanPhoneNumberDataGridViewTextBoxColumn.Name = "salesmanPhoneNumberDataGridViewTextBoxColumn";
            // 
            // salesManTableBindingSource
            // 
            this.salesManTableBindingSource.DataMember = "SalesManTable";
            this.salesManTableBindingSource.DataSource = this.databaseDataSet2;
            // 
            // databaseDataSet2
            // 
            this.databaseDataSet2.DataSetName = "DatabaseDataSet2";
            this.databaseDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(122, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "SalesMan Information";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(211, 206);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(62, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(188, 55);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(139, 20);
            this.txtName.TabIndex = 8;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtQualification
            // 
            this.txtQualification.Location = new System.Drawing.Point(188, 93);
            this.txtQualification.Name = "txtQualification";
            this.txtQualification.Size = new System.Drawing.Size(139, 20);
            this.txtQualification.TabIndex = 9;
            this.txtQualification.TextChanged += new System.EventHandler(this.txtQualification_TextChanged);
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(188, 132);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(139, 20);
            this.txtCity.TabIndex = 10;
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(188, 164);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(139, 20);
            this.txtNumber.TabIndex = 11;
            // 
            // salesmanQualification
            // 
            this.salesmanQualification.AutoSize = true;
            this.salesmanQualification.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesmanQualification.Location = new System.Drawing.Point(84, 93);
            this.salesmanQualification.Name = "salesmanQualification";
            this.salesmanQualification.Size = new System.Drawing.Size(65, 13);
            this.salesmanQualification.TabIndex = 12;
            this.salesmanQualification.Text = "Qualification";
            this.salesmanQualification.Click += new System.EventHandler(this.salesmanQualification_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "City";
            // 
            // salesmanPanel
            // 
            this.salesmanPanel.Controls.Add(this.dgSalesman);
            this.salesmanPanel.Location = new System.Drawing.Point(12, 263);
            this.salesmanPanel.Name = "salesmanPanel";
            this.salesmanPanel.Size = new System.Drawing.Size(349, 100);
            this.salesmanPanel.TabIndex = 16;
            // 
            // salesmanshowBtn
            // 
            this.salesmanshowBtn.Location = new System.Drawing.Point(378, 262);
            this.salesmanshowBtn.Name = "salesmanshowBtn";
            this.salesmanshowBtn.Size = new System.Drawing.Size(75, 100);
            this.salesmanshowBtn.TabIndex = 17;
            this.salesmanshowBtn.Text = "Show";
            this.salesmanshowBtn.UseVisualStyleBackColor = true;
            this.salesmanshowBtn.Click += new System.EventHandler(this.salesmanshowBtn_Click);
            // 
            // salesManTableTableAdapter
            // 
            this.salesManTableTableAdapter.ClearBeforeFill = true;
            // 
            // SalesManInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(465, 380);
            this.Controls.Add(this.salesmanshowBtn);
            this.Controls.Add(this.salesmanPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.salesmanQualification);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtQualification);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SMextBtn);
            this.Controls.Add(this.SalesmanName);
            this.Name = "SalesManInfo";
            this.Text = "SalesManInfo";
            this.Load += new System.EventHandler(this.SalesManInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgSalesman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesManTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet2)).EndInit();
            this.salesmanPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SalesmanName;
        private System.Windows.Forms.Button SMextBtn;
        private System.Windows.Forms.DataGridView dgSalesman;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtQualification;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label salesmanQualification;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel salesmanPanel;
        private System.Windows.Forms.Button salesmanshowBtn;
        private DatabaseDataSet2 databaseDataSet2;
        private System.Windows.Forms.BindingSource salesManTableBindingSource;
        private DatabaseDataSet2TableAdapters.SalesManTableTableAdapter salesManTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesmanNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesmanQualificationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesmanCityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesmanPhoneNumberDataGridViewTextBoxColumn;
    }
}