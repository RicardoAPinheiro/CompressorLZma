using System;
using System.Windows.Forms;

namespace My7zip
{
    class Controller: IController
    {
        
        public Controller()
        {

        }

        public void descomprimir(string ficheiro, string dir)
        {
            IModel descomp = new Model();
            descomp.descomprime(ficheiro, dir);           
        }

        public void comprimir(string ficheiro, string dir)
        {
            IModel comp = new Model();
            comp.comprime(ficheiro, dir);            
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
        Controller saiForm = new Controller();
        public EventoSair()
        {
            saiForm.sair();
        }
    }

    #endregion
}
