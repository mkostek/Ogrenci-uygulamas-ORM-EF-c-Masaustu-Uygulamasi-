namespace student
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
        	this.label1 = new System.Windows.Forms.Label();
        	this.label2 = new System.Windows.Forms.Label();
        	this.label3 = new System.Windows.Forms.Label();
        	this.txtName = new System.Windows.Forms.TextBox();
        	this.txtCity = new System.Windows.Forms.TextBox();
        	this.txtAge = new System.Windows.Forms.TextBox();
        	this.cmbGende = new System.Windows.Forms.Label();
        	this.dataGridView1 = new System.Windows.Forms.DataGridView();
        	this.lblID = new System.Windows.Forms.Label();
        	this.btnSave = new System.Windows.Forms.Button();
        	this.btnUpdate = new System.Windows.Forms.Button();
        	this.btnDelete = new System.Windows.Forms.Button();
        	this.cmbGender = new System.Windows.Forms.ComboBox();
        	((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
        	this.SuspendLayout();
        	// 
        	// label1
        	// 
        	this.label1.AutoSize = true;
        	this.label1.Location = new System.Drawing.Point(73, 29);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(46, 13);
        	this.label1.TabIndex = 0;
        	this.label1.Text = "txtName";
        	// 
        	// label2
        	// 
        	this.label2.AutoSize = true;
        	this.label2.Location = new System.Drawing.Point(73, 63);
        	this.label2.Name = "label2";
        	this.label2.Size = new System.Drawing.Size(35, 13);
        	this.label2.TabIndex = 1;
        	this.label2.Text = "txtCity";
        	// 
        	// label3
        	// 
        	this.label3.AutoSize = true;
        	this.label3.Location = new System.Drawing.Point(73, 92);
        	this.label3.Name = "label3";
        	this.label3.Size = new System.Drawing.Size(37, 13);
        	this.label3.TabIndex = 2;
        	this.label3.Text = "txtAge";
        	// 
        	// txtName
        	// 
        	this.txtName.Location = new System.Drawing.Point(135, 21);
        	this.txtName.Name = "txtName";
        	this.txtName.Size = new System.Drawing.Size(100, 20);
        	this.txtName.TabIndex = 3;
        	// 
        	// txtCity
        	// 
        	this.txtCity.Location = new System.Drawing.Point(135, 60);
        	this.txtCity.Name = "txtCity";
        	this.txtCity.Size = new System.Drawing.Size(100, 20);
        	this.txtCity.TabIndex = 4;
        	// 
        	// txtAge
        	// 
        	this.txtAge.Location = new System.Drawing.Point(135, 92);
        	this.txtAge.Name = "txtAge";
        	this.txtAge.Size = new System.Drawing.Size(100, 20);
        	this.txtAge.TabIndex = 5;
        	// 
        	// cmbGende
        	// 
        	this.cmbGende.AutoSize = true;
        	this.cmbGende.Location = new System.Drawing.Point(73, 131);
        	this.cmbGende.Name = "cmbGende";
        	this.cmbGende.Size = new System.Drawing.Size(62, 13);
        	this.cmbGende.TabIndex = 6;
        	this.cmbGende.Text = "cmbGender";
        	// 
        	// dataGridView1
        	// 
        	this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        	this.dataGridView1.Location = new System.Drawing.Point(73, 183);
        	this.dataGridView1.Name = "dataGridView1";
        	this.dataGridView1.Size = new System.Drawing.Size(482, 150);
        	this.dataGridView1.TabIndex = 8;
        	this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1CellClick);
        	// 
        	// lblID
        	// 
        	this.lblID.AutoSize = true;
        	this.lblID.Location = new System.Drawing.Point(419, 29);
        	this.lblID.Name = "lblID";
        	this.lblID.Size = new System.Drawing.Size(40, 13);
        	this.lblID.TabIndex = 9;
        	this.lblID.Text = "labelID";
        	// 
        	// btnSave
        	// 
        	this.btnSave.Location = new System.Drawing.Point(283, 21);
        	this.btnSave.Name = "btnSave";
        	this.btnSave.Size = new System.Drawing.Size(75, 23);
        	this.btnSave.TabIndex = 10;
        	this.btnSave.Text = "save";
        	this.btnSave.UseVisualStyleBackColor = true;
        	this.btnSave.Click += new System.EventHandler(this.BtnSaveClick);
        	// 
        	// btnUpdate
        	// 
        	this.btnUpdate.Location = new System.Drawing.Point(280, 60);
        	this.btnUpdate.Name = "btnUpdate";
        	this.btnUpdate.Size = new System.Drawing.Size(75, 23);
        	this.btnUpdate.TabIndex = 11;
        	this.btnUpdate.Text = "update";
        	this.btnUpdate.UseVisualStyleBackColor = true;
        	this.btnUpdate.Click += new System.EventHandler(this.BtnUpdateClick);
        	// 
        	// btnDelete
        	// 
        	this.btnDelete.Location = new System.Drawing.Point(280, 92);
        	this.btnDelete.Name = "btnDelete";
        	this.btnDelete.Size = new System.Drawing.Size(75, 23);
        	this.btnDelete.TabIndex = 12;
        	this.btnDelete.Text = "delete";
        	this.btnDelete.UseVisualStyleBackColor = true;
        	this.btnDelete.Click += new System.EventHandler(this.BtnDeleteClick);
        	// 
        	// cmbGender
        	// 
        	this.cmbGender.FormattingEnabled = true;
        	this.cmbGender.Location = new System.Drawing.Point(141, 128);
        	this.cmbGender.Name = "cmbGender";
        	this.cmbGender.Size = new System.Drawing.Size(121, 21);
        	this.cmbGender.TabIndex = 13;
        	// 
        	// Form1
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(626, 350);
        	this.Controls.Add(this.cmbGender);
        	this.Controls.Add(this.btnDelete);
        	this.Controls.Add(this.btnUpdate);
        	this.Controls.Add(this.btnSave);
        	this.Controls.Add(this.lblID);
        	this.Controls.Add(this.dataGridView1);
        	this.Controls.Add(this.cmbGende);
        	this.Controls.Add(this.txtAge);
        	this.Controls.Add(this.txtCity);
        	this.Controls.Add(this.txtName);
        	this.Controls.Add(this.label3);
        	this.Controls.Add(this.label2);
        	this.Controls.Add(this.label1);
        	this.Name = "Form1";
        	this.Text = "Form1";
        	this.Load += new System.EventHandler(this.Form1Load);
        	((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
        	this.ResumeLayout(false);
        	this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label cmbGende;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cmbGender;
    }
}

