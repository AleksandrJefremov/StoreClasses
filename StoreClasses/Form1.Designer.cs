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
            btnUpdateItem = new Button();
            btnDelete = new Button();
            txtBoxPerished = new TextBox();
            btnperish = new Button();
            button1 = new Button();
            btnCreateFresh = new Button();
            txtFreshProduce = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // btnCreateItem1
            // 
            btnCreateItem1.Location = new Point(601, 12);
            btnCreateItem1.Name = "btnCreateItem1";
            btnCreateItem1.Size = new Size(185, 23);
            btnCreateItem1.TabIndex = 0;
            btnCreateItem1.Text = "Create Demo Item";
            btnCreateItem1.UseVisualStyleBackColor = true;
            btnCreateItem1.Click += btnCreateItem1_Click;
            // 
            // txtItemId
            // 
            txtItemId.Location = new Point(184, 38);
            txtItemId.Name = "txtItemId";
            txtItemId.Size = new Size(100, 23);
            txtItemId.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.Location = new Point(184, 67);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 2;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(184, 96);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(100, 23);
            txtPrice.TabIndex = 3;
            // 
            // listBox
            // 
            listBox.FormattingEnabled = true;
            listBox.ItemHeight = 15;
            listBox.Location = new Point(184, 189);
            listBox.Name = "listBox";
            listBox.Size = new Size(344, 244);
            listBox.TabIndex = 4;
            listBox.SelectedIndexChanged += listBox_SelectedIndexChanged;
            // 
            // btnUpdateItem
            // 
            btnUpdateItem.Location = new Point(601, 386);
            btnUpdateItem.Name = "btnUpdateItem";
            btnUpdateItem.Size = new Size(185, 23);
            btnUpdateItem.TabIndex = 6;
            btnUpdateItem.Text = "Update item";
            btnUpdateItem.UseVisualStyleBackColor = true;
            btnUpdateItem.Click += btnUpdateItem_Click_1;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(601, 415);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(185, 23);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete Item";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtBoxPerished
            // 
            txtBoxPerished.Location = new Point(184, 125);
            txtBoxPerished.Name = "txtBoxPerished";
            txtBoxPerished.Size = new Size(100, 23);
            txtBoxPerished.TabIndex = 8;
            // 
            // btnperish
            // 
            btnperish.Location = new Point(601, 152);
            btnperish.Name = "btnperish";
            btnperish.Size = new Size(185, 23);
            btnperish.TabIndex = 9;
            btnperish.Text = "Perish";
            btnperish.UseVisualStyleBackColor = true;
            btnperish.Click += btnperish_Click;
            // 
            // button1
            // 
            button1.Location = new Point(601, 123);
            button1.Name = "button1";
            button1.Size = new Size(185, 23);
            button1.TabIndex = 10;
            button1.Text = "Create Demo Perishable item";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnCreateFresh
            // 
            btnCreateFresh.Location = new Point(601, 260);
            btnCreateFresh.Name = "btnCreateFresh";
            btnCreateFresh.Size = new Size(185, 23);
            btnCreateFresh.TabIndex = 11;
            btnCreateFresh.Text = "Create Farm Item";
            btnCreateFresh.UseVisualStyleBackColor = true;
            btnCreateFresh.Click += btnCreateFresh_Click;
            // 
            // txtFreshProduce
            // 
            txtFreshProduce.Location = new Point(184, 154);
            txtFreshProduce.Name = "txtFreshProduce";
            txtFreshProduce.Size = new Size(100, 23);
            txtFreshProduce.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(115, 41);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 13;
            label1.Text = "Serial nr.";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(115, 67);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 14;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(115, 125);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 16;
            label3.Text = "Perished";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(115, 96);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 15;
            label4.Text = "Price";
            //label4.Click += this.label4_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(115, 154);
            label6.Name = "label6";
            label6.Size = new Size(68, 15);
            label6.TabIndex = 17;
            label6.Text = "Farm origin";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(798, 450);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtFreshProduce);
            Controls.Add(btnCreateFresh);
            Controls.Add(button1);
            Controls.Add(btnperish);
            Controls.Add(txtBoxPerished);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdateItem);
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
        private Button btnUpdateItem;
        private Button btnDelete;
        private TextBox txtBoxPerished;
        private Button btnperish;
        private Button button1;
        private Button btnCreateFresh;
        private TextBox txtFreshProduce;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
    }
}
