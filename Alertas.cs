using System;
using System.Windows.Forms;

namespace My7zip
{
    class Alertas: IAlertas
    {
       public Alertas()
        {
        }

        public void fimDescompressão(object sender, EventArgs e)
        {
            //Alerta fim de compressão

            string mensagem = string.Format("Fim da descompressão");
            MessageBox.Show(mensagem, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }

        public void fimCompressão(object sender, EventArgs e)
        {
            //Alerta fim de descompressão

            string mensagem = string.Format("Fim da compressão");
            MessageBox.Show(mensagem, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }

        public void ficheiroRepetido(object sender, EventArgs e)
        {
            //Alerta de ficheiro repetido no diretório para onde vai ser descomprimido

            string mensagem = string.Format("Ficheiro repetido, o ficheiro será substituido");
            MessageBox.Show(mensagem, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }
    }
}
