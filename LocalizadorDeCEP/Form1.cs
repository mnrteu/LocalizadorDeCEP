using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace LocalizadorDeCEP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string cep = txbCEP.Text.Replace("-", "").Replace(" ","");
            string url = $"https://viacep.com.br/ws/{cep}/json/";
            if (cep.Length < 8)
            {
                MessageBox.Show("CEP inválido!","Erro!",
                    MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                // Limitar a utilização do webclient dentro do escopo:
                using(WebClient navegador = new WebClient())
                {
                    string conteudo = navegador.DownloadString(url);
                    // Converter para UTF-8 (corrigir a acentuação)
                    conteudo = Encoding.UTF8.GetString(Encoding.Default.GetBytes(conteudo));
                    // Instanciar um obj do tipo Endereco
                    Endereco endereco = new Endereco();

                    endereco = JsonConvert.DeserializeObject<Endereco>(conteudo);

                    // Verificar se endereco.Cep não é nulo:
                    if (!string.IsNullOrEmpty(endereco.Cep))
                    {
                        // Popular os campos:
                        lblCEP.Text = $"CEP:{endereco.Cep}";
                        lblBairro.Text = $"Bairro: {endereco.Bairro}";
                        lblComplemento.Text = $"Complemento: {endereco.Complemento}";
                        lblDDD.Text = $"DDD: {endereco.Ddd}";
                        lblEstado.Text = $"Estado: {endereco.Estado}";
                        lblLocalidade.Text = $"Localidade: {endereco.Localidade}";
                        lbllogradouro.Text = $"Logradouro: {endereco.Logradouro}";
                        lblRegiao.Text = $"Região: {endereco.Regiao}";
                        lblUF.Text = $"UF: {endereco.Uf}";
                        lblUnidade.Text = $"Unidade: {endereco.Unidade}";
                    }
                    else
                    {
                        MessageBox.Show("CEP não encontrado!");
                    }
                }
            }
        }
    }
}
