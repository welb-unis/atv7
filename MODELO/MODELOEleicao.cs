using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class MODELOEleicao
    {
        /*Atributos da tabela Pessoa*/
        private Int32 idUrna;
        private Int32 idEmpresa;
        private string nomeUrna;
        private DateTime dataInicioEleicao;
        private DateTime dataFimEleicao;
        private string descricao;
        private string voto;

        public int IdUrna
        {
            get
            {
                return idUrna;
            }

            set
            {
                idUrna = value;
            }
        }

        public int IdEmpresa
        {
            get
            {
                return idEmpresa;
            }

            set
            {
                idEmpresa = value;
            }
        }

        public string NomeUrna
        {
            get
            {
                return nomeUrna;
            }

            set
            {
                nomeUrna = value;
            }
        }

        public DateTime DataInicioEleicao
        {
            get
            {
                return dataInicioEleicao;
            }

            set
            {
                dataInicioEleicao = value;
            }
        }

        public DateTime DataFimEleicao
        {
            get
            {
                return dataFimEleicao;
            }

            set
            {
                dataFimEleicao = value;
            }
        }

        public string Descricao
        {
            get
            {
                return descricao;
            }

            set
            {
                descricao = value;
            }
        }

        public string Voto
        {
            get
            {
                return voto;
            }

            set
            {
                voto = value;
            }
        }

    }
}
