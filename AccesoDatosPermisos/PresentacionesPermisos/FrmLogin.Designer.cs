﻿
namespace PresentacionesPermisos
{
    partial class FrmLogin
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
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(77, 306);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(11, 11, 11, 11);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(188, 34);
            this.BtnCancelar.TabIndex = 19;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(302, 306);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(11, 11, 11, 11);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(253, 34);
            this.btnRegistrar.TabIndex = 18;
            this.btnRegistrar.Text = "iniciar sesion";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(70, 181);
            this.label6.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 24);
            this.label6.TabIndex = 17;
            this.label6.Text = "RFC";
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(302, 172);
            this.txtContraseña.Margin = new System.Windows.Forms.Padding(11, 11, 11, 11);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(253, 29);
            this.txtContraseña.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 105);
            this.label5.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 24);
            this.label5.TabIndex = 15;
            this.label5.Text = "idUsuario";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(302, 96);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(11, 11, 11, 11);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(253, 29);
            this.txtUsuario.TabIndex = 14;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 385);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtUsuario);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FrmLogin";
            this.Text = "FrmLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUsuario;
    }
}