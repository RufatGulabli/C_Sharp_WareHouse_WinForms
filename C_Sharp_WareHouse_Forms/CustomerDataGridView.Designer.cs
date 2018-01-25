namespace C_Sharp_WareHouse_Forms
{
    partial class CustomerDataGridView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerDataGridView));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pnlUpdate = new System.Windows.Forms.Panel();
            this.btnCanXUpd = new System.Windows.Forms.Button();
            this.txtBxNameUpd = new System.Windows.Forms.TextBox();
            this.btnSaveUpd = new System.Windows.Forms.Button();
            this.txtBxSurnameUpd = new System.Windows.Forms.TextBox();
            this.lbl5Upd = new System.Windows.Forms.Label();
            this.txtBoxEmailUpd = new System.Windows.Forms.TextBox();
            this.lbl4Upd = new System.Windows.Forms.Label();
            this.maskdTxtBxPhoneUpd = new System.Windows.Forms.MaskedTextBox();
            this.lbl3Upd = new System.Windows.Forms.Label();
            this.richTxtBxAddrUpd = new System.Windows.Forms.RichTextBox();
            this.lbl2Upd = new System.Windows.Forms.Label();
            this.lbl1Upd = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtboxNameSearch = new System.Windows.Forms.TextBox();
            this.txtBxSurnameSearch = new System.Windows.Forms.TextBox();
            this.txtBxEmailSearch = new System.Windows.Forms.TextBox();
            this.msktxtBxSearch = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle13.NullValue = null;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.Location = new System.Drawing.Point(12, 219);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1236, 373);
            this.dataGridView1.TabIndex = 8;
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.BackColor = System.Drawing.Color.Transparent;
            this.pnlUpdate.Controls.Add(this.btnCanXUpd);
            this.pnlUpdate.Controls.Add(this.txtBxNameUpd);
            this.pnlUpdate.Controls.Add(this.btnSaveUpd);
            this.pnlUpdate.Controls.Add(this.txtBxSurnameUpd);
            this.pnlUpdate.Controls.Add(this.lbl5Upd);
            this.pnlUpdate.Controls.Add(this.txtBoxEmailUpd);
            this.pnlUpdate.Controls.Add(this.lbl4Upd);
            this.pnlUpdate.Controls.Add(this.maskdTxtBxPhoneUpd);
            this.pnlUpdate.Controls.Add(this.lbl3Upd);
            this.pnlUpdate.Controls.Add(this.richTxtBxAddrUpd);
            this.pnlUpdate.Controls.Add(this.lbl2Upd);
            this.pnlUpdate.Controls.Add(this.lbl1Upd);
            this.pnlUpdate.Location = new System.Drawing.Point(673, 37);
            this.pnlUpdate.Name = "pnlUpdate";
            this.pnlUpdate.Size = new System.Drawing.Size(575, 171);
            this.pnlUpdate.TabIndex = 7;
            this.pnlUpdate.Visible = false;
            // 
            // btnCanXUpd
            // 
            this.btnCanXUpd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCanXUpd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCanXUpd.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCanXUpd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCanXUpd.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCanXUpd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCanXUpd.Location = new System.Drawing.Point(463, 137);
            this.btnCanXUpd.Name = "btnCanXUpd";
            this.btnCanXUpd.Size = new System.Drawing.Size(94, 26);
            this.btnCanXUpd.TabIndex = 6;
            this.btnCanXUpd.Text = "Cancel";
            this.btnCanXUpd.UseVisualStyleBackColor = false;
            this.btnCanXUpd.Click += new System.EventHandler(this.btnCanXUpd_Click);
            // 
            // txtBxNameUpd
            // 
            this.txtBxNameUpd.BackColor = System.Drawing.Color.White;
            this.txtBxNameUpd.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBxNameUpd.Location = new System.Drawing.Point(109, 14);
            this.txtBxNameUpd.Name = "txtBxNameUpd";
            this.txtBxNameUpd.Size = new System.Drawing.Size(189, 26);
            this.txtBxNameUpd.TabIndex = 0;
            // 
            // btnSaveUpd
            // 
            this.btnSaveUpd.BackColor = System.Drawing.Color.Green;
            this.btnSaveUpd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveUpd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSaveUpd.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSaveUpd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSaveUpd.Location = new System.Drawing.Point(339, 138);
            this.btnSaveUpd.Name = "btnSaveUpd";
            this.btnSaveUpd.Size = new System.Drawing.Size(94, 27);
            this.btnSaveUpd.TabIndex = 5;
            this.btnSaveUpd.Text = "Save";
            this.btnSaveUpd.UseVisualStyleBackColor = false;
            this.btnSaveUpd.Click += new System.EventHandler(this.btnSaveUpd_Click);
            // 
            // txtBxSurnameUpd
            // 
            this.txtBxSurnameUpd.BackColor = System.Drawing.Color.White;
            this.txtBxSurnameUpd.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBxSurnameUpd.Location = new System.Drawing.Point(110, 54);
            this.txtBxSurnameUpd.Name = "txtBxSurnameUpd";
            this.txtBxSurnameUpd.Size = new System.Drawing.Size(189, 26);
            this.txtBxSurnameUpd.TabIndex = 1;
            // 
            // lbl5Upd
            // 
            this.lbl5Upd.AutoSize = true;
            this.lbl5Upd.BackColor = System.Drawing.Color.Transparent;
            this.lbl5Upd.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl5Upd.ForeColor = System.Drawing.Color.White;
            this.lbl5Upd.Location = new System.Drawing.Point(304, 14);
            this.lbl5Upd.Name = "lbl5Upd";
            this.lbl5Upd.Size = new System.Drawing.Size(58, 18);
            this.lbl5Upd.TabIndex = 14;
            this.lbl5Upd.Text = "Address";
            // 
            // txtBoxEmailUpd
            // 
            this.txtBoxEmailUpd.BackColor = System.Drawing.Color.White;
            this.txtBoxEmailUpd.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBoxEmailUpd.Location = new System.Drawing.Point(110, 99);
            this.txtBoxEmailUpd.Name = "txtBoxEmailUpd";
            this.txtBoxEmailUpd.Size = new System.Drawing.Size(189, 26);
            this.txtBoxEmailUpd.TabIndex = 2;
            // 
            // lbl4Upd
            // 
            this.lbl4Upd.AutoSize = true;
            this.lbl4Upd.BackColor = System.Drawing.Color.Transparent;
            this.lbl4Upd.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl4Upd.ForeColor = System.Drawing.Color.White;
            this.lbl4Upd.Location = new System.Drawing.Point(2, 145);
            this.lbl4Upd.Name = "lbl4Upd";
            this.lbl4Upd.Size = new System.Drawing.Size(102, 18);
            this.lbl4Upd.TabIndex = 15;
            this.lbl4Upd.Text = "Phone Number";
            // 
            // maskdTxtBxPhoneUpd
            // 
            this.maskdTxtBxPhoneUpd.BackColor = System.Drawing.Color.White;
            this.maskdTxtBxPhoneUpd.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskdTxtBxPhoneUpd.Location = new System.Drawing.Point(110, 139);
            this.maskdTxtBxPhoneUpd.Mask = "(+99900) 000-00-00";
            this.maskdTxtBxPhoneUpd.Name = "maskdTxtBxPhoneUpd";
            this.maskdTxtBxPhoneUpd.Size = new System.Drawing.Size(189, 26);
            this.maskdTxtBxPhoneUpd.TabIndex = 3;
            // 
            // lbl3Upd
            // 
            this.lbl3Upd.AutoSize = true;
            this.lbl3Upd.BackColor = System.Drawing.Color.Transparent;
            this.lbl3Upd.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl3Upd.ForeColor = System.Drawing.Color.White;
            this.lbl3Upd.Location = new System.Drawing.Point(62, 102);
            this.lbl3Upd.Name = "lbl3Upd";
            this.lbl3Upd.Size = new System.Drawing.Size(42, 18);
            this.lbl3Upd.TabIndex = 16;
            this.lbl3Upd.Text = "Email";
            // 
            // richTxtBxAddrUpd
            // 
            this.richTxtBxAddrUpd.BackColor = System.Drawing.Color.White;
            this.richTxtBxAddrUpd.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTxtBxAddrUpd.Location = new System.Drawing.Point(368, 10);
            this.richTxtBxAddrUpd.Name = "richTxtBxAddrUpd";
            this.richTxtBxAddrUpd.Size = new System.Drawing.Size(189, 115);
            this.richTxtBxAddrUpd.TabIndex = 4;
            this.richTxtBxAddrUpd.Text = "";
            // 
            // lbl2Upd
            // 
            this.lbl2Upd.AutoSize = true;
            this.lbl2Upd.BackColor = System.Drawing.Color.Transparent;
            this.lbl2Upd.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl2Upd.ForeColor = System.Drawing.Color.White;
            this.lbl2Upd.Location = new System.Drawing.Point(41, 57);
            this.lbl2Upd.Name = "lbl2Upd";
            this.lbl2Upd.Size = new System.Drawing.Size(63, 18);
            this.lbl2Upd.TabIndex = 17;
            this.lbl2Upd.Text = "Surname";
            // 
            // lbl1Upd
            // 
            this.lbl1Upd.AutoSize = true;
            this.lbl1Upd.BackColor = System.Drawing.Color.Transparent;
            this.lbl1Upd.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl1Upd.ForeColor = System.Drawing.Color.White;
            this.lbl1Upd.Location = new System.Drawing.Point(59, 18);
            this.lbl1Upd.Name = "lbl1Upd";
            this.lbl1Upd.Size = new System.Drawing.Size(45, 18);
            this.lbl1Upd.TabIndex = 10;
            this.lbl1Upd.Text = "Name";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUpdate.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnUpdate.Location = new System.Drawing.Point(321, 105);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(179, 65);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update Customer";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelete.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDelete.Location = new System.Drawing.Point(107, 105);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(179, 65);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete Customer";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAdd.Location = new System.Drawing.Point(13, 105);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(69, 67);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(467, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 25);
            this.label1.TabIndex = 29;
            this.label1.Text = "LIST OF ALL CUSTOMERS";
            // 
            // txtboxNameSearch
            // 
            this.txtboxNameSearch.BackColor = System.Drawing.Color.White;
            this.txtboxNameSearch.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtboxNameSearch.ForeColor = System.Drawing.Color.Silver;
            this.txtboxNameSearch.Location = new System.Drawing.Point(14, 187);
            this.txtboxNameSearch.Name = "txtboxNameSearch";
            this.txtboxNameSearch.Size = new System.Drawing.Size(147, 26);
            this.txtboxNameSearch.TabIndex = 3;
            this.txtboxNameSearch.Text = "Search by Name";
            this.txtboxNameSearch.Enter += new System.EventHandler(this.ClearText);
            this.txtboxNameSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtboxNameSearch_KeyUp);
            this.txtboxNameSearch.Leave += new System.EventHandler(this.txtboxNameSearch_Leave);
            // 
            // txtBxSurnameSearch
            // 
            this.txtBxSurnameSearch.BackColor = System.Drawing.Color.White;
            this.txtBxSurnameSearch.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBxSurnameSearch.ForeColor = System.Drawing.Color.Silver;
            this.txtBxSurnameSearch.Location = new System.Drawing.Point(166, 187);
            this.txtBxSurnameSearch.Name = "txtBxSurnameSearch";
            this.txtBxSurnameSearch.Size = new System.Drawing.Size(147, 26);
            this.txtBxSurnameSearch.TabIndex = 4;
            this.txtBxSurnameSearch.Text = "Search by Surname";
            this.txtBxSurnameSearch.Enter += new System.EventHandler(this.ClearText);
            this.txtBxSurnameSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBxSurnameSearch_KeyUp);
            this.txtBxSurnameSearch.Leave += new System.EventHandler(this.txtBxSurnameSearch_Leave);
            // 
            // txtBxEmailSearch
            // 
            this.txtBxEmailSearch.BackColor = System.Drawing.Color.White;
            this.txtBxEmailSearch.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBxEmailSearch.ForeColor = System.Drawing.Color.Silver;
            this.txtBxEmailSearch.Location = new System.Drawing.Point(319, 187);
            this.txtBxEmailSearch.Name = "txtBxEmailSearch";
            this.txtBxEmailSearch.Size = new System.Drawing.Size(147, 26);
            this.txtBxEmailSearch.TabIndex = 5;
            this.txtBxEmailSearch.Text = "Search by Email";
            this.txtBxEmailSearch.Enter += new System.EventHandler(this.ClearText);
            this.txtBxEmailSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBxEmailSearch_KeyUp);
            this.txtBxEmailSearch.Leave += new System.EventHandler(this.txtBxEmailSearch_Leave);
            // 
            // msktxtBxSearch
            // 
            this.msktxtBxSearch.BackColor = System.Drawing.Color.White;
            this.msktxtBxSearch.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.msktxtBxSearch.ForeColor = System.Drawing.Color.Silver;
            this.msktxtBxSearch.Location = new System.Drawing.Point(478, 187);
            this.msktxtBxSearch.Mask = "(+99900) 000-00-00";
            this.msktxtBxSearch.Name = "msktxtBxSearch";
            this.msktxtBxSearch.Size = new System.Drawing.Size(147, 26);
            this.msktxtBxSearch.TabIndex = 6;
            this.msktxtBxSearch.Enter += new System.EventHandler(this.msktxtBxSearch_Enter);
            this.msktxtBxSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.msktxtBxSearch_KeyUp);
            // 
            // CustomerDataGridView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1260, 600);
            this.Controls.Add(this.txtBxSurnameSearch);
            this.Controls.Add(this.txtBxEmailSearch);
            this.Controls.Add(this.txtboxNameSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlUpdate);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.msktxtBxSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.Color.CadetBlue;
            this.Name = "CustomerDataGridView";
            this.Text = "CustomerDataGridView";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CustomerDataGridView_FormClosed);
            this.Load += new System.EventHandler(this.CustomerDataGridView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnlUpdate.ResumeLayout(false);
            this.pnlUpdate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel pnlUpdate;
        private System.Windows.Forms.Button btnCanXUpd;
        private System.Windows.Forms.TextBox txtBxNameUpd;
        private System.Windows.Forms.Button btnSaveUpd;
        private System.Windows.Forms.TextBox txtBxSurnameUpd;
        private System.Windows.Forms.Label lbl5Upd;
        private System.Windows.Forms.TextBox txtBoxEmailUpd;
        private System.Windows.Forms.Label lbl4Upd;
        private System.Windows.Forms.MaskedTextBox maskdTxtBxPhoneUpd;
        private System.Windows.Forms.Label lbl3Upd;
        private System.Windows.Forms.RichTextBox richTxtBxAddrUpd;
        private System.Windows.Forms.Label lbl2Upd;
        private System.Windows.Forms.Label lbl1Upd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtboxNameSearch;
        private System.Windows.Forms.TextBox txtBxSurnameSearch;
        private System.Windows.Forms.TextBox txtBxEmailSearch;
        private System.Windows.Forms.MaskedTextBox msktxtBxSearch;
    }
}