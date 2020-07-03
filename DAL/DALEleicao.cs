using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODELO;
using MySql.Data.MySqlClient;

namespace DAL
{
    public class DALEleicao
    {
        private DALConexao conexao;

        public DALEleicao(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(MODELOEleicao modelo)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = this.conexao.ObjetoConexao;
                cmd.CommandText = "INSERT INTO Eleicao (IDELEICAO, IDEMPRESA, NOME, DESCRICAO, TIPOVOTO, DATAINICIO, DATAFIM)" +
                    "VALUES (NULL,@idempresa, @nome, @desc, @tipovoto,@datainicio,@datafim);" +
                    "SELECT MAX(IDELEICAO) FROM Eleicao;";
                cmd.Parameters.AddWithValue("@nome", modelo.NomeUrna);
                cmd.Parameters.AddWithValue("@idempresa", modelo.IdEmpresa);
                cmd.Parameters.AddWithValue("@desc", modelo.Descricao);
                cmd.Parameters.AddWithValue("@tipovoto", modelo.Voto);
                cmd.Parameters.AddWithValue("@datainicio", modelo.DataInicioEleicao.ToString("yyyy-MM-dd HH:mm:ss"));
                cmd.Parameters.AddWithValue("@datafim", modelo.DataFimEleicao.ToString("yyyy-MM-dd HH:mm:ss"));

                conexao.Conectar();
                int idInserido = Convert.ToInt32(cmd.ExecuteScalar());
                modelo.IdUrna = idInserido;
            }
            catch (MySqlException e)
            {
                throw e;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                this.conexao.Desconectar();
            }

        }

        public void Alterar(MODELOEleicao modelo)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = this.conexao.ObjetoConexao;
                cmd.CommandText = " UPDATE Eleicao SET IDEMPRESA = @idempresa," +
                                  " NOME = @nome," +
                                  " DESCRICAO = @desc," +
                                  " TIPOVOTO = @tipovoto," +
                                  " DATAINICIO = @datainicio," +
                                  " DATAFIM = @datafim" +
                                  " WHERE " +
                                  " IDELEICAO = @id";

                cmd.Parameters.AddWithValue("@nome", modelo.NomeUrna);
                cmd.Parameters.AddWithValue("@idempresa", modelo.IdEmpresa);
                cmd.Parameters.AddWithValue("@id", modelo.IdUrna);
                cmd.Parameters.AddWithValue("@desc", modelo.Descricao);
                cmd.Parameters.AddWithValue("@tipovoto", modelo.Voto);
                cmd.Parameters.AddWithValue("@datainicio", modelo.DataInicioEleicao);
                cmd.Parameters.AddWithValue("@datafim", modelo.DataFimEleicao);

                this.conexao.Conectar();
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException e)
            {
                throw e;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                this.conexao.Desconectar();
            }
        }

        public void Excluir(int codigo)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = this.conexao.ObjetoConexao;

                cmd.CommandText = "DELETE FROM Eleicao WHERE IDELEICAO = @id";
                cmd.Parameters.AddWithValue("@id", codigo);
                this.conexao.Conectar();
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException e)
            {
                throw e;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                this.conexao.Desconectar();
            }
        }

        public DataTable Localizar(string texto)
        {
            DataTable tabela = new DataTable();
            string SQL = "SELECT * FROM Eleicao WHERE nome LIKE '%" + texto + "%'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(SQL, this.conexao.ObjetoConexao);
            adapter.Fill(tabela);

            return tabela;
        }
    }







}

