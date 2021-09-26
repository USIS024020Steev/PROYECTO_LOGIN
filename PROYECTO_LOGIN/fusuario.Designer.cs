
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fusuario));
            this.lbluser = new System.Windows.Forms.Label();
            this.lblcontra = new System.Windows.Forms.Label();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.txtclave = new System.Windows.Forms.TextBox();
            this.btnaccess = new System.Windows.Forms.Button();
            this.btnsql = new System.Windows.Forms.Button();
            this.btnreg = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbluser
            // 
            this.lbluser.AutoSize = true;
            this.lbluser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbluser.Location = new System.Drawing.Point(243, 92);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(116, 25);
            this.lbluser.TabIndex = 0;
            this.lbluser.Text = "USUARIO:";
            // 
            // lblcontra
            // 
            this.lblcontra.AutoSize = true;
            this.lblcontra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcontra.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblcontra.Location = new System.Drawing.Point(243, 173);
            this.lblcontra.Name = "lblcontra";
            this.lblcontra.Size = new System.Drawing.Size(169, 25);
            this.lblcontra.TabIndex = 1;
            this.lblcontra.Text = "CONTRASEÑA:";
            // 
            // txtuser
            // 
            this.txtuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuser.Location = new System.Drawing.Point(418, 87);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(207, 30);
            this.txtuser.TabIndex = 2;
            // 
            // txtclave
            // 
            this.txtclave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtclave.Location = new System.Drawing.Point(418, 168);
            this.txtclave.Name = "txtclave";
            this.txtclave.Size = new System.Drawing.Size(207, 30);
            this.txtclave.TabIndex = 3;
            // 
            // btnaccess
            // 
            this.btnaccess.BackColor = System.Drawing.Color.Aqua;
            this.btnaccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaccess.Location = new System.Drawing.Point(200, 311);
            this.btnaccess.Name = "btnaccess";
            this.btnaccess.Size = new System.Drawing.Size(137, 63);
            this.btnaccess.TabIndex = 4;
            this.btnaccess.Text = "Inicio en Access";
            this.btnaccess.UseVisualStyleBackColor = false;
            this.btnaccess.Click += new System.EventHandler(this.btnaccess_Click);
            // 
            // btnsql
            // 
            this.btnsql.BackColor = System.Drawing.Color.Aqua;
            this.btnsql.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsql.Location = new System.Drawing.Point(357, 311);
            this.btnsql.Name = "btnsql";
            this.btnsql.Size = new System.Drawing.Size(125, 63);
            this.btnsql.TabIndex = 5;
            this.btnsql.Text = "Inicio en SQL";
            this.btnsql.UseVisualStyleBackColor = false;
            this.btnsql.Click += new System.EventHandler(this.btnsql_Click);
            // 
            // btnreg
            // 
            this.btnreg.BackColor = System.Drawing.Color.Aqua;
            this.btnreg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreg.Location = new System.Drawing.Point(502, 311);
            this.btnreg.Name = "btnreg";
            this.btnreg.Size = new System.Drawing.Size(123, 63);
            this.btnreg.TabIndex = 6;
            this.btnreg.Text = "Registrarse";
            this.btnreg.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(62, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 171);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // fusuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnreg);
            this.Controls.Add(this.btnsql);
            this.Controls.Add(this.btnaccess);
            this.Controls.Add(this.txtclave);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.lblcontra);
            this.Controls.Add(this.lbluser);
            this.Name = "fusuario";
            this.Text = "Usaurio";
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
        private System.Windows.Forms.Button button1;
    }
}