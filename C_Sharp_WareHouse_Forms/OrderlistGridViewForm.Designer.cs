namespace C_Sharp_WareHouse_Forms
{
    partial class OrderlistGridViewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderlistGridViewForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtBxSurnameSearch = new System.Windows.Forms.TextBox();
            this.txtBxEmailSearch = new System.Windows.Forms.TextBox();
            this.txtboxNameSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.msktxtBxSearch = new System.Windows.Forms.MaskedTextBox();
            this.btnDeleteOrder = new System.Windows.Forms.Button();
            this.btnMakeNewOrder = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBxSurnameSearch
            // 
            this.txtBxSurnameSearch.BackColor = System.Drawing.Color.White;
            this.txtBxSurnameSearch.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBxSurnameSearch.ForeColor = System.Drawing.Color.Silver;
            this.txtBxSurnameSearch.Location = new System.Drawing.Point(164, 157);
            this.txtBxSurnameSearch.Name = "txtBxSurnameSearch";
            this.txtBxSurnameSearch.Size = new System.Drawing.Size(147, 26);
            this.txtBxSurnameSearch.TabIndex = 34;
            this.txtBxSurnameSearch.Text = "Search by Surname";
            // 
            // txtBxEmailSearch
            // 
            this.txtBxEmailSearch.BackColor = System.Drawing.Color.White;
            this.txtBxEmailSearch.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBxEmailSearch.ForeColor = System.Drawing.Color.Silver;
            this.txtBxEmailSearch.Location = new System.Drawing.Point(317, 157);
            this.txtBxEmailSearch.Name = "txtBxEmailSearch";
            this.txtBxEmailSearch.Size = new System.Drawing.Size(147, 26);
            this.txtBxEmailSearch.TabIndex = 35;
            this.txtBxEmailSearch.Text = "Search by Email";
            // 
            // txtboxNameSearch
            // 
            this.txtboxNameSearch.BackColor = System.Drawing.Color.White;
            this.txtboxNameSearch.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtboxNameSearch.ForeColor = System.Drawing.Color.Silver;
            this.txtboxNameSearch.Location = new System.Drawing.Point(12, 157);
            this.txtboxNameSearch.Name = "txtboxNameSearch";
            this.txtboxNameSearch.Size = new System.Drawing.Size(147, 26);
            this.txtboxNameSearch.TabIndex = 33;
            this.txtboxNameSearch.Text = "Search by Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(349, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 25);
            this.label1.TabIndex = 39;
            this.label1.Text = "LIST OF ALL ORDERS";
            // 
            // msktxtBxSearch
            // 
            this.msktxtBxSearch.BackColor = System.Drawing.Color.White;
            this.msktxtBxSearch.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.msktxtBxSearch.ForeColor = System.Drawing.Color.Silver;
            this.msktxtBxSearch.Location = new System.Drawing.Point(476, 157);
            this.msktxtBxSearch.Mask = "(+99900) 000-00-00";
            this.msktxtBxSearch.Name = "msktxtBxSearch";
            this.msktxtBxSearch.Size = new System.Drawing.Size(147, 26);
            this.msktxtBxSearch.TabIndex = 36;
            // 
            // btnDeleteOrder
            // 
            this.btnDeleteOrder.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnDeleteOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDeleteOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteOrder.FlatAppearance.BorderSize = 0;
            this.btnDeleteOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteOrder.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteOrder.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDeleteOrder.Location = new System.Drawing.Point(90, 83);
            this.btnDeleteOrder.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteOrder.Name = "btnDeleteOrder";
            this.btnDeleteOrder.Size = new System.Drawing.Size(69, 67);
            this.btnDeleteOrder.TabIndex = 31;
            this.btnDeleteOrder.Text = "Delete Customer";
            this.btnDeleteOrder.UseVisualStyleBackColor = false;
            this.btnDeleteOrder.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnMakeNewOrder
            // 
            this.btnMakeNewOrder.BackColor = System.Drawing.Color.Transparent;
            this.btnMakeNewOrder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMakeNewOrder.BackgroundImage")));
            this.btnMakeNewOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMakeNewOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMakeNewOrder.FlatAppearance.BorderSize = 0;
            this.btnMakeNewOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMakeNewOrder.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMakeNewOrder.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnMakeNewOrder.Location = new System.Drawing.Point(13, 83);
            this.btnMakeNewOrder.Margin = new System.Windows.Forms.Padding(4);
            this.btnMakeNewOrder.Name = "btnMakeNewOrder";
            this.btnMakeNewOrder.Size = new System.Drawing.Size(69, 67);
            this.btnMakeNewOrder.TabIndex = 30;
            this.btnMakeNewOrder.UseVisualStyleBackColor = false;
            this.btnMakeNewOrder.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.Location = new System.Drawing.Point(12, 189);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(970, 327);
            this.dataGridView1.TabIndex = 38;
            // 
            // OrderlistGridViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(994, 528);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBxSurnameSearch);
            this.Controls.Add(this.txtBxEmailSearch);
            this.Controls.Add(this.txtboxNameSearch);
            this.Controls.Add(this.msktxtBxSearch);
            this.Controls.Add(this.btnDeleteOrder);
            this.Controls.Add(this.btnMakeNewOrder);
            this.Controls.Add(this.dataGridView1);
            this.Name = "OrderlistGridViewForm";
            this.Text = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OrderlistGridViewForm_FormClosed);
            this.Load += new System.EventHandler(this.OrderlistGridViewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBxSurnameSearch;
        private System.Windows.Forms.TextBox txtBxEmailSearch;
        private System.Windows.Forms.TextBox txtboxNameSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox msktxtBxSearch;
        private System.Windows.Forms.Button btnDeleteOrder;
        private System.Windows.Forms.Button btnMakeNewOrder;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}