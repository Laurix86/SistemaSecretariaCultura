using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClasesSecretaria;
using System.Windows.Forms;

namespace SecretariaDeCultura
{
    public partial class frmConsulta : Form
    {
        RadioButton[] rbs;
        public frmConsulta()
        {
            InitializeComponent();
            rbs = new RadioButton[] { radObra, radArtista, radCentro, radPrestamo };

            for (int i = 0; i < rbs.Length; i++)
            {
                rbs[i].Tag = i;
                rbs[i].CheckedChanged += new EventHandler(gpbBusqueda_CheckedChanged);
            }
        }

        private void frmConsulta_Load(object sender, EventArgs e)
        {
            pnlObra.Visible = true;
            radObra.Checked = true;
            ComboPorObras();
            radNombreArt.Checked = true;
            lblPorNombreArt.Text = "Buscar por nombre: ";
            lblListaArtistas.Text = "Listado de Artistas: ";
            ComboPorArtistas();
            radPorNombreCentro.Checked = true;
            ComboPorCentro();
            CargarCombosPrestamo();

        }

        private void ResetControles()
        {
            cbxArtistasPrestamo.SelectedIndex = -1;
            cbxCentrosPrestamo.SelectedIndex = -1;
            cbxListaArtistas.SelectedIndex = -1;
            cbxListaCentros.SelectedIndex = -1;
            cbxListaObras.SelectedIndex = -1;
            cbxObrasPrestamo.SelectedIndex = -1;
            lstInfoArtistas.Items.Clear();
            lstInfoCentros.Items.Clear();
            lstInfoObras.Items.Clear();
            lstInfoPrestamos.Items.Clear();
            txtNombreArtista.Text = "";
            txtNombreObra.Text = "";
            txtPorNombreCentro.Text = "";
        }
        private void gpbBusqueda_CheckedChanged(object sender, EventArgs e)
        {
            string chequeado = ((RadioButton)sender).Name;
            RadioButton rb = sender as RadioButton;
            switch (rb.Tag)
            {
                case 0:
                    ResetControles();
                    pnlObra.Visible = true;
                    pnlCentro.Visible = false;
                    pnlArtista.Visible = false;
                    pnlPrestamo.Visible = false;
                    break;
                case 1:
                    ResetControles();
                    pnlObra.Visible = false;
                    pnlCentro.Visible = false;
                    pnlArtista.Visible = true;
                    pnlPrestamo.Visible = false;
                    break;
                case 2:
                    ResetControles();
                    pnlObra.Visible = false;
                    pnlCentro.Visible = true;
                    pnlArtista.Visible = false;
                    pnlPrestamo.Visible = false;
                    break;
                case 3:
                    ResetControles();
                    pnlObra.Visible = false;
                    pnlCentro.Visible = false;
                    pnlArtista.Visible = false;
                    pnlPrestamo.Visible = true;
                    break;
            }

        }


        #region Consulta Obras
        private void ComboPorObras()
        {
            cbxListaObras.Items.Clear();
            int cantObras = Program.colObras.CantidadObras();
            if (cantObras > 0)
            {
                for (int i = 1; i <= cantObras; i++)
                {
                    Obra auxObra = Program.colObras.ObraPorId(i);
                   
                    cbxListaObras.Items.Add(auxObra.Id + " - " + auxObra.Nombre);
                   
                }
            }
        }


        private void ComboPorCuadros()
        {
            cbxListaObras.Items.Clear();
            int cantObras = Program.colObras.CantidadCuadros();
            
            if (cantObras > 0)
            {
                for (int i = 0; i < Program.colObras.CantidadObras(); i++)
                {
                    Obra auxObra = Program.colObras.ObraPorId(i+1);
                    
                    if (auxObra.GetType() == typeof(Cuadro)) {
                        cbxListaObras.Items.Add(auxObra.Id + " - " + auxObra.Nombre);
                    }
                }
            }
            else
            {
                Mensajes(lblMsjBusquedaObra, "No hay cuadros para mostrar.");
            }
        }
        private void ComboPorEsculturas()
        {
            cbxListaObras.Items.Clear();
            int cantObras = Program.colObras.CantidadEsculturas();
            
            if (cantObras > 0)
            {
                for (int i = 0; i < Program.colObras.CantidadObras(); i++)
                {
                    Obra auxObra = Program.colObras.ObraPorId(i+1);
                    
                    if (auxObra.GetType() == typeof(Escultura)) {
                        cbxListaObras.Items.Add(auxObra.Id + " - " + auxObra.Nombre);
                    }
                }
            }
            else
            {
                Mensajes(lblMsjBusquedaObra, "No hay esculturas para mostrar.");
            }
        }
        private void chkEscultura_CheckedChanged(object sender, EventArgs e)
        {
            ControlChecksObra();
        }

