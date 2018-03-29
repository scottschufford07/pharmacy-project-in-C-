namespace WindowsFormsApplication1
{
    partial class ProductForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.P_EXbtn = new System.Windows.Forms.Button();
            this.NameTxt = new System.Windows.Forms.TextBox();
            this.CompanyTxt = new System.Windows.Forms.TextBox();
            this.CatagoryTxt = new System.Windows.Forms.TextBox();
            this.cbName = new System.Windows.Forms.ComboBox();
            this.PackingTxt = new System.Windows.Forms.TextBox();
            this.PurchasePTxt1 = new System.Windows.Forms.TextBox();
            this.SalePtxt = new System.Windows.Forms.TextBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(157, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "product Form";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Company Name";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Catagory";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Packing";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Purchase Price";
            this.label6.Click += new System.EventHandler(this.label1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 251);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Sale Price";
            this.label7.Click += new System.EventHandler(this.label1_Click);
            // 
            // P_EXbtn
            // 
            this.P_EXbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P_EXbtn.Location = new System.Drawing.Point(240, 304);
            this.P_EXbtn.Name = "P_EXbtn";
            this.P_EXbtn.Size = new System.Drawing.Size(75, 23);
            this.P_EXbtn.TabIndex = 2;
            this.P_EXbtn.Text = "Exit";
            this.P_EXbtn.UseVisualStyleBackColor = true;
            this.P_EXbtn.Click += new System.EventHandler(this.P_EXbtn_Click);
            // 
            // NameTxt
            // 
            this.NameTxt.Location = new System.Drawing.Point(130, 59);
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.Size = new System.Drawing.Size(100, 20);
            this.NameTxt.TabIndex = 3;
            this.NameTxt.TextChanged += new System.EventHandler(this.NameTxt_TextChanged);
            // 
            // CompanyTxt
            // 
            this.CompanyTxt.Location = new System.Drawing.Point(130, 95);
            this.CompanyTxt.Name = "CompanyTxt";
            this.CompanyTxt.Size = new System.Drawing.Size(100, 20);
            this.CompanyTxt.TabIndex = 4;
            this.CompanyTxt.TextChanged += new System.EventHandler(this.CompanyTxt_TextChanged);
            // 
            // CatagoryTxt
            // 
            this.CatagoryTxt.Location = new System.Drawing.Point(130, 122);
            this.CatagoryTxt.Name = "CatagoryTxt";
            this.CatagoryTxt.Size = new System.Drawing.Size(100, 20);
            this.CatagoryTxt.TabIndex = 5;
            this.CatagoryTxt.TextChanged += new System.EventHandler(this.CatagoryTxt_TextChanged);
            // 
            // cbName
            // 
            this.cbName.FormattingEnabled = true;
            this.cbName.Location = new System.Drawing.Point(254, 116);
            this.cbName.Name = "cbName";
            this.cbName.Size = new System.Drawing.Size(121, 21);
            this.cbName.TabIndex = 6;
            this.cbName.SelectedIndexChanged += new System.EventHandler(this.cbName_SelectedIndexChanged);
            // 
            // PackingTxt
            // 
            this.PackingTxt.Location = new System.Drawing.Point(130, 185);
            this.PackingTxt.Name = "PackingTxt";
            this.PackingTxt.Size = new System.Drawing.Size(100, 20);
            this.PackingTxt.TabIndex = 8;
            this.PackingTxt.TextChanged += new System.EventHandler(this.PackingTxt_TextChanged);
            // 
            // PurchasePTxt1
            // 
            this.PurchasePTxt1.Location = new System.Drawing.Point(130, 215);
            this.PurchasePTxt1.Name = "PurchasePTxt1";
            this.PurchasePTxt1.Size = new System.Drawing.Size(100, 20);
            this.PurchasePTxt1.TabIndex = 9;
            this.PurchasePTxt1.TextChanged += new System.EventHandler(this.PurchasePTxt1_TextChanged);
            // 
            // SalePtxt
            // 
            this.SalePtxt.Location = new System.Drawing.Point(130, 251);
            this.SalePtxt.Name = "SalePtxt";
            this.SalePtxt.Size = new System.Drawing.Size(100, 20);
            this.SalePtxt.TabIndex = 10;
            this.SalePtxt.TextChanged += new System.EventHandler(this.SalePtxt_TextChanged);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(15, 303);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveBtn.TabIndex = 11;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(130, 304);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(75, 23);
            this.DeleteBtn.TabIndex = 13;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(461, 356);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.PurchasePTxt1);
            this.Controls.Add(this.PackingTxt);
            this.Controls.Add(this.cbName);
            this.Controls.Add(this.CatagoryTxt);
            this.Controls.Add(this.CompanyTxt);
            this.Controls.Add(this.NameTxt);
            this.Controls.Add(this.P_EXbtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SalePtxt);
            this.Name = "ProductForm";
            this.Text = "ProductForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button P_EXbtn;
        private System.Windows.Forms.TextBox NameTxt;
        private System.Windows.Forms.TextBox CompanyTxt;
        private System.Windows.Forms.TextBox CatagoryTxt;
        private System.Windows.Forms.ComboBox cbName;
        private System.Windows.Forms.TextBox PackingTxt;
        private System.Windows.Forms.TextBox PurchasePTxt1;
        private System.Windows.Forms.TextBox SalePtxt;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button DeleteBtn;
    }
}