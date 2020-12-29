namespace WindowsFormsApp_Test1
{
    partial class FormA
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtA_Name = new System.Windows.Forms.TextBox();
            this.txtA_Corp = new System.Windows.Forms.TextBox();
            this.txtA_returnName = new System.Windows.Forms.TextBox();
            this.txtA_returnCorp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnA_send = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "이름";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "회사";
            // 
            // txtA_Name
            // 
            this.txtA_Name.Location = new System.Drawing.Point(97, 40);
            this.txtA_Name.Name = "txtA_Name";
            this.txtA_Name.Size = new System.Drawing.Size(100, 21);
            this.txtA_Name.TabIndex = 2;
            // 
            // txtA_Corp
            // 
            this.txtA_Corp.Location = new System.Drawing.Point(97, 82);
            this.txtA_Corp.Name = "txtA_Corp";
            this.txtA_Corp.Size = new System.Drawing.Size(100, 21);
            this.txtA_Corp.TabIndex = 2;
            // 
            // txtA_returnName
            // 
            this.txtA_returnName.Location = new System.Drawing.Point(97, 139);
            this.txtA_returnName.Name = "txtA_returnName";
            this.txtA_returnName.Size = new System.Drawing.Size(100, 21);
            this.txtA_returnName.TabIndex = 2;
            // 
            // txtA_returnCorp
            // 
            this.txtA_returnCorp.Location = new System.Drawing.Point(97, 184);
            this.txtA_returnCorp.Name = "txtA_returnCorp";
            this.txtA_returnCorp.Size = new System.Drawing.Size(100, 21);
            this.txtA_returnCorp.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "이름2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "회사2";
            // 
            // btnA_send
            // 
            this.btnA_send.Location = new System.Drawing.Point(229, 82);
            this.btnA_send.Name = "btnA_send";
            this.btnA_send.Size = new System.Drawing.Size(75, 23);
            this.btnA_send.TabIndex = 3;
            this.btnA_send.Text = "보내기";
            this.btnA_send.UseVisualStyleBackColor = true;
            this.btnA_send.Click += new System.EventHandler(this.btnA_send_Click);
            // 
            // FormA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 249);
            this.Controls.Add(this.btnA_send);
            this.Controls.Add(this.txtA_returnCorp);
            this.Controls.Add(this.txtA_returnName);
            this.Controls.Add(this.txtA_Corp);
            this.Controls.Add(this.txtA_Name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtA_Name;
        private System.Windows.Forms.TextBox txtA_Corp;
        private System.Windows.Forms.TextBox txtA_returnName;
        private System.Windows.Forms.TextBox txtA_returnCorp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnA_send;
    }
}

