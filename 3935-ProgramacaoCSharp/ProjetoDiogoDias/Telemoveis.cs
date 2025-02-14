using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPedro
{
    internal class Telemoveis
    {
        private int value;

        [DisplayName ("Nº Telemovel")]
        public int Idtabtelemoveis { get; set;  }
        [DisplayName ("Marca")]
        public Marca MarcaTele { get; set; }
        public string Modelo { get; set; }
        public float Tamanho { get; set; }
        public int Ano { get; set; }
        [DisplayName("Preço")]
        public float Preco { get; set; }
        public string Detalhes { get; set; }
        public byte[] Imagem { get; set; }

        public Telemoveis(int idtelemoveis, Marca marcaTele, string modelo, float tamanho, int ano, float preco, string detalhes, byte[] imagem)
        {
            Idtabtelemoveis = idtelemoveis;
            MarcaTele = marcaTele;
            Modelo = modelo;
            Tamanho = tamanho;
            Ano = ano;
            Preco = preco;
            Detalhes = detalhes;
            Imagem = imagem;
          
        }

        public Telemoveis(int value)
        {
            this.value = value;
        }
    }
}
