using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using ClasesSecretaria;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecretariaDeCultura
{
    public partial class frmNuevoArtista : Form
    {
        int id;
        string name, apellido, nac;
        DateTime fnac;
        DateTime ffall;


        public frmNuevoArtista()
        {
            InitializeComponent();
        }
        private void frmNuevoArtista_Load(object sender, EventArgs e)
        {
            id = Program.colArtistas.CantidadArtistas() + 1;
            txtIdArt.Text = Convert.ToString(id);
        }
        private void btnGuardarArtista_Click(object sender, EventArgs e)
        {
            if (InputsCompletos())
            {
                
                name = txtNombreArtista.Text;
                apellido = txtApellidoArtista.Text;
                nac = txtNacionalidad.Text;
                fnac = Convert.ToDateTime(mkdFNac.Text);
                ffall = chkFFall.Checked ? Convert.ToDateTime(mkdFFall.Text) : DateTime.MinValue;
                if (ExisteArtista())
                {
                    MessageBox.Show("Este artista: " + name + " " + apellido + ", ya se encuentra registrado");
                }else
                {
                    Artista auxArt = new Artista(id, name, apellido, nac, fnac, ffall);
                    Program.colArtistas.AgregarArtista(auxArt);
                    Mensajes(lblMsjGuardadoArt, "Guardado exitoso!");
                    LimpiarPantalla();
                }
            }
        }

        private bool InputsCompletos()
        {
            bool completo = false;
            if (txtNombreArtista.Text == "")
            {
                Mensajes(lblMsjNombreArt, "Completar con nombre.");

            } else if (txtApellidoArtista.Text == "")
            {
                Mensajes(lblMsjApellidoArt, "Completar con apellido.");
            } else if (txtNacionalidad.Text == "")
            {
                Mensajes(lblMsjNacArt, "Completar con nacionalidad.");
            } 
            else if (!mkdFNac.MaskCompleted)
            {
                Mensajes(lblMsjNacArt, "Completar Fecha de Nacimiento.");
            }else if (chkFFall.Checked && !mkdFFall.MaskCompleted)
            {
                Mensajes(lblMsjFFallArt, "Revisar Fecha de Fallecimiento.");
            } else
            {
                completo = true;
            }
            return completo;

        }

        private bool ExisteArtista()
        {
            Artista auxArt = new Artista(txtNombreArtista.Text, txtApellidoArtista.Text, txtNacionalidad.Text, Convert.ToDateTime(mkdFNac.Text));
             

            if (Program.colArtistas.ExisteArtista(auxArt)){
                return true;
                }
            return false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpiarArtista_Click(object sender, EventArgs e)
        {
            LimpiarPantalla();
        }

        private async void Mensajes(Label p_lbl, string p_mensaje)
        {
            p_lbl.Text = p_mensaje;
            await Task.Delay(2500);
            p_lbl.Text = "";

        }

        

        private void chkFFall_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFFall.Checked)
            {
                lblFFall.Enabled = true ;
                mkdFFall.Enabled = true;
                mkdFFall.Visible = true;
            }
            else
            {
                lblFFall.Enabled = false;
                mkdFFall.Enabled = false;
                mkdFFall.Visible = false;
            }
        }

        private void LimpiarPantalla()
        {
            txtApellidoArtista.Text = "";
            txtNombreArtista.Text = "";
            txtNacionalidad.Text = "";
            mkdFNac.Text = "";
            mkdFFall.Text = "";
            chkFFall.Checked = false;
            id = Program.colArtistas.CantidadArtistas() + 1;
            txtIdArt.Text = Convert.ToString(id);
        }
    }
}
