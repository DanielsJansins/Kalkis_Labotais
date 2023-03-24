namespace WindowsFormsApp2
{
    partial class Form1
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
            this.budgetTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.couponTextBox = new System.Windows.Forms.TextBox();
            this.discountLabel = new System.Windows.Forms.Label();
            this.discountedLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // budgetTextBox
            // 
            this.budgetTextBox.Location = new System.Drawing.Point(82, 78);
            this.budgetTextBox.Name = "budgetTextBox";
            this.budgetTextBox.Size = new System.Drawing.Size(100, 20);
            this.budgetTextBox.TabIndex = 2;
            this.budgetTextBox.Text = "2";
            this.budgetTextBox.TextChanged += new System.EventHandler(this.budgetTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(207, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Atbilde:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(283, 143);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 1;
            this.calculateButton.Text = "Izrēķināt";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // couponTextBox
            // 
            this.couponTextBox.Location = new System.Drawing.Point(82, 237);
            this.couponTextBox.Name = "couponTextBox";
            this.couponTextBox.Size = new System.Drawing.Size(100, 20);
            this.couponTextBox.TabIndex = 4;
            this.couponTextBox.TextChanged += new System.EventHandler(this.Atlaides_TextChanged);
            // 
            // discountLabel
            // 
            this.discountLabel.AutoSize = true;
            this.discountLabel.Location = new System.Drawing.Point(64, 210);
            this.discountLabel.Name = "discountLabel";
            this.discountLabel.Size = new System.Drawing.Size(118, 13);
            this.discountLabel.TabIndex = 5;
            this.discountLabel.Text = "Ievadiet savu kuponu%";
            // 
            // discountedLabel
            // 
            this.discountedLabel.AutoSize = true;
            this.discountedLabel.Location = new System.Drawing.Point(79, 347);
            this.discountedLabel.Name = "discountedLabel";
            this.discountedLabel.Size = new System.Drawing.Size(254, 13);
            this.discountedLabel.TabIndex = 9;
            this.discountedLabel.Text = "Konfekšu daudzums ar atlaidi ko jūs varat iegādaties";
            this.discountedLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ievadiet cik daudz naudas jūs velaties paterēt";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 301);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(411, 105);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(309, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Šeit jūs varēsiet redzēt cik daudz konfekšu jūs varat iegātādties;";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.BackgroundImage = global::WindowsFormsApp2.Properties.Resources._2YWB_Healthy_Halloween_How_To_Enjoy_Your_Candy_Safely_800w;
            this.ClientSize = new System.Drawing.Size(908, 431);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.discountedLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.discountLabel);
            this.Controls.Add(this.couponTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.budgetTextBox);
            this.Controls.Add(this.calculateButton);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox budgetTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.TextBox couponTextBox;
        private System.Windows.Forms.Label discountLabel;
        private System.Windows.Forms.Label discountedLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
    }
}

