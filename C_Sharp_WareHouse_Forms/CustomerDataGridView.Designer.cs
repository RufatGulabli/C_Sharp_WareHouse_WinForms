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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmContact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlSearch.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.clmName,
            this.clmSurname,
            this.clmContact,
            this.clmEmail,
            this.Column2});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.Location = new System.Drawing.Point(12, 40);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1245, 373);
            this.dataGridView1.TabIndex = 10;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "No";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // clmName
            // 
            this.clmName.HeaderText = "Name";
            this.clmName.Name = "clmName";
            // 
            // clmSurname
            // 
            this.clmSurname.HeaderText = "Surname";
            this.clmSurname.Name = "clmSurname";
            // 
            // clmContact
            // 
            this.clmContact.HeaderText = "Phone";
            this.clmContact.Name = "clmContact";
            // 
            // clmEmail
            // 
            this.clmEmail.HeaderText = "Email";
            this.clmEmail.Name = "clmEmail";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Address";
            this.Column2.Name = "Column2";
            // 
            // pnlSearch
            // 
            this.pnlSearch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlSearch.Controls.Add(this.button1);
            this.pnlSearch.Controls.Add(this.label8);
            this.pnlSearch.Controls.Add(this.textBox2);
            this.pnlSearch.Controls.Add(this.textBox3);
            this.pnlSearch.Controls.Add(this.textBox1);
            this.pnlSearch.Controls.Add(this.label5);
            this.pnlSearch.Controls.Add(this.label6);
            this.pnlSearch.Controls.Add(this.label7);
            this.pnlSearch.Controls.Add(this.maskedTextBox1);
            this.pnlSearch.Location = new System.Drawing.Point(208, 419);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(464, 170);
            this.pnlSearch.TabIndex = 28;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(326, 7);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 155);
            this.button1.TabIndex = 23;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(-3, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 18);
            this.label8.TabIndex = 22;
            this.label8.Text = "By Phone Number";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Cornsilk;
            this.textBox2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(120, 48);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(189, 26);
            this.textBox2.TabIndex = 12;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.Cornsilk;
            this.textBox3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.Location = new System.Drawing.Point(120, 8);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(189, 26);
            this.textBox3.TabIndex = 11;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Cornsilk;
            this.textBox1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(120, 93);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(189, 26);
            this.textBox1.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(51, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "By Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(33, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 18);
            this.label6.TabIndex = 17;
            this.label6.Text = "By Surname";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(54, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 18);
            this.label7.TabIndex = 16;
            this.label7.Text = "By Email";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.BackColor = System.Drawing.Color.Cornsilk;
            this.maskedTextBox1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBox1.Location = new System.Drawing.Point(120, 136);
            this.maskedTextBox1.Mask = "(+99900) 000-00-00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(189, 26);
            this.maskedTextBox1.TabIndex = 18;
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
            this.pnlUpdate.Location = new System.Drawing.Point(678, 418);
            this.pnlUpdate.Name = "pnlUpdate";
            this.pnlUpdate.Size = new System.Drawing.Size(572, 171);
            this.pnlUpdate.TabIndex = 27;
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
            this.btnCanXUpd.TabIndex = 21;
            this.btnCanXUpd.Text = "Cancel";
            this.btnCanXUpd.UseVisualStyleBackColor = false;
            this.btnCanXUpd.Click += new System.EventHandler(this.btnCanXUpd_Click);
            // 
            // txtBxNameUpd
            // 
            this.txtBxNameUpd.BackColor = System.Drawing.Color.Cornsilk;
            this.txtBxNameUpd.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBxNameUpd.Location = new System.Drawing.Point(109, 14);
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
            this.btnSaveUpd.Location = new System.Drawing.Point(339, 138);
            this.btnSaveUpd.Name = "btnSaveUpd";
            this.btnSaveUpd.Size = new System.Drawing.Size(94, 27);
            this.btnSaveUpd.TabIndex = 20;
            this.btnSaveUpd.Text = "Save";
            this.btnSaveUpd.UseVisualStyleBackColor = false;
            this.btnSaveUpd.Click += new System.EventHandler(this.btnSaveUpd_Click);
            // 
            // txtBxSurnameUpd
            // 
            this.txtBxSurnameUpd.BackColor = System.Drawing.Color.Cornsilk;
            this.txtBxSurnameUpd.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBxSurnameUpd.Location = new System.Drawing.Point(110, 54);
            this.txtBxSurnameUpd.Name = "txtBxSurnameUpd";
            this.txtBxSurnameUpd.Size = new System.Drawing.Size(189, 26);
            this.txtBxSurnameUpd.TabIndex = 12;
            // 
            // lbl5Upd
            // 
            this.lbl5Upd.AutoSize = true;
            this.lbl5Upd.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl5Upd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl5Upd.Location = new System.Drawing.Point(304, 14);
            this.lbl5Upd.Name = "lbl5Upd";
            this.lbl5Upd.Size = new System.Drawing.Size(58, 18);
            this.lbl5Upd.TabIndex = 14;
            this.lbl5Upd.Text = "Address";
            // 
            // txtBoxEmailUpd
            // 
            this.txtBoxEmailUpd.BackColor = System.Drawing.Color.Cornsilk;
            this.txtBoxEmailUpd.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBoxEmailUpd.Location = new System.Drawing.Point(110, 99);
            this.txtBoxEmailUpd.Name = "txtBoxEmailUpd";
            this.txtBoxEmailUpd.Size = new System.Drawing.Size(189, 26);
            this.txtBoxEmailUpd.TabIndex = 13;
            // 
            // lbl4Upd
            // 
            this.lbl4Upd.AutoSize = true;
            this.lbl4Upd.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl4Upd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl4Upd.Location = new System.Drawing.Point(2, 145);
            this.lbl4Upd.Name = "lbl4Upd";
            this.lbl4Upd.Size = new System.Drawing.Size(102, 18);
            this.lbl4Upd.TabIndex = 15;
            this.lbl4Upd.Text = "Phone Number";
            // 
            // maskdTxtBxPhoneUpd
            // 
            this.maskdTxtBxPhoneUpd.BackColor = System.Drawing.Color.Cornsilk;
            this.maskdTxtBxPhoneUpd.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskdTxtBxPhoneUpd.Location = new System.Drawing.Point(110, 139);
            this.maskdTxtBxPhoneUpd.Mask = "(+99900) 000-00-00";
            this.maskdTxtBxPhoneUpd.Name = "maskdTxtBxPhoneUpd";
            this.maskdTxtBxPhoneUpd.Size = new System.Drawing.Size(189, 26);
            this.maskdTxtBxPhoneUpd.TabIndex = 18;
            // 
            // lbl3Upd
            // 
            this.lbl3Upd.AutoSize = true;
            this.lbl3Upd.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl3Upd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl3Upd.Location = new System.Drawing.Point(62, 102);
            this.lbl3Upd.Name = "lbl3Upd";
            this.lbl3Upd.Size = new System.Drawing.Size(42, 18);
            this.lbl3Upd.TabIndex = 16;
            this.lbl3Upd.Text = "Email";
            // 
            // richTxtBxAddrUpd
            // 
            this.richTxtBxAddrUpd.BackColor = System.Drawing.Color.Cornsilk;
            this.richTxtBxAddrUpd.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTxtBxAddrUpd.Location = new System.Drawing.Point(368, 10);
            this.richTxtBxAddrUpd.Name = "richTxtBxAddrUpd";
            this.richTxtBxAddrUpd.Size = new System.Drawing.Size(189, 115);
            this.richTxtBxAddrUpd.TabIndex = 19;
            this.richTxtBxAddrUpd.Text = "";
            // 
            // lbl2Upd
            // 
            this.lbl2Upd.AutoSize = true;
            this.lbl2Upd.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl2Upd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl2Upd.Location = new System.Drawing.Point(41, 57);
            this.lbl2Upd.Name = "lbl2Upd";
            this.lbl2Upd.Size = new System.Drawing.Size(63, 18);
            this.lbl2Upd.TabIndex = 17;
            this.lbl2Upd.Text = "Surname";
            // 
            // lbl1Upd
            // 
            this.lbl1Upd.AutoSize = true;
            this.lbl1Upd.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl1Upd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl1Upd.Location = new System.Drawing.Point(59, 18);
            this.lbl1Upd.Name = "lbl1Upd";
            this.lbl1Upd.Size = new System.Drawing.Size(45, 18);
            this.lbl1Upd.TabIndex = 10;
            this.lbl1Upd.Text = "Name";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUpdate.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnUpdate.Location = new System.Drawing.Point(24, 537);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(162, 50);
            this.btnUpdate.TabIndex = 24;
            this.btnUpdate.Text = "Update Customer";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelete.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDelete.Location = new System.Drawing.Point(24, 479);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(162, 50);
            this.btnDelete.TabIndex = 25;
            this.btnDelete.Text = "Delete Customer";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAdd.Location = new System.Drawing.Point(24, 420);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(162, 50);
            this.btnAdd.TabIndex = 26;
            this.btnAdd.Text = "Add New Customer";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(451, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 25);
            this.label1.TabIndex = 29;
            this.label1.Text = "LIST OF ALL CUSTOMERS";
            // 
            // CustomerDataGridView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 600);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.pnlUpdate);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CustomerDataGridView";
            this.Text = "CustomerDataGridView";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CustomerDataGridView_FormClosed);
            this.Load += new System.EventHandler(this.CustomerDataGridView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.pnlUpdate.ResumeLayout(false);
            this.pnlUpdate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmContact;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
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
    }
}