using System;
using System.Windows.Forms;
using System.Threading;

namespace My7zip
{
    public partial class My7zip : Form
    {
        IController control = new Controller();

        public My7zip()
        {
            InitializeComponent();
        }

        private void My7z_Load(object sender, EventArgs e)
        {

        }

        private void bt_Ficheiro_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                tb_Ficheiro.Text = openFileDialog1.FileName;
            }
        }

        private void bt_Diretorio_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                tb_CaminhoDir.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void bt_DirComp_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                tb_DirComp.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void bt_Sair_Click(object sender, EventArgs e)
        {
            control.Onsair(new EventoSair());
        }

        private void bt_SairComp_Click(object sender, EventArgs e)
        {
            control.Onsair(new EventoSair());
        }

        private void bt_Descomprimir_Click(object sender, EventArgs e)
        {
            IDirFile caminho = new Caminhos
            {
                diretorio = tb_CaminhoDir.Text,
                ficheiro = tb_Ficheiro.Text
            };
            try
            {
                testarEntradaDescomp(caminho.ficheiro);
                verificaFicheiro(caminho.ficheiro);
                descompComp descomp = new descompComp(control.descomprimir);
                descomp.Invoke(caminho.ficheiro, caminho.diretorio);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nome de ficheiro a descomprimir em falta ou o ficheiro não é do tipo 7z", ex.ToString());
            }

        }

        private void bt_Comprimir_Click(object sender, EventArgs e)
        {
            IDirFile caminho = new Caminhos
            {
                diretorio = tb_DirComp.Text,
                ficheiro = tb_FicheiroComp.Text
            };
            try
            {
                backgroundWorker1.RunWorkerAsync();
                testarEntradaComp(caminho.diretorio);
                descompComp comp = new descompComp(control.comprimir);
                comp.Invoke(caminho.ficheiro, caminho.diretorio);
            }
            catch (Exception ex)
            {
                MessageBox.Show("O nome do diretório a comprimir não pode estar vazio", ex.ToString());
            }
        }

        #region stausbar


        private int progress = 0;
        public int getPercentagem;

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            
            while (progress < 100)
            {
                Thread.Sleep(1000);
                this.backgroundWorker1.ReportProgress(getPercentagem);
                progress += getPercentagem;
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            pb_Compress.Increment(e.ProgressPercentage);
            
        }
    
        #endregion

        #region testaEntrada 

        private void testarEntradaDescomp(string ficheiro)
        //Verifica se o nome do ficheiro a descomprimir está preenchido.

        {
            if (string.IsNullOrEmpty(ficheiro))
            {
                throw new System.IO.FileNotFoundException();
            }
        }

        private void verificaFicheiro(string ficheiro)
        //Verifica se o ficheiro é do tipo 7z

        {
            int ponto = ficheiro.LastIndexOf('.');
            string ext = ficheiro.Substring(ponto, 3);
            if (!ext.Equals(".7z") && !ext.Equals(".7Z"))
            {
                throw new System.IO.FileNotFoundException("Ficheiro incompativel");
            }
        }
        private void testarEntradaComp(string dir)
        //Verifica se o Diretório a comprimir está preenchido

        {
            if (string.IsNullOrEmpty(dir))
            {
                throw new System.IO.FileNotFoundException();
            }
        }
        #endregion

       
    }
}
