using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlocoDeNotas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        //Método de nome gravarArquivo, recebe dois parâmetros: 1º: caminho onde está o arquivo
        //2º: conteúdo a ser escrito no arquivo
        //Método não retorna nada
        private void gravarArquivo(String caminho, String conteudo)
        {
            //Declaração e instância do objeto escritor (cria a ponte de escrita, entre nosso aplicativo e o arquivo
            //Para sua instância foi fornecido para o StreamWriter o caminho onde se encontra o arquivo
            StreamWriter escritor = new StreamWriter(caminho);

            //O objeto escritor, que provém da classe StreamWriter (declarado acima), irá escrever
            //No arquivo que possuí o caminho informado, o conteúdo passado por parâmetro
            escritor.Write(conteudo);

            //Fechamos a conexão com a ponte de escrita entre nossa aplicação e o arquivo
            escritor.Close();
        }

        //Método chamado lerArquivo, que recebe como parâmetro um String chamado caminho, que representa o caminho onde se encontra o arquivo que dejeso ler dentro do computador
        //Método retorna um String que contem justamente o conteúdo do nosso arquivo
        private String lerArquivo(String caminho)
        {
            //Validar se de fato o caminho fornecido é válido, ou seja, se existe um arquivo no caminho fornecido
            if (!File.Exists(caminho))
            {
                //Caso não exista esse arquivo (ESTAMOS NEGANDO A NOSSA CONDIÇÃO DE EXISTENCIA NO IF), lançamos uma instância da classe Exception, indicando que temos algo errado acontecendo
                throw new Exception("O arquivo não existe!");
            }

            //Declarando a variavel que receberá o conteúdo do arquivo (por enquanto, ela não vale nada)
            String conteudoDoArquivo;

            //Declaração e a instância do objeto leitor, este por sua vez abre uma ponte de leitura entre a nossa aplicação e o arquivo dejesado (aquele que contém o caminho informado)
            StreamReader leitor = new StreamReader(caminho);

            //Atribuimos à variável conteudoDoArquivo o resultado da execução da leitura TOTAL deste arquivo, através do método ReadToEnd, pertencente a classe StreamReader, aqui representada pelo objeto leitor
            conteudoDoArquivo = leitor.ReadToEnd();


            //Fechamos a ponte de leitura entre a nossa aplicação e também o nosso arquivo
            leitor.Close();

            //Retornamos o conteúdo do arquivo, para que ele possa ser usado por quem chamou este método
            return conteudoDoArquivo;
        }

        //Bloco de código responsável pelo Click no menu na opção Salvar
        private void salvarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Verifica se o saveDialog (caixa de salvar) teve o botão OK pressionado, indicando que o usuário confirmou que deseja salvar o arquivo
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                String caminho;

                caminho = saveDialog.FileName; //obtenção do caminho de onde o usuário deseja salvar o arquivo

                gravarArquivo(@caminho, txtTexto.Text); //chamada da função (função = bloco de código) para salvar o arquivo no caminho indicado
            }
        }

        //Bloco de código responsável pelo Click no menu na opção Abrir
        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Verifica se a openDialog (caixa de abrir arquivos) teve o botão OK pressionado, indicando que o usuário confirmou que deseja abrir o arquivo
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                String caminho;

                caminho = openDialog.FileName; //obtenção do caminho do arquivo

                txtTexto.Text = lerArquivo(caminho); //chamada da função (função = bloco de código) para ler o arquivo no caminho selecionado
            }
        }

        //Bloco de código responsável pelo Click no menu na opção Fonte
        private void fonteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Tenta fazer a seleção da fonte
            try
            {
                //Utiliza o componente fontDialog para obter a Font (fonte), e atribuíla ao TextBox TxtTexto
                if (fontDialog.ShowDialog() == DialogResult.OK)
                {
                    txtTexto.Font = fontDialog.Font;
                }
            }
            catch (Exception ex)
            {
                //Caso ocorra erro, o tratamento deve acontecer aqui
            }
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtTexto.Text = String.Empty;
            //OU
            txtTexto.Clear();
        }

        private void desfazerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtTexto.Undo();  //Desfaz a digitação feita no TextBox txtTexto
        }

        private void recortarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtTexto.Cut();  //Recorta o conteúdo do TextBox txtTexto
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtTexto.Copy(); //Copia o conteúdo do TextBox txtTexto
        }

        private void colarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtTexto.Paste(); //Cola o conteúdo que está na área de transferencia no TextBox txtTexto
        }

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtTexto.Clear(); //Kimpa o TextBox txtTexto
        }

        private void selecionarTudoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtTexto.SelectAll(); //Seleciona todo o conteúdo do TextBox txtTexto
        }

        private void horaDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtTexto.Text = txtTexto.Text + DateTime.Now.ToString(); //Incrementa ao conteúdo atual do TextBox txtTexto a Data e Hora do momento
        }

        private void sobreOBlocoDeNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Desenvolvido para a disciplina de DSC"); //Exibe uma caixa de mensagem contendo o SOBRE da aplicação
        }
    }
}
