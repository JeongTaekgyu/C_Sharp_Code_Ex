namespace WindowsFormsApp_Test1
{
    partial class FormB
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
            this.txtB_Name = new System.Windows.Forms.TextBox();
            this.txtB_Corp = new System.Windows.Forms.TextBox();
            this.btnB_send = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "B이름";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "B회사";
            // 
            // txtB_Name
            // 
            this.txtB_Name.Location = new System.Drawing.Point(76, 166);
            this.txtB_Name.Name = "txtB_Name";
            this.txtB_Name.Size = new System.Drawing.Size(100, 21);
            this.txtB_Name.TabIndex = 2;
            // 
            // txtB_Corp
            // 
            this.txtB_Corp.Location = new System.Drawing.Point(76, 203);
            this.txtB_Corp.Name = "txtB_Corp";
            this.txtB_Corp.Size = new System.Drawing.Size(100, 21);
            this.txtB_Corp.TabIndex = 2;
            // 
            // btnB_send
            // 
            this.btnB_send.Location = new System.Drawing.Point(101, 244);
            this.btnB_send.Name = "btnB_send";
            this.btnB_send.Size = new System.Drawing.Size(75, 23);
            this.btnB_send.TabIndex = 3;
            this.btnB_send.Text = "보내기";
            this.btnB_send.UseVisualStyleBackColor = true;
            this.btnB_send.Click += new System.EventHandler(this.btnB_send_Click);
            // 
            // FormB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 362);
            this.Controls.Add(this.btnB_send);
            this.Controls.Add(this.txtB_Corp);
            this.Controls.Add(this.txtB_Name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormB";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.FormB_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtB_Name;
        private System.Windows.Forms.TextBox txtB_Corp;
        private System.Windows.Forms.Button btnB_send;
    }
}