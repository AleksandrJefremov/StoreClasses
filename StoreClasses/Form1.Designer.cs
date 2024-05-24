namespace StoreClasses
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCreateItem1 = new Button();
            txtItemId = new TextBox();
            txtName = new TextBox();
            txtPrice = new TextBox();
            listBox = new ListBox();
            SuspendLayout();
            // 
            // btnCreateItem1
            // 
            btnCreateItem1.Location = new Point(629, 23);
            btnCreateItem1.Name = "btnCreateItem1";
            btnCreateItem1.Size = new Size(147, 23);
            btnCreateItem1.TabIndex = 0;
            btnCreateItem1.Text = "Create Random Item";
            btnCreateItem1.UseVisualStyleBackColor = true;
            btnCreateItem1.Click += btnCreateItem1_Click;
            // 
            // txtItemId
            // 
            txtItemId.Location = new Point(59, 38);
            txtItemId.Name = "txtItemId";
            txtItemId.Size = new Size(100, 23);
            txtItemId.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.Location = new Point(59, 67);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 2;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(59, 96);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(100, 23);
            txtPrice.TabIndex = 3;
            // 
            // listBox
            // 
            listBox.FormattingEnabled = true;
            listBox.ItemHeight = 15;
            listBox.Location = new Point(59, 175);
            listBox.Name = "listBox";
            listBox.Size = new Size(344, 94);
            listBox.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(798, 450);
            Controls.Add(listBox);
            Controls.Add(txtPrice);
            Controls.Add(txtName);
            Controls.Add(txtItemId);
            Controls.Add(btnCreateItem1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCreateItem;
        private Button btnCreateItem1;
        private TextBox txtItemId;
        private TextBox txtName;
        private TextBox txtPrice;
        private ListBox listBox;
    }
}
