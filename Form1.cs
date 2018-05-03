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
        Controler control = new Controler();

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
          
            control.Onsair(new EventoSair());
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
            
            control.Onsair(new EventoSair());
        }

        private void bt_Descomprimir_Click(object sender, EventArgs e)
        {

            descompComp descomp = new descompComp(control.descomprimir);
            descomp.Invoke(tb_Ficheiro.Text, tb_CaminhoDir.Text);
        }

        private void bt_Comprimir_Click(object sender, EventArgs e)
        {

            descompComp comp = new descompComp(control.comprimir);
            comp.Invoke(tb_FicheiroComp.Text, tb_DirComp.Text);
        }

       
    }
}