        private void ControlChecksObra()
        {
           
            if (chkCuadro.Checked == true)
            {
                
                chkEscultura.Enabled = false;
                ComboPorCuadros();
            }
            else if (chkEscultura.Checked == true)
            {
                
                chkCuadro.Enabled = false;
                ComboPorEsculturas();
            }
            else
            {
                
                chkCuadro.Enabled = true;
                chkEscultura.Enabled = true;
                ComboPorObras();
            }
        }

        private void chkCuadro_CheckedChanged(object sender, EventArgs e)
        {
            ControlChecksObra();
        }
        private void btnBuscarObra_Click(object sender, EventArgs e)
        {
            if (txtNombreObra.Text == "")
            {
                Mensajes(lblMsjBusquedaObra, "Escribir en el campo de búsqueda.");
            }
            else
            {
                if (chkEscultura.Checked)
                {
                    List<Obra> lista = Program.colObras.ObraPorNombre(txtNombreObra.Text);
                    if (lista.Count() > 0)
                    {
                        foreach (Obra o in lista)
                        {
                            if (o.GetType() == typeof(Escultura))
                            {
                                cbxListaObras.Items.Clear();
                                cbxListaObras.Items.Add(o.Id + " - " + o.Nombre);
                            }
                        }
                    }
                    else
                    {
                        cbxListaObras.Items.Add("No hay Esculturas para mostrar.");
                    }
                } else if (chkCuadro.Checked)
                {
                    List<Obra> lista = Program.colObras.ObraPorNombre(txtNombreObra.Text);
                    if (lista.Count() > 0)
                    {
                        foreach (Obra o in lista)
                        {
                            if (o.GetType() == typeof(Cuadro))
                            {
                                cbxListaObras.Items.Clear();
                                cbxListaObras.Items.Add(o.Id + " - " + o.Nombre);
                            }
                        }
                    }
                    else
                    {
                        cbxListaObras.Items.Add("No hay Cuadros para mostrar.");
                    }
                }
                else
                {
                    List<Obra> lista = Program.colObras.ObraPorNombre(txtNombreObra.Text);
                    if (lista.Count() > 0)
                    {
                        foreach (Obra o in lista)
                        {
                            cbxListaObras.Items.Clear();
                            cbxListaObras.Items.Add(o.Id + " - " + o.Nombre);
                        }
                    }
                    else
                    {
                        cbxListaObras.Items.Add("No hay obras para mostrar.");
                    }
                }
            }
        }

