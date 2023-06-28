
namespace zavod
{
    partial class loginform
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
            this.logintextbox = new System.Windows.Forms.TextBox();
            this.passtextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.enterbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // logintextbox
            // 
            this.logintextbox.Location = new System.Drawing.Point(200, 95);
            this.logintextbox.Name = "logintextbox";
            this.logintextbox.Size = new System.Drawing.Size(100, 20);
            this.logintextbox.TabIndex = 0;
            // 
            // passtextbox
            // 
            this.passtextbox.Location = new System.Drawing.Point(200, 182);
            this.passtextbox.Name = "passtextbox";
            this.passtextbox.Size = new System.Drawing.Size(100, 20);
            this.passtextbox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "пароль";
            // 
            // enterbutton
            // 
            this.enterbutton.Location = new System.Drawing.Point(182, 291);
            this.enterbutton.Name = "enterbutton";
            this.enterbutton.Size = new System.Drawing.Size(75, 23);
            this.enterbutton.TabIndex = 4;
            this.enterbutton.Text = "войти";
            this.enterbutton.UseVisualStyleBackColor = true;
            this.enterbutton.Click += new System.EventHandler(this.enterbutton_Click);
            // 
            // loginform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 450);
            this.Controls.Add(this.enterbutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passtextbox);
            this.Controls.Add(this.logintextbox);
            this.Name = "loginform";
            this.Text = "Вход";
            this.Load += new System.EventHandler(this.loginform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox logintextbox;
        private System.Windows.Forms.TextBox passtextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button enterbutton;
    }
}