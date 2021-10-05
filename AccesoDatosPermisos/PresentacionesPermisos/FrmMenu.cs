using System;
using System.Windows.Forms;

namespace PresentacionesPermisos
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            if (lblTipoCuenta.Text == "Administrador")
            {
                FrmVistasUsuarios fvu = new FrmVistasUsuarios();
                fvu.ShowDialog();
                
            }

            else if (lblTipoCuenta.Text == "Usuario" && lblPerfil.Text == "Proveedor")
            {
                FrmVistasUsuarios fvu = new FrmVistasUsuarios();
                fvu.btnAgregar.Visible = false;
                fvu.btnEliminar.Visible = false;
                fvu.dtgUsuarios.Enabled = false;
                fvu.ShowDialog();

                
            }
            
        }

        private void btnHerramientas_Click(object sender, EventArgs e)
        {
            

            if(lblTipoCuenta.Text == "Usuario" && lblPerfil.Text == "Proveedor")
            {
                FrmVistasHerramientas fv = new FrmVistasHerramientas();
                fv.btnEliminar.Visible = false;
                fv.dtgHerramientas.Enabled = false;
                fv.ShowDialog();
                
            }

            else
            {
                FrmVistasHerramientas fv = new FrmVistasHerramientas();
                fv.ShowDialog();
            }

        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            if (lblTipoCuenta.Text == "Usuario" && lblPerfil.Text == "Proveedor")
            {
                FrmVistasProductos fv = new FrmVistasProductos();
                fv.btnEliminar.Visible = false;
                fv.dtgProductos.Enabled = false;
                fv.ShowDialog();
            }

            else
            {
                FrmVistasProductos fv = new FrmVistasProductos();
               
                fv.ShowDialog();
            }
            
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            if (lblTipoCuenta.Text == "Administrador" && lblPerfil.Text == "Vendedor")
            {
                FrmCompras fv = new FrmCompras();
                fv.ShowDialog();
            }

            else
            {
                FrmCompras fv = new FrmCompras();
                fv.ShowDialog();
            }
        }

        private void BtnVentas_Click(object sender, EventArgs e)
        {
            if (lblTipoCuenta.Text == "Usuario" && lblPerfil.Text == "Proveedor")
            {
                FrmVentas fv = new FrmVentas();
                fv.ShowDialog();
            }

            else
            {
                FrmVentas fv = new FrmVentas();
                fv.ShowDialog();
            }

        }
    }
}
