using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using MODELO;
using BLL;
using MySql.Data.MySqlClient;
using System.Data;

/* Business Logic Layer*/
namespace BLL
{
    public class BLLEleicao
    {
        private DALEleicao DALobj;

        public BLLEleicao(DALConexao cx)
        {
            DALobj = new DALEleicao(cx);
        }

        public void Incluir(MODELOEleicao modelo)
        {
            try
            {
                if (modelo.NomeUrna == "")
                {
                    throw new ArgumentNullException("Nome", "Nao pode ser vazio.");
                }
                if (modelo.Voto == "")
                {
                    throw new ArgumentNullException("Tipo do Voto", "Escolha seu tipo de voto");
                }                

                DALobj.Incluir(modelo);
            }
            catch (MySqlException e)
            {
                throw e;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Alterar(MODELOEleicao modelo)
        {
            try
            {                
                if (modelo.NomeUrna == "")
                {
                    throw new ArgumentNullException("Nome", "Nao pode ser vazio.");
                }
                if (modelo.Voto == "")
                {
                    throw new ArgumentNullException("Voto", "Escolha seu tipo de voto");
                }
                                
                DALobj.Alterar(modelo);
            }
            catch (MySqlException e)
            {
                throw e;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Excluir(int codigo)
        {
            if (codigo <= 0)
            {
                throw new ArgumentNullException("ID", "Para deletar código, não pode estar zerado!");
            }
            DALobj.Excluir(codigo);
        }

        public DataTable Localizar(string texto)
        {
            return DALobj.Localizar(texto);
        }
    }
}
