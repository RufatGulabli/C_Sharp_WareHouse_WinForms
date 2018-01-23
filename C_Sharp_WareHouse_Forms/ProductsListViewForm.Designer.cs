namespace C_Sharp_WareHouse_Forms
{
    partial class ProductsDataGridtViewForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.btnSearchPRD = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlUpdate = new System.Windows.Forms.Panel();
            this.richTxtBxAddrUpd = new System.Windows.Forms.RichTextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numrcUpDwnPrice = new System.Windows.Forms.NumericUpDown();
            this.btnCanXUpd = new System.Windows.Forms.Button();
            this.txtBxNameUpd = new System.Windows.Forms.TextBox();
            this.btnSaveUpd = new System.Windows.Forms.Button();
            this.lbl4Upd = new System.Windows.Forms.Label();
            this.lbl3Upd = new System.Windows.Forms.Label();
            this.lbl2Upd = new System.Windows.Forms.Label();
            this.lbl1Upd = new System.Windows.Forms.Label();
            this.btnUpdatePRD = new System.Windows.Forms.Button();
            this.btnDeletePRD = new System.Windows.Forms.Button();
            this.btnAddPRD = new System.Windows.Forms.Button();
            this.dataGridViewPRD = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmContact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlSearch.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numrcUpDwnPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPRD)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSearch
            // 
            this.pnlSearch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlSearch.Controls.Add(this.btnSearchPRD);
            this.pnlSearch.Controls.Add(this.textBox3);
            this.pnlSearch.Controls.Add(this.label5);
            this.pnlSearch.Location = new System.Drawing.Point(194, 388);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(275, 92);
            this.pnlSearch.TabIndex = 33;
            // 
            // btnSearchPRD
            // 
            this.btnSearchPRD.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnSearchPRD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchPRD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearchPRD.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSearchPRD.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSearchPRD.Location = new System.Drawing.Point(74, 36);
            this.btnSearchPRD.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchPRD.Name = "btnSearchPRD";
            this.btnSearchPRD.Size = new System.Drawing.Size(189, 47);
            this.btnSearchPRD.TabIndex = 23;
            this.btnSearchPRD.Text = "Search";
            this.btnSearchPRD.UseVisualStyleBackColor = false;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.Cornsilk;
            this.textBox3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.Location = new System.Drawing.Point(74, 3);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(189, 26);
            this.textBox3.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(5, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "By Name";
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.BackColor = System.Drawing.Color.Transparent;
            this.pnlUpdate.Controls.Add(this.richTxtBxAddrUpd);
            this.pnlUpdate.Controls.Add(this.numericUpDown1);
            this.pnlUpdate.Controls.Add(this.numrcUpDwnPrice);
            this.pnlUpdate.Controls.Add(this.btnCanXUpd);
            this.pnlUpdate.Controls.Add(this.txtBxNameUpd);
            this.pnlUpdate.Controls.Add(this.btnSaveUpd);
            this.pnlUpdate.Controls.Add(this.lbl4Upd);
            this.pnlUpdate.Controls.Add(this.lbl3Upd);
            this.pnlUpdate.Controls.Add(this.lbl2Upd);
            this.pnlUpdate.Controls.Add(this.lbl1Upd);
            this.pnlUpdate.Location = new System.Drawing.Point(667, 386);
            this.pnlUpdate.Name = "pnlUpdate";
            this.pnlUpdate.Size = new System.Drawing.Size(572, 171);
            this.pnlUpdate.TabIndex = 32;
            this.pnlUpdate.Visible = false;
            // 
            // richTxtBxAddrUpd
            // 
            this.richTxtBxAddrUpd.BackColor = System.Drawing.Color.Cornsilk;
            this.richTxtBxAddrUpd.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTxtBxAddrUpd.Location = new System.Drawing.Point(357, 9);
            this.richTxtBxAddrUpd.Name = "richTxtBxAddrUpd";
            this.richTxtBxAddrUpd.Size = new System.Drawing.Size(189, 115);
            this.richTxtBxAddrUpd.TabIndex = 24;
            this.richTxtBxAddrUpd.Text = "";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.Color.Cornsilk;
            this.numericUpDown1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown1.Location = new System.Drawing.Point(78, 87);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(189, 26);
            this.numericUpDown1.TabIndex = 23;
            // 
            // numrcUpDwnPrice
            // 
            this.numrcUpDwnPrice.BackColor = System.Drawing.Color.Cornsilk;
            this.numrcUpDwnPrice.DecimalPlaces = 2;
            this.numrcUpDwnPrice.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numrcUpDwnPrice.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numrcUpDwnPrice.Location = new System.Drawing.Point(77, 48);
            this.numrcUpDwnPrice.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numrcUpDwnPrice.Name = "numrcUpDwnPrice";
            this.numrcUpDwnPrice.Size = new System.Drawing.Size(189, 26);
            this.numrcUpDwnPrice.TabIndex = 23;
            // 
            // btnCanXUpd
            // 
            this.btnCanXUpd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCanXUpd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCanXUpd.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCanXUpd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCanXUpd.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCanXUpd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCanXUpd.Location = new System.Drawing.Point(322, 139);
            this.btnCanXUpd.Name = "btnCanXUpd";
            this.btnCanXUpd.Size = new System.Drawing.Size(94, 27);
            this.btnCanXUpd.TabIndex = 21;
            this.btnCanXUpd.Text = "Cancel";
            this.btnCanXUpd.UseVisualStyleBackColor = false;
            // 
            // txtBxNameUpd
            // 
            this.txtBxNameUpd.BackColor = System.Drawing.Color.Cornsilk;
            this.txtBxNameUpd.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBxNameUpd.Location = new System.Drawing.Point(77, 10);
            this.txtBxNameUpd.Name = "txtBxNameUpd";
            this.txtBxNameUpd.Size = new System.Drawing.Size(189, 26);
            this.txtBxNameUpd.TabIndex = 11;
            // 
            // btnSaveUpd
            // 
            this.btnSaveUpd.BackColor = System.Drawing.Color.Green;
            this.btnSaveUpd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveUpd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSaveUpd.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSaveUpd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSaveUpd.Location = new System.Drawing.Point(154, 139);
            this.btnSaveUpd.Name = "btnSaveUpd";
            this.btnSaveUpd.Size = new System.Drawing.Size(94, 27);
            this.btnSaveUpd.TabIndex = 20;
            this.btnSaveUpd.Text = "Save";
            this.btnSaveUpd.UseVisualStyleBackColor = false;
            // 
            // lbl4Upd
            // 
            this.lbl4Upd.AutoSize = true;
            this.lbl4Upd.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl4Upd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl4Upd.Location = new System.Drawing.Point(272, 13);
            this.lbl4Upd.Name = "lbl4Upd";
            this.lbl4Upd.Size = new System.Drawing.Size(79, 18);
            this.lbl4Upd.TabIndex = 15;
            this.lbl4Upd.Text = "Description";
            // 
            // lbl3Upd
            // 
            this.lbl3Upd.AutoSize = true;
            this.lbl3Upd.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl3Upd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl3Upd.Location = new System.Drawing.Point(10, 89);
            this.lbl3Upd.Name = "lbl3Upd";
            this.lbl3Upd.Size = new System.Drawing.Size(62, 18);
            this.lbl3Upd.TabIndex = 16;
            this.lbl3Upd.Text = "Quantity";
            // 
            // lbl2Upd
            // 
            this.lbl2Upd.AutoSize = true;
            this.lbl2Upd.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl2Upd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl2Upd.Location = new System.Drawing.Point(27, 50);
            this.lbl2Upd.Name = "lbl2Upd";
            this.lbl2Upd.Size = new System.Drawing.Size(39, 18);
            this.lbl2Upd.TabIndex = 17;
            this.lbl2Upd.Text = "Price";
            // 
            // lbl1Upd
            // 
            this.lbl1Upd.AutoSize = true;
            this.lbl1Upd.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl1Upd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl1Upd.Location = new System.Drawing.Point(27, 14);
            this.lbl1Upd.Name = "lbl1Upd";
            this.lbl1Upd.Size = new System.Drawing.Size(45, 18);
            this.lbl1Upd.TabIndex = 10;
            this.lbl1Upd.Text = "Name";
            // 
            // btnUpdatePRD
            // 
            this.btnUpdatePRD.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnUpdatePRD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdatePRD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdatePRD.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUpdatePRD.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnUpdatePRD.Location = new System.Drawing.Point(13, 505);
            this.btnUpdatePRD.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdatePRD.Name = "btnUpdatePRD";
            this.btnUpdatePRD.Size = new System.Drawing.Size(162, 50);
            this.btnUpdatePRD.TabIndex = 29;
            this.btnUpdatePRD.Text = "Update Product";
            this.btnUpdatePRD.UseVisualStyleBackColor = false;
            // 
            // btnDeletePRD
            // 
            this.btnDeletePRD.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnDeletePRD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeletePRD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeletePRD.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeletePRD.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDeletePRD.Location = new System.Drawing.Point(13, 447);
            this.btnDeletePRD.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeletePRD.Name = "btnDeletePRD";
            this.btnDeletePRD.Size = new System.Drawing.Size(162, 50);
            this.btnDeletePRD.TabIndex = 30;
            this.btnDeletePRD.Text = "Delete Product";
            this.btnDeletePRD.UseVisualStyleBackColor = false;
            // 
            // btnAddPRD
            // 
            this.btnAddPRD.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnAddPRD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddPRD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddPRD.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddPRD.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddPRD.Location = new System.Drawing.Point(13, 388);
            this.btnAddPRD.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddPRD.Name = "btnAddPRD";
            this.btnAddPRD.Size = new System.Drawing.Size(162, 50);
            this.btnAddPRD.TabIndex = 31;
            this.btnAddPRD.Text = "Add New Product";
            this.btnAddPRD.UseVisualStyleBackColor = false;
            this.btnAddPRD.Click += new System.EventHandler(this.btnAddPRD_Click);
            // 
            // dataGridViewPRD
            // 
            this.dataGridViewPRD.AllowUserToResizeRows = false;
            this.dataGridViewPRD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewPRD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPRD.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridViewPRD.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPRD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewPRD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPRD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.clmName,
            this.clmContact,
            this.clmEmail,
            this.Column2});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewPRD.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewPRD.Location = new System.Drawing.Point(12, 40);
            this.dataGridViewPRD.MultiSelect = false;
            this.dataGridViewPRD.Name = "dataGridViewPRD";
            this.dataGridViewPRD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPRD.Size = new System.Drawing.Size(1222, 341);
            this.dataGridViewPRD.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(407, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 23);
            this.label1.TabIndex = 35;
            this.label1.Text = "LIST OF ALL PRODUCTS";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "No";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // clmName
            // 
            this.clmName.HeaderText = "Article Name";
            this.clmName.Name = "clmName";
            // 
            // clmContact
            // 
            this.clmContact.HeaderText = "Price";
            this.clmContact.Name = "clmContact";
            // 
            // clmEmail
            // 
            this.clmEmail.HeaderText = "Quantity";
            this.clmEmail.Name = "clmEmail";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Description";
            this.Column2.Name = "Column2";
            // 
            // ProductsDataGridtViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 564);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewPRD);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.pnlUpdate);
            this.Controls.Add(this.btnUpdatePRD);
            this.Controls.Add(this.btnDeletePRD);
            this.Controls.Add(this.btnAddPRD);
            this.Name = "ProductsDataGridtViewForm";
            this.Text = "ProductsListViewForm";
            this.Load += new System.EventHandler(this.ProductsDataGridtViewForm_Load);
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.pnlUpdate.ResumeLayout(false);
            this.pnlUpdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numrcUpDwnPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPRD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Button btnSearchPRD;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnlUpdate;
        private System.Windows.Forms.Button btnCanXUpd;
        private System.Windows.Forms.TextBox txtBxNameUpd;
        private System.Windows.Forms.Button btnSaveUpd;
        private System.Windows.Forms.Label lbl4Upd;
        private System.Windows.Forms.Label lbl3Upd;
        private System.Windows.Forms.Label lbl2Upd;
        private System.Windows.Forms.Label lbl1Upd;
        private System.Windows.Forms.Button btnUpdatePRD;
        private System.Windows.Forms.Button btnDeletePRD;
        private System.Windows.Forms.Button btnAddPRD;
        private System.Windows.Forms.DataGridView dataGridViewPRD;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numrcUpDwnPrice;
        private System.Windows.Forms.RichTextBox richTxtBxAddrUpd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmContact;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Label label1;
    }
}