        private void cbxListaObras_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxListaObras.SelectedIndex > -1)
            {
                lstInfoObras.Items.Clear();
                int indice = Convert.ToString(cbxListaObras.SelectedItem).IndexOf(" -", 0);
                string sid = Convert.ToString(cbxListaObras.SelectedItem).Substring(0, indice);
                indice = Convert.ToInt32(sid);
                string infoObra = "";
                Obra auxObra = Program.colObras.ObraPorId(indice);
                lstInfoObras.Items.Add(auxObra.ToString());
                
                Artista auxArt = auxObra.Autor;
                infoObra += "\r\n" + auxArt.Apellido + " " + auxArt.Nombre;
                string auxInfo = Program.colPrestamos.InfoObrasEnPrestamo(auxObra);
                infoObra += "\r\n" + auxInfo;
                if (auxInfo == "")
                {
                    lstInfoObras.Items.Add("No hay registro de préstamos de la obra seleccionada.");
                }
                else
                {
                    
                    lstInfoArtistas.Items.Add(infoObra);
                }
            }
        }

        #endregion


        #region Consulta Artistas
        private void radNombreArt_CheckedChanged(object sender, EventArgs e)
        {
            if (radNombreArt.Checked)
            {
                lblPorNombreArt.Text = "Buscar por nombre: ";
                lblListaArtistas.Text = "Listado de Artistas: ";
                ComboPorArtistas();
            }
            else
            {
                lblPorNombreArt.Text = "Buscar por nacionalidad: ";
                lblListaArtistas.Text = "Listado por nacionalidad: ";
            }
        }

        private void ComboPorArtistas()
        {
            cbxListaArtistas.Items.Clear();
            int cantArt = Program.colArtistas.CantidadArtistas();
            if (cantArt > 0)
            {
                for (int i = 0; i < cantArt; i++)
                {
                    Artista auxArt = Program.colArtistas.ArtistaPorId(i + 1);
                    cbxListaArtistas.Items.Add(auxArt.Id + " - " + auxArt.Apellido + " " + auxArt.Nombre);
                }
            }
        }

        private void ComboPorNacionalidad(string pnac)
        {
            cbxListaArtistas.Items.Clear();
            List<Artista> lista = Program.colArtistas.ArtistaPorNacionalidad(pnac);
            int cantArt = lista.Count();
            if (cantArt > 0)
            {
                foreach (Artista auxArt in lista)
                {
                    cbxListaArtistas.Items.Add(auxArt.Id + " - " + auxArt.Apellido + " " + auxArt.Nombre);
                }
            }
        }
        private void ComboPorNombre(string pnom)
        {
            cbxListaArtistas.Items.Clear();
            List<Artista> lista = Program.colArtistas.ArtistaPorNombreCompleto(pnom);
            int cantArt = lista.Count();
            if (cantArt > 0)
            {
                foreach (Artista auxArt in lista)
                {
                    cbxListaArtistas.Items.Add(auxArt.Id + " - " + auxArt.Apellido + " " + auxArt.Nombre);
                }
            }
        }

        private void btnBuscarArtista_Click(object sender, EventArgs e)
        {
            if (radNombreArt.Checked) {
                if (txtNombreArtista.Text == "")
                {
                    Mensajes(lblMsjBuscar, "Ingrese un nombre.");
                }
                else
                {
                    ComboPorNombre(txtNombreArtista.Text);
                }
            } else if (radNacArt.Checked)
            {
                if (txtNombreArtista.Text == "")
                {
                    Mensajes(lblMsjBuscar, "Ingrese el país para buscar.");
                }
                else
                {
                    ComboPorNacionalidad(txtNombreArtista.Text);
                }
            }
        }

        private void cbxListaArtistas_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstInfoArtistas.Items.Clear();
            if (cbxListaArtistas.SelectedIndex > -1)
            {
                lstInfoArtistas.Items.Clear();
                int indice = Convert.ToString(cbxListaArtistas.SelectedItem).IndexOf(" -", 0);
                string sid = Convert.ToString(cbxListaArtistas.SelectedItem).Substring(0, indice);
                indice = Convert.ToInt32(sid);
                Artista auxArt = Program.colArtistas.ArtistaPorId(indice);
                lstInfoArtistas.Items.Add(auxArt.ToString());
                List<Obra> auxLista = Program.colObras.ObraPorAutor(auxArt);
                if (auxLista.Count>0) 
                {
                    lstInfoArtistas.Items.Add("Obras del artista seleccionado:");
                    foreach (Obra o in auxLista)
                    {
                        lstInfoArtistas.Items.Add("\r\n" + o.ToString());
                    }
                }
                else
                {
                    lstInfoArtistas.Items.Add("No hay obras de este artista registradas.");
                }
            }
        }
        #endregion

        #region Consulta Centros
        private void ComboPorCentro()
        {
            cbxListaCentros.Items.Clear();
            int cantCentro = Program.colCentros.CantidadDeCentros();
            if (cantCentro > 0)
            {
                for (int i = 0; i < cantCentro; i++)
                {
                    cbxListaCentros.Items.Add(Program.colCentros.CentrosPorId(i+1).Id + " - " + Program.colCentros.CentrosPorId(i+1).Nombre);
                }
            }
            else
            {
                Mensajes(lblMsjBusquedaCentro, "No hay información para mostrar.");
            }

        }
        private void radPorProvCentro_CheckedChanged(object sender, EventArgs e)
        {
            if (radPorProvCentro.Checked)
            {
                ComboListaPorProvincias();
            }
            else
            {
                ComboPorCentro();
            }
        }
        private void ComboListaPorProvincias()
        {
            cbxListaCentros.Items.Clear();
            //ColeccionCentros auxCentro = Program.colCentros;
            int cantCentros = Program.colCentros.CantidadDeCentros();
            if (cantCentros > 0) {
                for (int i = 0; i < Program.listaProvincias.Length; i++)
                {
                    cbxListaCentros.Items.Add(Program.listaProvincias[i]);

                    for(int j = 0; j < cantCentros; j++) {
                        CentroCultural auxCentro = Program.colCentros.CentrosPorId(j+1);
                        if (Program.listaProvincias[i] == auxCentro.Provincia)
                        {
                            cbxListaCentros.Items.Add(auxCentro.Id + " - " + auxCentro.Nombre);
                            
                        }
                    }
                }
            }
            else
            {
                Mensajes(lblMsjBusquedaCentro, "No hay información para mostrar.");
            }
        }

        private void btnBuscarCentro_Click(object sender, EventArgs e)
        {
            List<CentroCultural> auxCentro;
            if (txtPorNombreCentro.Text == "")
            {
                Mensajes(lblMsjBusquedaCentro, "Escriba lo que desea buscar.");
            }
            else
            {
                if (radPorNombreCentro.Checked)
                {
                    auxCentro = Program.colCentros.CentroCulturalPorNombre(txtPorNombreCentro.Text);
                    if (auxCentro.Count > 0)
                    {
                        foreach (CentroCultural c in auxCentro)
                        {

                            cbxListaCentros.Items.Add(c.Id + " - " + c.Nombre);
                        }
                    }
                    else
                    {
                        Mensajes(lblMsjBusquedaCentro, "No hay información para mostrar.");
                    }
                }
                else
                {
                    auxCentro = Program.colCentros.CentrosPorProvincia(txtPorNombreCentro.Text);
                    if (auxCentro.Count > 0)
                    {
                        foreach (CentroCultural c in auxCentro)
                        {

                            cbxListaCentros.Items.Add(c.Id + " - " + c.Nombre);
                        }
                    }
                    else
                    {
                        Mensajes(lblMsjBusquedaCentro, "No hay información para mostrar.");
                    }
                }
            }

        }

        private void cbxListaCentros_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxListaCentros.SelectedIndex > -1)
            {
                lstInfoCentros.Items.Clear();
                int indice;

                if (radPorNombreCentro.Checked)
                {
                    indice = Convert.ToString(cbxListaCentros.SelectedItem).IndexOf(" -", 0);

                    string sid = Convert.ToString(cbxListaCentros.SelectedItem).Substring(0, indice);

                    indice = Convert.ToInt32(sid);
                    CentroCultural auxCentro = Program.colCentros.CentrosPorId(indice);
                    lstInfoCentros.Items.Add(auxCentro.ToString());
                    List<Obra> auxLista = Program.colPrestamos.ObrasPrestadasPorCentro(auxCentro);
                    if (auxLista.Count > 0)
                    {
                        lstInfoCentros.Items.Add("Obras recibidas en préstamo:");
                        foreach (Obra o in auxLista)
                        {
                            lstInfoCentros.Items.Add("\r\n" + o.ToString());
                        }
                    }
                    else
                    {
                        lstInfoCentros.Items.Add("No hay registrado de obras prestadas a este centro.");
                    }


                }
                else
                {
                    indice = Convert.ToString(cbxListaCentros.SelectedItem).IndexOf(" -", 0);
                    if (indice > -1)
                    {
                        string sid = Convert.ToString(cbxListaCentros.SelectedItem).Substring(0, indice);

                        indice = Convert.ToInt32(sid);
                        CentroCultural auxCentro = Program.colCentros.CentrosPorId(indice);
                        lstInfoCentros.Items.Add(auxCentro.ToString());
                        List<Obra> auxLista = Program.colPrestamos.ObrasPrestadasPorCentro(auxCentro);
                        if (auxLista.Count > 0)
                        {
                            lstInfoCentros.Items.Add("Obras recibidas en préstamo:");
                            foreach (Obra o in auxLista)
                            {
                                lstInfoCentros.Items.Add("\r\n" + o.ToString());
                            }
                        }
                        else
                        {
                            lstInfoCentros.Items.Add("No hay registrado de obras prestadas a este centro.");
                        }
                    }
                    else
                    {
                        Mensajes(lblMsjBusquedaCentro, "Selecciones un centro.");
                    }
                }
            }
        }
        #endregion

        #region Consulta Prestamos

        private void CargarCombosPrestamo()
        {
            if (Program.colObras.CantidadObras() > 0)
            {
                for(int i = 0; i< Program.colObras.CantidadObras(); i++)
                {
                    cbxObrasPrestamo.Items.Add(Program.colObras.ObraPorId(i + 1).Id + " - " + Program.colObras.ObraPorId(i + 1).Nombre);
                }
            }
            if (Program.colArtistas.CantidadArtistas() > 0)
            {
                for (int i = 0; i < Program.colArtistas.CantidadArtistas(); i++)
                {
                    cbxArtistasPrestamo.Items.Add(Program.colArtistas.ArtistaPorId(i + 1).Id + " - " + Program.colArtistas.ArtistaPorId(i + 1).Apellido + " "+ Program.colArtistas.ArtistaPorId(i + 1).Nombre);
                }
            }
            if (Program.colCentros.CantidadDeCentros() > 0)
            {
                for (int i = 0; i < Program.colCentros.CantidadDeCentros(); i++)
                {
                    cbxCentrosPrestamo.Items.Add(Program.colCentros.CentrosPorId(i + 1).Id + " - " + Program.colCentros.CentrosPorId(i + 1).Nombre);
                }
            }
        }
        private void cbxObrasPrestamo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxObrasPrestamo.SelectedIndex > -1)
            {
                lstInfoPrestamos.Items.Clear();
                Obra auxObra = Program.colObras.ObraPorId(cbxObrasPrestamo.SelectedIndex+1);
                string auxInfo = auxObra.Id + " - " + auxObra.Nombre;
                if(auxObra.GetType() == typeof(Escultura))
                {
                    auxInfo += "\nEscultura creada por: " + auxObra.Autor.Nombre + " en el año: "+ auxObra.FechaCreacion.Year;
                } else
                {
                    auxInfo += "\nCuadro creado por: " + auxObra.Autor.Nombre + " en el año: " + auxObra.FechaCreacion.Year;
                }
                string infoPrestamo = Program.colPrestamos.InfoObrasEnPrestamo(auxObra);
                if(infoPrestamo == "")
                {
                    auxInfo += "\n Esta obra aún no se ha entregado en préstamo";
                } else
                {
                    auxInfo += "\n" + infoPrestamo;
                }
                lstInfoPrestamos.Items.Add(auxInfo);
                
            }
        }

        private void cbxArtistasPrestamo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxArtistasPrestamo.SelectedIndex > -1)
            {
                lstInfoPrestamos.Items.Clear();
                Artista auxArtista = Program.colArtistas.ArtistaPorId(cbxArtistasPrestamo.SelectedIndex+1);
                string auxInfo = auxArtista.Id + " - " + auxArtista.Nombre + auxArtista.Apellido;
                string infoPrestamo = Program.colPrestamos.InfoObrasEnPrestamoPorArtista(auxArtista);
                if (infoPrestamo == "")
                {
                    auxInfo += "\n Las obras de este artista aún no se han entregado en préstamo";
                }
                else
                {
                    auxInfo += "\n" + infoPrestamo;
                }
                lstInfoPrestamos.Items.Add(auxInfo);
            }

        }

        private void cbxCentrosPrestamo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxCentrosPrestamo.SelectedIndex > -1)
            {
                lstInfoPrestamos.Items.Clear();
                CentroCultural auxCentro = Program.colCentros.CentrosPorId(cbxCentrosPrestamo.SelectedIndex+1);
                string auxInfo = auxCentro.Id + " - " + auxCentro.Nombre + "\n Ubicado en: " + auxCentro.Localidad + ", " + auxCentro.Provincia;
                List<Obra> auxListaObras = Program.colPrestamos.ObrasPrestadasPorCentro(auxCentro);
                if(auxListaObras.Count == 0)
                {
                    auxInfo += "\n Este centro aún no ha recibido obras en préstamo.";

                }
                else
                {
                    foreach(Obra o in auxListaObras)
                    {
                       
                        auxInfo += o.ToString() + " Autor: " + o.Autor.Apellido + " " + o.Autor.Nombre;
                        
                    }
                }
                lstInfoPrestamos.Items.Add(auxInfo);
            }
        }
        #endregion
        private async void Mensajes(Label p_lbl, string p_mensaje)
        {
            p_lbl.Text = p_mensaje;
            await Task.Delay(2500);
            p_lbl.Text = "";

        }

        
    }
}
