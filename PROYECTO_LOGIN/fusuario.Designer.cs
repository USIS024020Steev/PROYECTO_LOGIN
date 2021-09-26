
namespace PROYECTO_LOGIN
{
    partial class fusuario
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
            this.lbluser = new System.Windows.Forms.Label();
            this.lblcontra = new System.Windows.Forms.Label();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.txtclave = new System.Windows.Forms.TextBox();
            this.btnaccess = new System.Windows.Forms.Button();
            this.btnsql = new System.Windows.Forms.Button();
            this.btnreg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbluser
            // 
            this.lbluser.AutoSize = true;
            this.lbluser.Location = new System.Drawing.Point(173, 73);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(70, 17);
            this.lbluser.TabIndex = 0;
            this.lbluser.Text = "USUARIO";
            // 
            // lblcontra
            // 
            this.lblcontra.AutoSize = true;
            this.lblcontra.Location = new System.Drawing.Point(173, 191);
            this.lblcontra.Name = "lblcontra";
            this.lblcontra.Size = new System.Drawing.Size(103, 17);
            this.lblcontra.TabIndex = 1;
            this.lblcontra.Text = "CONTRASEÑA";
            // 
            // txtuser
            // 
            this.txtuser.Location = new System.Drawing.Point(349, 68);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(100, 22);
            this.txtuser.TabIndex = 2;
            // 
            // txtclave
            // 
            this.txtclave.Location = new System.Drawing.Point(349, 186);
            this.txtclave.Name = "txtclave";
            this.txtclave.Size = new System.Drawing.Size(100, 22);
            this.txtclave.TabIndex = 3;
            // 
            // btnaccess
            // 
            this.btnaccess.Location = new System.Drawing.Point(176, 257);
            this.btnaccess.Name = "btnaccess";
            this.btnaccess.Size = new System.Drawing.Size(91, 47);
            this.btnaccess.TabIndex = 4;
            this.btnaccess.Text = "Inicio en Access";
            this.btnaccess.UseVisualStyleBackColor = true;
            this.btnaccess.Click += new System.EventHandler(this.btnaccess_Click);
            // 
            // btnsql
            // 
            this.btnsql.Location = new System.Drawing.Point(331, 257);
            this.btnsql.Name = "btnsql";
            this.btnsql.Size = new System.Drawing.Size(91, 47);
            this.btnsql.TabIndex = 5;
            this.btnsql.Text = "Inicio en SQL";
            this.btnsql.UseVisualStyleBackColor = true;
            this.btnsql.Click += new System.EventHandler(this.btnsql_Click);
            // 
            // btnreg
            // 
            this.btnreg.Location = new System.Drawing.Point(477, 257);
            this.btnreg.Name = "btnreg";
            this.btnreg.Size = new System.Drawing.Size(91, 47);
            this.btnreg.TabIndex = 6;
            this.btnreg.Text = "Registrarse";
            this.btnreg.UseVisualStyleBackColor = true;
            // 
            // fusuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnreg);
            this.Controls.Add(this.btnsql);
            this.Controls.Add(this.btnaccess);
            this.Controls.Add(this.txtclave);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.lblcontra);
            this.Controls.Add(this.lbluser);
            this.Name = "fusuario";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.fusuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbluser;
        private System.Windows.Forms.Label lblcontra;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.TextBox txtclave;
        private System.Windows.Forms.Button btnaccess;
        private System.Windows.Forms.Button btnsql;
        private System.Windows.Forms.Button btnreg;
    }
}