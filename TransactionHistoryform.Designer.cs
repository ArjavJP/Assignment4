namespace Assignment4
{
    partial class TransactionHistoryform
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
            dgv_history = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_history).BeginInit();
            SuspendLayout();
            // 
            // dgv_history
            // 
            dgv_history.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_history.Location = new Point(45, 80);
            dgv_history.Name = "dgv_history";
            dgv_history.RowHeadersWidth = 62;
            dgv_history.Size = new Size(1048, 495);
            dgv_history.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(1128, 80);
            button1.Name = "button1";
            button1.Size = new Size(112, 43);
            button1.TabIndex = 1;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(1128, 159);
            button2.Name = "button2";
            button2.Size = new Size(112, 41);
            button2.TabIndex = 2;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(1128, 247);
            button3.Name = "button3";
            button3.Size = new Size(112, 41);
            button3.TabIndex = 3;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // TransactionHistoryform
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1423, 651);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dgv_history);
            Name = "TransactionHistoryform";
            Text = "TransactionHistory";
            Load += TransactionHistory_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_history).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv_history;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}