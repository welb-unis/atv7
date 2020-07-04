using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;
using MODELO;
using MySql.Data.MySqlClient;

namespace PadraoDeProjetoEmCamadas
{
    public partial class frmEleicao : PadraoDeProjetoEmCamadas.frmModeloDeCadastro
    {
        public frmEleicao()
        {
            InitializeComponent();
        }

        private void btn_inserir_Click(object sender, EventArgs e)
        {
            alterapropriedades(2);
        }
        
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            FRMLocalizarEleicao f = new FRMLocalizarEleicao();
            f.ShowDialog();

            popularcampos(f.modeleleicao);

            alterapropriedades(3);
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            try
            {

                DadosDaConexao dc = new DadosDaConexao();
                DALConexao cx = new DALConexao(dc.StringDeConexao);

                BLLEleicao blleleicao = new BLLEleicao(cx);

                MODELOEleicao p = new MODELOEleicao();
                //p.IdEmpresa = textBox_IDEmpresa.Text;
                p.NomeUrna = textBox_Nome.Text;
                p.Descricao = textBox_Descricao.Text;

                switch (comboBox_TipoVoto.SelectedItem.ToString())
                {
                    case "Secreto":
                        p.Voto = "S";
                        break;
                    case "Publico":
                        p.Voto = "P";
                        break;
                }
                p.DataInicioEleicao = new DateTime(dateTimePicker_Inicio.Value.Year,
                    dateTimePicker_Inicio.Value.Month,
                    dateTimePicker_Inicio.Value.Day);
                p.DataFimEleicao = new DateTime(dateTimePicker_Fim.Value.Year,
                    dateTimePicker_Fim.Value.Month,
                    dateTimePicker_Fim.Value.Day);

                blleleicao.Alterar(p);
                textBox_IDUrna.Text = p.IdUrna.ToString(); ;
                MessageBox.Show("Usuario inserido com sucesso id:" + p.IdUrna);

                limparcampos();
                alterapropriedades(1);

            }
            catch (MySqlException ex)
            {
                if (ex.Message.Contains("Duplicate"))
                {
                    MessageBox.Show("Registro já existe no banco de dados");
                }
                else
                {
                    MessageBox.Show("Falha ao alterar errro:" + ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao alterar errro geral:" + ex.Message);
            }
        }

        private void btn_deletar_Click(object sender, EventArgs e)
        {
            try
            {
                DadosDaConexao dc = new DadosDaConexao();
                DALConexao cx = new DALConexao(dc.StringDeConexao);

                BLLEleicao blleleicao = new BLLEleicao(cx);

                blleleicao.Excluir(Convert.ToInt32(textBox_IDUrna.Text));
                MessageBox.Show("Usuario excluido com sucesso.");

                limparcampos();
                alterapropriedades(1);

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Falha ao excluir erro:" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao excluir erro geral:" + ex.Message);
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            limparcampos();
            alterapropriedades(1);
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {

            try
            {
                DadosDaConexao dc = new DadosDaConexao();
                DALConexao cx = new DALConexao(dc.StringDeConexao);

                BLLEleicao blleleicao = new BLLEleicao(cx);

                MODELOEleicao p = new MODELOEleicao();
                //p.IdEmpresa = textBox_IDEmpresa.Text;
                p.NomeUrna = textBox_IDUrna.Text;
                p.Descricao = textBox_Descricao.Text;

                switch (comboBox_TipoVoto.SelectedItem.ToString())
                {
                    case "Secreto":
                        p.Voto = "S";
                        break;
                    case "Publico":
                        p.Voto = "P";
                        break;
                }                
                p.DataInicioEleicao = new DateTime(dateTimePicker_Inicio.Value.Year,
                    dateTimePicker_Inicio.Value.Month,
                    dateTimePicker_Inicio.Value.Day);
                p.DataFimEleicao = new DateTime(dateTimePicker_Fim.Value.Year,
                    dateTimePicker_Fim.Value.Month,
                    dateTimePicker_Fim.Value.Day);

                blleleicao.Incluir(p);
                textBox_IDUrna.Text = p.IdUrna.ToString(); ;
                MessageBox.Show("Usuario inserido com sucesso id:" + p.IdUrna);

                limparcampos();
                alterapropriedades(1);

            }
            catch (MySqlException ex)
            {
                if (ex.Message.Contains("Duplicate"))
                {
                    MessageBox.Show("Registro j'a existe no banco de dados");
                }
                else
                {
                    MessageBox.Show("Falha ao inserir erro:" + ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao inserir errro geral:" + ex.Message);
            }

        }

        public void limparcampos()
        {
            textBox_Descricao.Clear();
            textBox_IDEmpresa.Clear();
            textBox_IDUrna.Clear();
            textBox_Nome.Clear();

        }

        private void popularcampos(MODELOEleicao p)
        {
            if (p != null)
            {
                textBox_Descricao.Text = p.Descricao;
                textBox_IDEmpresa.Text = Convert.ToString(p.IdEmpresa);
                textBox_IDUrna.Text = Convert.ToString(p.IdUrna);
                textBox_Nome.Text = p.NomeUrna;
                dateTimePicker_Inicio.Text = Convert.ToString(p.DataInicioEleicao);
                dateTimePicker_Fim.Text = Convert.ToString(p.DataFimEleicao);

                switch (p.Voto)
                {
                    case "S":
                        comboBox_TipoVoto.SelectedItem = "Secreto";
                        break;
                    case "P":
                        comboBox_TipoVoto.SelectedItem = "Publico";
                        break;
                }
            }

            
        }
    }
}
