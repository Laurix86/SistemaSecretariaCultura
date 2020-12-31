
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
    public class CentroCultural
    {
        #region atributos de instancia
        private int _id;
        private string _nombre;
        private string _localidad;
        private string _provincia;
        #endregion

        #region constructores
        public CentroCultural(int pid, string pnom, string ploc, string pprov)
        {
            this.Id = pid;
            this.Nombre = pnom;
            this.Localidad = ploc;
            this.Provincia = pprov;
        }
        #endregion

        #region propiedades

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string Localidad
        {
            get { return _localidad; }
            set { _localidad = value; }
        }

        public string Provincia
        {
            get { return _provincia; }
            set { _provincia = value; }
        }
        #endregion

        #region consultas
        public bool Equals(CentroCultural c)
        {
            return this.Nombre == c.Nombre && this.Localidad == c.Localidad && this.Provincia == c.Provincia;
        }

        public override string ToString()
        {
            return this.Id + " - "+ this.Nombre + "\r\nDe " + this.Localidad + " en " + this.Provincia;
        }

        #endregion

    } // fin clase CentroCultural

    [Serializable]
    public class ColeccionCentros
    {
        private List<CentroCultural> ColCentros;
        private List<CentroCultural> auxList;
        private int contador;

        public ColeccionCentros()
        {
            ColCentros = new List<CentroCultural>();
        }

        public void AgregarCentro(CentroCultural c)
        {
            ColCentros.Add(c);
        }

        public int CantidadDeCentros()
        {
            return ColCentros.Count();
        }

        public int CantidadCentrosPorProvincia(string prov)
        {
            contador = 0;

            foreach(CentroCultural c in ColCentros)
            {
                if (c.Provincia.ToUpper() == prov.ToUpper())
                {
                    contador++;
                }
            }
            return contador;
        }

        /* public Array ListaCentrosPorProvincia()
        {
            
            Array[,] listaCentrosProv = new Array[0,0];
            List<CentroCultural> auxCentro = new List<CentroCultural>(ColCentros);

            for(int i)
            return listaCentrosProv;
        } */
        public List<CentroCultural> CentrosPorProvincia(string prov)
        {
            auxList = new List<CentroCultural>();

            foreach (CentroCultural c in ColCentros)
            {
                if (c.Provincia.ToUpper() == prov.ToUpper())
                {
                    auxList.Add(c);
                }
            }
            return auxList;
        }

        public CentroCultural CentrosPorId(int pid)
        {
            foreach(CentroCultural c in ColCentros)
            {
                if(c.Id == pid)
                {
                    return c;
                }
            }
            return null;
        }

        public List<CentroCultural> CentroCulturalPorNombre(string nom)
        {
            auxList = new List<CentroCultural>();

            foreach (CentroCultural c in ColCentros)
            {
                if (c.Nombre.ToUpper().Contains(nom))
                {
                    auxList.Add(c);
                }
            }
            return auxList;
        }

        public bool ExisteCentro(CentroCultural c)
        {

            foreach (CentroCultural elem in ColCentros)
            {

                if (elem.Equals(c))
                {
                    return true;
                }
            }
            return false;
        }

        
    }
}
