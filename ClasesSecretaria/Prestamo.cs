using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace ClasesSecretaria
{
    [Serializable]
    public class Prestamo
    {
        #region atributos
        private int _id;
        private Obra _obra;
        private DateTime _fechaPrestamo;
        private DateTime _fechaDevolucion;
        private CentroCultural _centro;
        #endregion

        #region constructores
        public Prestamo(int pid, Obra pobra, DateTime pfp, DateTime pfd, CentroCultural pcentro)
        {
            this.Id = pid;
            this.Obra = pobra;
            this.FechaPrestamo = pfp;
            this.FechaDevolucion = pfd;
            this.Centro = pcentro;
        }
        #endregion

        #region propiedades

        public int Id
        {
            get { return _id; }
            set { this._id = value; } //no sé si dejarle set en los id ??
        }
        public Obra Obra
        {
            get { return _obra; }
            set { _obra = value; }
        }

        public DateTime FechaPrestamo
        {
            get { return _fechaPrestamo; }
            set { _fechaPrestamo = value; }
        }

        public DateTime FechaDevolucion
        {
            get { return _fechaDevolucion; }
            set { _fechaDevolucion = value; }
        }

        public CentroCultural Centro
        {
            get { return _centro; }
            set { _centro = value; }
        }
        #endregion

        #region consultas
        public override string ToString()
        {
            return "Obra: " + Obra.Nombre + "prestada en fecha: " + FechaPrestamo.ToString("dd/MM/yyyy") + "al Centro Cultural: " + Centro.Nombre + ". Fecha Devolución: "+ FechaDevolucion.ToString("dd/MM/yyyy");
        }
        #endregion

    } // fin clase Prestamo

    [Serializable]
    public class ColeccionPrestamos
    {
        private List<Prestamo> ColPrestamos;
        private List<Prestamo> auxListPrestamo;
        private List<Obra> auxListObra;
        private List<Artista> auxListArtista;
        private int contador;

        public ColeccionPrestamos()
        {
            ColPrestamos = new List<Prestamo>();
        }

        public void AgregarPrestamos(Prestamo p)
        {
            ColPrestamos.Add(p);
        }

        public List<Obra> ObtenerObrasEnPrestamo() // Coleccion de obras, lista de obras, lista de coleccion de obras ??
        {
            auxListObra = new List<Obra>();
            foreach(Prestamo p in ColPrestamos)
            {
                if(p.FechaDevolucion > DateTime.Now)
                {
                    auxListObra.Add(p.Obra);
                }
            }
            return auxListObra;
        }

        public bool ComprobarDisponibilidadObra(Prestamo o, ref string msj)
        {
            bool disponible = false;

            foreach(Prestamo p in ColPrestamos)
            {
                if(p.Obra.Id == o.Id)
                {
                    if(o.FechaPrestamo < p.FechaDevolucion)
                    {
                        msj = "Esta obra estará en préstamo hasta: " + p.FechaDevolucion.ToString("dd/MM/yyyy") + "Modificar fecha de inicio.";
                    } else if (o.FechaDevolucion > p.FechaPrestamo)
                    {
                        msj = "Esta obra ya posee reserva a partir de: " + p.FechaPrestamo.ToString("dd/MM/yyyy") + "Modificar fecha de finalización."; 
                    }else
                    {
                        disponible = true;
                    }
                }
            }

            return disponible;

        }

        public List<Obra> ObrasPrestadasPorCentro(CentroCultural c)
        {
            auxListObra = new List<Obra>();
            foreach(Prestamo p in ColPrestamos)
            {
                CentroCultural auxCentro = p.Centro;
                if(auxCentro.Id == c.Id)
                {
                    auxListObra.Add(p.Obra);
                }
            }
            return auxListObra;
        }

        public List<Artista> ArtistasPorCentro(CentroCultural c)
        {
            auxListArtista = new List<Artista>();

            foreach(Prestamo p in ColPrestamos)
            {
                CentroCultural auxCentro = p.Centro;
                if (auxCentro.Id == c.Id)
                {
                    Obra auxObra = p.Obra;
                    auxListArtista.Add(auxObra.Autor);
                }
            }
            return auxListArtista;
        }

        public int CantidadPrestamos()
        {
            return ColPrestamos.Count;
        }

        public int CantidadCuadrosPrestados()
        {
            contador = 0;

            foreach(Prestamo p in ColPrestamos)
            {
                if(p.Obra.GetType() == typeof(Cuadro))
                {
                    contador++;
                }
            }

                    return contador;
        }

        public string InfoObrasEnPrestamoPorArtista(Artista a)
        {
            string info = "";

            foreach (Prestamo p in ColPrestamos)
            {
                Obra auxObra = p.Obra;
                Artista auxArt = auxObra.Autor;
                if (auxArt.Id == a.Id)
                {
                    if (auxObra.GetType() == typeof(Escultura))
                    {
                        info += "Escultura: "+ auxObra.Nombre + "En préstamo desde: " + p.FechaPrestamo.ToString("dd/MM/yyyy") + " hasta: " + p.FechaDevolucion.ToString("dd/MM/yyyy") + " en el Centro Cultural: " + p.Centro;
                    }
                    else
                    {
                        info += "Cuadro: " + auxObra.Nombre + "En préstamo desde: " + p.FechaPrestamo.ToString("dd/MM/yyyy") + " hasta: " + p.FechaDevolucion.ToString("dd/MM/yyyy") + " en el Centro Cultural: " + p.Centro;

                    }
                }
            }
            return info;
        }
        public string InfoObrasEnPrestamo(Obra o)
        {
            string info = "";

            foreach(Prestamo p in ColPrestamos)
            {
                Obra aux = p.Obra;
                if(aux.Id == o.Id)
                {
                    CentroCultural auxCentro = p.Centro;
                    info += "En préstamo desde: " + p.FechaPrestamo.ToString("dd/MM/yyyy") + "hasta: " + p.FechaDevolucion.ToString("dd/MM/yyyy") + " en el Centro Cultural: " + auxCentro.Nombre;
                }
            }
            return info;
        }
        public int CantidadEsculturasPrestadas()
        {
            contador = 0;

            foreach (Prestamo p in ColPrestamos)
            {
                if (p.Obra.GetType() == typeof(Escultura))
                {
                    contador++;
                }
            }

            return contador;
        }


    }
}
