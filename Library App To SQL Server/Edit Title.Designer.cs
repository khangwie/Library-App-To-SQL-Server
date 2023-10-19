namespace Library_App_To_SQL_Server
{
    partial class Edit_Title
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtTitleName = new System.Windows.Forms.TextBox();
            this.txtNewTitleName = new System.Windows.Forms.TextBox();
            this.txtNewTitleType = new System.Windows.Forms.TextBox();
            this.txtNewTitlePrice = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Title Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(431, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "New Title Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(435, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "New Title Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(431, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "New Title Price";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(272, 365);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 56);
            this.button1.TabIndex = 5;
            this.button1.Text = "Edit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(152, 107);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(195, 26);
            this.txtID.TabIndex = 6;
            // 
            // txtTitleName
            // 
            this.txtTitleName.Location = new System.Drawing.Point(155, 159);
            this.txtTitleName.Name = "txtTitleName";
            this.txtTitleName.Size = new System.Drawing.Size(192, 26);
            this.txtTitleName.TabIndex = 7;
            // 
            // txtNewTitleName
            // 
            this.txtNewTitleName.Location = new System.Drawing.Point(566, 101);
            this.txtNewTitleName.Name = "txtNewTitleName";
            this.txtNewTitleName.Size = new System.Drawing.Size(181, 26);
            this.txtNewTitleName.TabIndex = 8;
            // 
            // txtNewTitleType
            // 
            this.txtNewTitleType.Location = new System.Drawing.Point(566, 156);
            this.txtNewTitleType.Name = "txtNewTitleType";
            this.txtNewTitleType.Size = new System.Drawing.Size(205, 26);
            this.txtNewTitleType.TabIndex = 9;
            // 
            // txtNewTitlePrice
            // 
            this.txtNewTitlePrice.Location = new System.Drawing.Point(566, 221);
            this.txtNewTitlePrice.Name = "txtNewTitlePrice";
            this.txtNewTitlePrice.Size = new System.Drawing.Size(251, 26);
            this.txtNewTitlePrice.TabIndex = 10;
            // 
            // Edit_Title
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNewTitlePrice);
            this.Controls.Add(this.txtNewTitleType);
            this.Controls.Add(this.txtNewTitleName);
            this.Controls.Add(this.txtTitleName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Edit_Title";
            this.Text = "Edit_Title";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtTitleName;
        private System.Windows.Forms.TextBox txtNewTitleName;
        private System.Windows.Forms.TextBox txtNewTitleType;
        private System.Windows.Forms.TextBox txtNewTitlePrice;
    }
}