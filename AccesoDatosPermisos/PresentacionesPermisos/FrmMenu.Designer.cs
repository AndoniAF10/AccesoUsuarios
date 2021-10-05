
namespace PresentacionesPermisos
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.lblUsuario = new System.Windows.Forms.ToolStripLabel();
            this.btnUsuarios = new System.Windows.Forms.ToolStripButton();
            this.lblHerramienta = new System.Windows.Forms.ToolStripLabel();
            this.btnHerramientas = new System.Windows.Forms.ToolStripButton();
            this.lblProducto = new System.Windows.Forms.ToolStripLabel();
            this.btnProductos = new System.Windows.Forms.ToolStripButton();
            this.lblSalir = new System.Windows.Forms.ToolStripLabel();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.lblTipoCuenta = new System.Windows.Forms.ToolStripLabel();
            this.lblCompras = new System.Windows.Forms.ToolStripLabel();
            this.btnCompras = new System.Windows.Forms.ToolStripButton();
            this.lblVentas = new System.Windows.Forms.ToolStripLabel();
            this.BtnVentas = new System.Windows.Forms.ToolStripButton();
            this.lblPerfil = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblUsuario,
            this.btnUsuarios,
            this.lblHerramienta,
            this.btnHerramientas,
            this.lblProducto,
            this.btnProductos,
            this.lblSalir,
            this.btnSalir,
            this.lblTipoCuenta,
            this.lblCompras,
            this.btnCompras,
            this.lblVentas,
            this.BtnVentas,
            this.lblPerfil});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(79, 451);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // lblUsuario
            // 
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(76, 15);
            this.lblUsuario.Text = "Usuarios";
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("btnUsuarios.Image")));
            this.btnUsuarios.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(76, 20);
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // lblHerramienta
            // 
            this.lblHerramienta.Name = "lblHerramienta";
            this.lblHerramienta.Size = new System.Drawing.Size(76, 15);
            this.lblHerramienta.Text = "Herramientas";
            // 
            // btnHerramientas
            // 
            this.btnHerramientas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnHerramientas.Image = ((System.Drawing.Image)(resources.GetObject("btnHerramientas.Image")));
            this.btnHerramientas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHerramientas.Name = "btnHerramientas";
            this.btnHerramientas.Size = new System.Drawing.Size(76, 20);
            this.btnHerramientas.Text = "toolStripButton2";
            this.btnHerramientas.Click += new System.EventHandler(this.btnHerramientas_Click);
            // 
            // lblProducto
            // 
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(76, 15);
            this.lblProducto.Text = "Productos";
            // 
            // btnProductos
            // 
            this.btnProductos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnProductos.Image = ((System.Drawing.Image)(resources.GetObject("btnProductos.Image")));
            this.btnProductos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(76, 20);
            this.btnProductos.Text = "toolStripButton1";
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // lblSalir
            // 
            this.lblSalir.Name = "lblSalir";
            this.lblSalir.Size = new System.Drawing.Size(76, 15);
            this.lblSalir.Text = "Salir";
            // 
            // btnSalir
            // 
            this.btnSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(76, 20);
            this.btnSalir.Text = "toolStripButton2";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblTipoCuenta
            // 
            this.lblTipoCuenta.Name = "lblTipoCuenta";
            this.lblTipoCuenta.Size = new System.Drawing.Size(76, 15);
            this.lblTipoCuenta.Text = "cuenta";
            this.lblTipoCuenta.Visible = false;
            // 
            // lblCompras
            // 
            this.lblCompras.Name = "lblCompras";
            this.lblCompras.Size = new System.Drawing.Size(76, 15);
            this.lblCompras.Text = "Compras";
            // 
            // btnCompras
            // 
            this.btnCompras.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCompras.Image = ((System.Drawing.Image)(resources.GetObject("btnCompras.Image")));
            this.btnCompras.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCompras.Name = "btnCompras";
            this.btnCompras.Size = new System.Drawing.Size(76, 20);
            this.btnCompras.Text = "toolStripButton1";
            this.btnCompras.Click += new System.EventHandler(this.btnCompras_Click);
            // 
            // lblVentas
            // 
            this.lblVentas.Name = "lblVentas";
            this.lblVentas.Size = new System.Drawing.Size(76, 15);
            this.lblVentas.Text = "Ventas";
            // 
            // BtnVentas
            // 
            this.BtnVentas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnVentas.Image = ((System.Drawing.Image)(resources.GetObject("BtnVentas.Image")));
            this.BtnVentas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnVentas.Name = "BtnVentas";
            this.BtnVentas.Size = new System.Drawing.Size(76, 20);
            this.BtnVentas.Text = "toolStripButton2";
            this.BtnVentas.Click += new System.EventHandler(this.BtnVentas_Click);
            // 
            // lblPerfil
            // 
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(76, 15);
            this.lblPerfil.Text = "Perfil";
            this.lblPerfil.Visible = false;
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 451);
            this.Controls.Add(this.toolStrip1);
            this.IsMdiContainer = true;
            this.Name = "FrmMenu";
            this.Text = "FrmMenu";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.ToolStrip toolStrip1;
        public System.Windows.Forms.ToolStripLabel lblUsuario;
        public System.Windows.Forms.ToolStripButton btnUsuarios;
        public System.Windows.Forms.ToolStripLabel lblHerramienta;
        public System.Windows.Forms.ToolStripButton btnHerramientas;
        public System.Windows.Forms.ToolStripLabel lblProducto;
        public System.Windows.Forms.ToolStripButton btnProductos;
        public System.Windows.Forms.ToolStripLabel lblSalir;
        public System.Windows.Forms.ToolStripButton btnSalir;
        public System.Windows.Forms.ToolStripLabel lblTipoCuenta;
        public System.Windows.Forms.ToolStripLabel lblPerfil;
        public System.Windows.Forms.ToolStripLabel lblCompras;
        public System.Windows.Forms.ToolStripButton btnCompras;
        public System.Windows.Forms.ToolStripLabel lblVentas;
        public System.Windows.Forms.ToolStripButton BtnVentas;
    }
}