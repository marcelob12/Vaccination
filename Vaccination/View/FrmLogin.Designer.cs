namespace Vaccination
{
    partial class FrmLogin
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.lblUser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStartSesion = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUser
            // 
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblUser.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblUser.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblUser.Location = new System.Drawing.Point(221, 211);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(100, 23);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "Usuario:";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(195, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Constraseña:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(327, 211);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(172, 20);
            this.txtUser.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(327, 255);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(172, 20);
            this.txtPassword.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(221, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(376, 45);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sistema Vacunación  COVID-19\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStartSesion
            // 
            this.btnStartSesion.BackColor = System.Drawing.Color.LightBlue;
            this.btnStartSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnStartSesion.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnStartSesion.Location = new System.Drawing.Point(327, 314);
            this.btnStartSesion.Name = "btnStartSesion";
            this.btnStartSesion.Size = new System.Drawing.Size(172, 27);
            this.btnStartSesion.TabIndex = 5;
            this.btnStartSesion.Text = "Iniciar sesion";
            this.btnStartSesion.UseVisualStyleBackColor = false;
            this.btnStartSesion.Click += new System.EventHandler(this.btnStartSesion_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(354, 102);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnStartSesion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblUser);
            this.MaximizeBox = false;
            this.Name = "FrmLogin";
            this.Text = "Login Manager";
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.PictureBox pictureBox1;

        private System.Windows.Forms.Button btnStartSesion;

        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox textBox1;

        private System.Windows.Forms.Label lblUser;

        #endregion
    }
}