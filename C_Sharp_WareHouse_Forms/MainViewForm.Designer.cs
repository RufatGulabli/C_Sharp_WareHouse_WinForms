namespace C_Sharp_WareHouse_Forms
{
    partial class MainViewForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listOfCustomersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allOrdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBxNewPass = new System.Windows.Forms.TextBox();
            this.textBxOldPass = new System.Windows.Forms.TextBox();
            this.textBxNewUsernm = new System.Windows.Forms.TextBox();
            this.textBxOldUserNm = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmContact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl5Upd = new System.Windows.Forms.Label();
            this.lbl4Upd = new System.Windows.Forms.Label();
            this.lbl3Upd = new System.Windows.Forms.Label();
            this.lbl2Upd = new System.Windows.Forms.Label();
            this.lbl1Upd = new System.Windows.Forms.Label();
            this.richTxtBxAddrUpd = new System.Windows.Forms.RichTextBox();
            this.maskdTxtBxPhoneUpd = new System.Windows.Forms.MaskedTextBox();
            this.txtBoxEmailUpd = new System.Windows.Forms.TextBox();
            this.txtBxSurnameUpd = new System.Windows.Forms.TextBox();
            this.txtBxNameUpd = new System.Windows.Forms.TextBox();
            this.btnCanXUpd = new System.Windows.Forms.Button();
            this.btnSaveUpd = new System.Windows.Forms.Button();
            this.pnlUpdate = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gainsboro;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.productToolStripMenuItem,
            this.customerToolStripMenuItem,
            this.orderToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(966, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changePasswordToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.changePasswordToolStripMenuItem.Text = "Change Credentials";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(174, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewProductToolStripMenuItem,
            this.allProductsToolStripMenuItem});
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.productToolStripMenuItem.Text = "Product";
            // 
            // addNewProductToolStripMenuItem
            // 
            this.addNewProductToolStripMenuItem.Name = "addNewProductToolStripMenuItem";
            this.addNewProductToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.addNewProductToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.addNewProductToolStripMenuItem.Text = "Add New &Product";
            this.addNewProductToolStripMenuItem.Click += new System.EventHandler(this.addNewProductToolStripMenuItem_Click);
            // 
            // allProductsToolStripMenuItem
            // 
            this.allProductsToolStripMenuItem.Name = "allProductsToolStripMenuItem";
            this.allProductsToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.allProductsToolStripMenuItem.Text = "All Products";
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewCustomerToolStripMenuItem,
            this.listOfCustomersToolStripMenuItem});
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.customerToolStripMenuItem.Text = "Customer";
            // 
            // addNewCustomerToolStripMenuItem
            // 
            this.addNewCustomerToolStripMenuItem.Name = "addNewCustomerToolStripMenuItem";
            this.addNewCustomerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.addNewCustomerToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.addNewCustomerToolStripMenuItem.Text = "Add New &Customer";
            this.addNewCustomerToolStripMenuItem.Click += new System.EventHandler(this.addNewCustomerToolStripMenuItem_Click);
            // 
            // listOfCustomersToolStripMenuItem
            // 
            this.listOfCustomersToolStripMenuItem.Name = "listOfCustomersToolStripMenuItem";
            this.listOfCustomersToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.listOfCustomersToolStripMenuItem.Text = "All Customers";
            this.listOfCustomersToolStripMenuItem.Click += new System.EventHandler(this.listOfCustomersToolStripMenuItem_Click);
            // 
            // orderToolStripMenuItem
            // 
            this.orderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewOrderToolStripMenuItem,
            this.allOrdersToolStripMenuItem});
            this.orderToolStripMenuItem.Name = "orderToolStripMenuItem";
            this.orderToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.orderToolStripMenuItem.Text = "Order";
            // 
            // addNewOrderToolStripMenuItem
            // 
            this.addNewOrderToolStripMenuItem.Name = "addNewOrderToolStripMenuItem";
            this.addNewOrderToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.addNewOrderToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.addNewOrderToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.addNewOrderToolStripMenuItem.Text = "Add New &Order";
            this.addNewOrderToolStripMenuItem.Click += new System.EventHandler(this.addNewOrderToolStripMenuItem_Click);
            // 
            // allOrdersToolStripMenuItem
            // 
            this.allOrdersToolStripMenuItem.Name = "allOrdersToolStripMenuItem";
            this.allOrdersToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.allOrdersToolStripMenuItem.Text = "All Orders";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnConfirm);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBxNewPass);
            this.panel1.Controls.Add(this.textBxOldPass);
            this.panel1.Controls.Add(this.textBxNewUsernm);
            this.panel1.Controls.Add(this.textBxOldUserNm);
            this.panel1.Location = new System.Drawing.Point(613, 339);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(401, 247);
            this.panel1.TabIndex = 1;
            this.panel1.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancel.Location = new System.Drawing.Point(214, 190);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 26);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.Green;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConfirm.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnConfirm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConfirm.Location = new System.Drawing.Point(57, 190);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(94, 26);
            this.btnConfirm.TabIndex = 8;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(31, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "New Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(38, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Old Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(27, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "New Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(34, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Old Username";
            // 
            // textBxNewPass
            // 
            this.textBxNewPass.BackColor = System.Drawing.Color.Cornsilk;
            this.textBxNewPass.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBxNewPass.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBxNewPass.Location = new System.Drawing.Point(144, 137);
            this.textBxNewPass.Name = "textBxNewPass";
            this.textBxNewPass.PasswordChar = '*';
            this.textBxNewPass.Size = new System.Drawing.Size(185, 26);
            this.textBxNewPass.TabIndex = 7;
            // 
            // textBxOldPass
            // 
            this.textBxOldPass.BackColor = System.Drawing.Color.Cornsilk;
            this.textBxOldPass.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBxOldPass.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBxOldPass.Location = new System.Drawing.Point(144, 101);
            this.textBxOldPass.Name = "textBxOldPass";
            this.textBxOldPass.PasswordChar = '*';
            this.textBxOldPass.Size = new System.Drawing.Size(185, 26);
            this.textBxOldPass.TabIndex = 5;
            // 
            // textBxNewUsernm
            // 
            this.textBxNewUsernm.BackColor = System.Drawing.Color.Cornsilk;
            this.textBxNewUsernm.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBxNewUsernm.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBxNewUsernm.Location = new System.Drawing.Point(144, 66);
            this.textBxNewUsernm.Name = "textBxNewUsernm";
            this.textBxNewUsernm.Size = new System.Drawing.Size(185, 26);
            this.textBxNewUsernm.TabIndex = 3;
            // 
            // textBxOldUserNm
            // 
            this.textBxOldUserNm.BackColor = System.Drawing.Color.Cornsilk;
            this.textBxOldUserNm.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBxOldUserNm.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBxOldUserNm.Location = new System.Drawing.Point(144, 27);
            this.textBxOldUserNm.Name = "textBxOldUserNm";
            this.textBxOldUserNm.Size = new System.Drawing.Size(185, 26);
            this.textBxOldUserNm.TabIndex = 1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 562);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(966, 24);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.toolStripStatusLabel1.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.toolStripStatusLabel1.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(122, 19);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DarkGreen;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAdd.Location = new System.Drawing.Point(0, 346);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(162, 31);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add New Customer";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Visible = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DarkGreen;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDelete.Location = new System.Drawing.Point(212, 346);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(162, 31);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete Customer";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DarkGreen;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUpdate.Location = new System.Drawing.Point(422, 346);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(162, 31);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update Customer";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
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
            this.dataGridView1.Location = new System.Drawing.Point(0, 28);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(966, 296);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.Visible = false;
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
            // lbl5Upd
            // 
            this.lbl5Upd.AutoSize = true;
            this.lbl5Upd.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl5Upd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl5Upd.Location = new System.Drawing.Point(304, 7);
            this.lbl5Upd.Name = "lbl5Upd";
            this.lbl5Upd.Size = new System.Drawing.Size(58, 18);
            this.lbl5Upd.TabIndex = 14;
            this.lbl5Upd.Text = "Address";
            // 
            // lbl4Upd
            // 
            this.lbl4Upd.AutoSize = true;
            this.lbl4Upd.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl4Upd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl4Upd.Location = new System.Drawing.Point(2, 121);
            this.lbl4Upd.Name = "lbl4Upd";
            this.lbl4Upd.Size = new System.Drawing.Size(102, 18);
            this.lbl4Upd.TabIndex = 15;
            this.lbl4Upd.Text = "Phone Number";
            // 
            // lbl3Upd
            // 
            this.lbl3Upd.AutoSize = true;
            this.lbl3Upd.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl3Upd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl3Upd.Location = new System.Drawing.Point(62, 87);
            this.lbl3Upd.Name = "lbl3Upd";
            this.lbl3Upd.Size = new System.Drawing.Size(42, 18);
            this.lbl3Upd.TabIndex = 16;
            this.lbl3Upd.Text = "Email";
            // 
            // lbl2Upd
            // 
            this.lbl2Upd.AutoSize = true;
            this.lbl2Upd.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl2Upd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl2Upd.Location = new System.Drawing.Point(41, 48);
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
            this.lbl1Upd.Location = new System.Drawing.Point(59, 12);
            this.lbl1Upd.Name = "lbl1Upd";
            this.lbl1Upd.Size = new System.Drawing.Size(45, 18);
            this.lbl1Upd.TabIndex = 10;
            this.lbl1Upd.Text = "Name";
            // 
            // richTxtBxAddrUpd
            // 
            this.richTxtBxAddrUpd.BackColor = System.Drawing.Color.Cornsilk;
            this.richTxtBxAddrUpd.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTxtBxAddrUpd.Location = new System.Drawing.Point(368, 4);
            this.richTxtBxAddrUpd.Name = "richTxtBxAddrUpd";
            this.richTxtBxAddrUpd.Size = new System.Drawing.Size(189, 96);
            this.richTxtBxAddrUpd.TabIndex = 19;
            this.richTxtBxAddrUpd.Text = "";
            // 
            // maskdTxtBxPhoneUpd
            // 
            this.maskdTxtBxPhoneUpd.BackColor = System.Drawing.Color.Cornsilk;
            this.maskdTxtBxPhoneUpd.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskdTxtBxPhoneUpd.Location = new System.Drawing.Point(110, 118);
            this.maskdTxtBxPhoneUpd.Mask = "(+99900) 000-00-00";
            this.maskdTxtBxPhoneUpd.Name = "maskdTxtBxPhoneUpd";
            this.maskdTxtBxPhoneUpd.Size = new System.Drawing.Size(189, 26);
            this.maskdTxtBxPhoneUpd.TabIndex = 18;
            // 
            // txtBoxEmailUpd
            // 
            this.txtBoxEmailUpd.BackColor = System.Drawing.Color.Cornsilk;
            this.txtBoxEmailUpd.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBoxEmailUpd.Location = new System.Drawing.Point(110, 84);
            this.txtBoxEmailUpd.Name = "txtBoxEmailUpd";
            this.txtBoxEmailUpd.Size = new System.Drawing.Size(189, 26);
            this.txtBoxEmailUpd.TabIndex = 13;
            // 
            // txtBxSurnameUpd
            // 
            this.txtBxSurnameUpd.BackColor = System.Drawing.Color.Cornsilk;
            this.txtBxSurnameUpd.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBxSurnameUpd.Location = new System.Drawing.Point(110, 45);
            this.txtBxSurnameUpd.Name = "txtBxSurnameUpd";
            this.txtBxSurnameUpd.Size = new System.Drawing.Size(189, 26);
            this.txtBxSurnameUpd.TabIndex = 12;
            // 
            // txtBxNameUpd
            // 
            this.txtBxNameUpd.BackColor = System.Drawing.Color.Cornsilk;
            this.txtBxNameUpd.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBxNameUpd.Location = new System.Drawing.Point(110, 4);
            this.txtBxNameUpd.Name = "txtBxNameUpd";
            this.txtBxNameUpd.Size = new System.Drawing.Size(189, 26);
            this.txtBxNameUpd.TabIndex = 11;
            // 
            // btnCanXUpd
            // 
            this.btnCanXUpd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCanXUpd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCanXUpd.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCanXUpd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCanXUpd.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCanXUpd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCanXUpd.Location = new System.Drawing.Point(463, 118);
            this.btnCanXUpd.Name = "btnCanXUpd";
            this.btnCanXUpd.Size = new System.Drawing.Size(94, 26);
            this.btnCanXUpd.TabIndex = 21;
            this.btnCanXUpd.Text = "Cancel";
            this.btnCanXUpd.UseVisualStyleBackColor = false;
            this.btnCanXUpd.Click += new System.EventHandler(this.btnCanXUpd_Click);
            // 
            // btnSaveUpd
            // 
            this.btnSaveUpd.BackColor = System.Drawing.Color.Green;
            this.btnSaveUpd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveUpd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSaveUpd.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSaveUpd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSaveUpd.Location = new System.Drawing.Point(342, 118);
            this.btnSaveUpd.Name = "btnSaveUpd";
            this.btnSaveUpd.Size = new System.Drawing.Size(94, 27);
            this.btnSaveUpd.TabIndex = 20;
            this.btnSaveUpd.Text = "Save";
            this.btnSaveUpd.UseVisualStyleBackColor = false;
            this.btnSaveUpd.Click += new System.EventHandler(this.btnSaveUpd_Click);
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
            this.pnlUpdate.Location = new System.Drawing.Point(12, 394);
            this.pnlUpdate.Name = "pnlUpdate";
            this.pnlUpdate.Size = new System.Drawing.Size(572, 165);
            this.pnlUpdate.TabIndex = 22;
            this.pnlUpdate.Visible = false;
            // 
            // MainViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(966, 586);
            this.Controls.Add(this.pnlUpdate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainViewForm";
            this.Text = "MainViewForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainViewForm_FormClosed1);
            this.Load += new System.EventHandler(this.MainViewForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnlUpdate.ResumeLayout(false);
            this.pnlUpdate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allProductsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listOfCustomersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allOrdersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBxNewPass;
        private System.Windows.Forms.TextBox textBxOldPass;
        private System.Windows.Forms.TextBox textBxNewUsernm;
        private System.Windows.Forms.TextBox textBxOldUserNm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmContact;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Label lbl5Upd;
        private System.Windows.Forms.Label lbl4Upd;
        private System.Windows.Forms.Label lbl3Upd;
        private System.Windows.Forms.Label lbl2Upd;
        private System.Windows.Forms.Label lbl1Upd;
        private System.Windows.Forms.RichTextBox richTxtBxAddrUpd;
        private System.Windows.Forms.MaskedTextBox maskdTxtBxPhoneUpd;
        private System.Windows.Forms.TextBox txtBoxEmailUpd;
        private System.Windows.Forms.TextBox txtBxSurnameUpd;
        private System.Windows.Forms.TextBox txtBxNameUpd;
        private System.Windows.Forms.Button btnCanXUpd;
        private System.Windows.Forms.Button btnSaveUpd;
        private System.Windows.Forms.Panel pnlUpdate;
    }
}