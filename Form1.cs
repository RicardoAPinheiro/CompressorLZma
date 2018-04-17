using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My7zip
{
    public partial class My7zip : Form
    {
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

        private void bt_Sair_Click(object sender, EventArgs e)
        {
            sair();
        }

        private void bt_DirComp_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                tb_DirComp.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void bt_SairComp_Click(object sender, EventArgs e)
        {
            sair();
        }

        private void bt_Descomprimir_Click(object sender, EventArgs e)
        {
            Model descomp = new Model();
            try
            {
                descomp.descomprime(tb_Ficheiro.Text, tb_CaminhoDir.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show("O nome de ficheiro a descomprimir não pode estar vazio");
            }
        }

        private void bt_Comprimir_Click(object sender, EventArgs e)
        {
            Model comp = new Model();
            try
            {
                comp.comprime(tb_FicheiroComp.Text, tb_DirComp.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show("O nome do diretório a comprimir não pode estar vazio");
            }
        }

        private void sair()
        {
            DialogResult mensagem = MessageBox.Show("Deseja finalizar a aplicação?", "Encerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (mensagem == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
