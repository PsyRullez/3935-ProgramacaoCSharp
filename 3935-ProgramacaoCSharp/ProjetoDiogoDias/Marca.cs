using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPedro
{
    internal class Marca
    {
        private int idtabmarcas;
        private string marca;

        public Marca()
        {

        }

        public Marca(int idtabmarca, string marca)
        {
            this.idtabmarcas = idtabmarca;
            this.marca = marca;
        }

        public int getidtabmarcas { get => idtabmarcas; set => idtabmarcas = value;  }
        public string getmarca { get => marca; set => marca = value; }

        public override bool Equals(object obj)
        {
           var categoria = obj as Marca;
            return categoria != null && idtabmarcas == categoria.idtabmarcas;


        }

        public override int GetHashCode()
        {
            return -123456789 + idtabmarcas.GetHashCode();
        }

        public override string ToString()
        {
            return getmarca;
        }

    }
}
