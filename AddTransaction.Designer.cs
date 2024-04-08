namespace Assignment4
{
    partial class AddTransaction
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
            txtaccid = new TextBox();
            txtamount = new TextBox();
            txtdescp = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btn_add = new Button();
            btn_clear = new Button();
            SuspendLayout();
            // 
            // txtaccid
            // 
            txtaccid.Location = new Point(378, 101);
            txtaccid.Name = "txtaccid";
            txtaccid.Size = new Size(191, 31);
            txtaccid.TabIndex = 0;
            // 
            // txtamount
            // 
            txtamount.Location = new Point(378, 153);
            txtamount.Name = "txtamount";
            txtamount.Size = new Size(191, 31);
            txtamount.TabIndex = 1;
            // 
            // txtdescp
            // 
            txtdescp.Location = new Point(378, 213);
            txtdescp.Name = "txtdescp";
            txtdescp.Size = new Size(191, 31);
            txtdescp.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(272, 104);
            label1.Name = "label1";
            label1.Size = new Size(100, 25);
            label1.TabIndex = 3;
            label1.Text = "Account ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(295, 156);
            label2.Name = "label2";
            label2.Size = new Size(77, 25);
            label2.TabIndex = 4;
            label2.Text = "Amount";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(270, 219);
            label3.Name = "label3";
            label3.Size = new Size(102, 25);
            label3.TabIndex = 5;
            label3.Text = "Description";
            // 
            // btn_add
            // 
            btn_add.Location = new Point(285, 307);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(112, 44);
            btn_add.TabIndex = 6;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += button1_Click;
            // 
            // btn_clear
            // 
            btn_clear.Location = new Point(457, 307);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(112, 44);
            btn_clear.TabIndex = 7;
            btn_clear.Text = "Clear";
            btn_clear.UseVisualStyleBackColor = true;
            // 
            // AddTransaction
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(940, 632);
            Controls.Add(btn_clear);
            Controls.Add(btn_add);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtdescp);
            Controls.Add(txtamount);
            Controls.Add(txtaccid);
            Name = "AddTransaction";
            Text = "Transactionhistory";
           // Load += this.AddTransaction_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtaccid;
        private TextBox txtamount;
        private TextBox txtdescp;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btn_add;
        private Button btn_clear;
    }
}