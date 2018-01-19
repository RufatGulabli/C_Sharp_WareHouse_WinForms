namespace C_Sharp_WareHouse_Forms
{
    partial class ProductAdding
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBxPrdNm = new System.Windows.Forms.TextBox();
            this.numricUpDownQuan = new System.Windows.Forms.NumericUpDown();
            this.richTextBoxDesc = new System.Windows.Forms.RichTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCanx = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.numrcUpDwnPrice = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numricUpDownQuan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numrcUpDwnPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(30, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(47, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Quantity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(18, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Product Price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Product Name";
            // 
            // textBxPrdNm
            // 
            this.textBxPrdNm.BackColor = System.Drawing.Color.Cornsilk;
            this.textBxPrdNm.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBxPrdNm.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBxPrdNm.Location = new System.Drawing.Point(113, 20);
            this.textBxPrdNm.Name = "textBxPrdNm";
            this.textBxPrdNm.Size = new System.Drawing.Size(258, 26);
            this.textBxPrdNm.TabIndex = 0;
            // 
            // numricUpDownQuan
            // 
            this.numricUpDownQuan.BackColor = System.Drawing.Color.Cornsilk;
            this.numricUpDownQuan.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numricUpDownQuan.Location = new System.Drawing.Point(113, 98);
            this.numricUpDownQuan.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numricUpDownQuan.Name = "numricUpDownQuan";
            this.numricUpDownQuan.Size = new System.Drawing.Size(258, 26);
            this.numricUpDownQuan.TabIndex = 2;
            // 
            // richTextBoxDesc
            // 
            this.richTextBoxDesc.BackColor = System.Drawing.Color.Cornsilk;
            this.richTextBoxDesc.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxDesc.Location = new System.Drawing.Point(113, 152);
            this.richTextBoxDesc.Name = "richTextBoxDesc";
            this.richTextBoxDesc.Size = new System.Drawing.Size(258, 136);
            this.richTextBoxDesc.TabIndex = 3;
            this.richTextBoxDesc.Text = "";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Green;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSave.Location = new System.Drawing.Point(50, 323);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(111, 31);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCanx
            // 
            this.btnCanx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCanx.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCanx.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCanx.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCanx.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCanx.Location = new System.Drawing.Point(232, 323);
            this.btnCanx.Name = "btnCanx";
            this.btnCanx.Size = new System.Drawing.Size(111, 31);
            this.btnCanx.TabIndex = 5;
            this.btnCanx.Text = "Cancel";
            this.btnCanx.UseVisualStyleBackColor = false;
            this.btnCanx.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(337, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "AZN";
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
            this.numrcUpDwnPrice.Location = new System.Drawing.Point(114, 61);
            this.numrcUpDwnPrice.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numrcUpDwnPrice.Name = "numrcUpDwnPrice";
            this.numrcUpDwnPrice.Size = new System.Drawing.Size(214, 26);
            this.numrcUpDwnPrice.TabIndex = 1;
            // 
            // ProductAdding
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.CancelButton = this.btnCanx;
            this.ClientSize = new System.Drawing.Size(379, 368);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCanx);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.numrcUpDwnPrice);
            this.Controls.Add(this.richTextBoxDesc);
            this.Controls.Add(this.numricUpDownQuan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBxPrdNm);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(395, 407);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(395, 407);
            this.Name = "ProductAdding";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Add New Product";
            ((System.ComponentModel.ISupportInitialize)(this.numricUpDownQuan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numrcUpDwnPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBxPrdNm;
        private System.Windows.Forms.NumericUpDown numricUpDownQuan;
        private System.Windows.Forms.RichTextBox richTextBoxDesc;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCanx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numrcUpDwnPrice;
    }
}