using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace My7zip
{
    class Controler
    {
        public Controler()
        {

        }

        public void descomprimir(string ficheiro, string dir)
        {
            Model descomp = new Model();
            try
            {
                testarEntradaDescomp(ficheiro);
                verificaFicheiro(ficheiro);
                descomp.descomprime(ficheiro, dir);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nome de ficheiro a descomprimir em falta ou o ficheiro não é do tipo 7z", ex.ToString());
            }
        }

        public void comprimir(string ficheiro, string dir)
        {
            Model comp = new Model();
            try
            {
                testarEntradaComp(dir);
                comp.comprime(ficheiro, dir);
            }
            catch (Exception ex)
            {
                MessageBox.Show("O nome do diretório a comprimir não pode estar vazio", ex.ToString());
            }
        }

        private void testarEntradaDescomp(string ficheiro)
        //Verifica se o nome do ficheiro a descomprimir está preenchido e se é um ficheiro 7z

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

        public void sair()
        {
            DialogResult mensagem = MessageBox.Show("Deseja finalizar a aplicação?", "Encerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (mensagem == System.Windows.Forms.DialogResult.Yes)
            {
                System.Windows.Forms.Application.Exit();
            }
        }

        public event EventHandler sai;

        public void Onsair(EventoSair e)
        {
            if (sai != null)
            {
                sai(this, e);
            }
        }
    }

    #region Delegados

    public delegate void descompComp(string ficheiro, string dir);
    public delegate void EventHandler(object sender, EventoSair e);

    public class EventoSair : EventArgs
    {
        Controler saiForm = new Controler();
        public EventoSair()
        {
            saiForm.sair();
        }
    }

    #endregion
}
