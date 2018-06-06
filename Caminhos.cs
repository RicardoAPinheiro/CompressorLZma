
namespace My7zip
{
    class Caminhos : IDirFile
    {
        private string _Diretorio, _Ficheiro;

        public string diretorio
        {
            set
            {
                _Diretorio = value;
            }
            get
            {
                if (string.IsNullOrEmpty(_Diretorio))
                {
                    return dirDefeito;
                }
                else
                {
                    return _Diretorio;
                }
            }
        }

        public string ficheiro
        {
            set
            {
                _Ficheiro = value;
            }
            get
            {
                if (string.IsNullOrEmpty(_Ficheiro))
                {
                    return fileDefeito;
                }
                else
                {
                    return _Ficheiro;
                }
            }
        }

        public string dirDefeito
        {
            get
            {
                return diretorioDefeito(_Ficheiro);
            }
        }

        public string fileDefeito
        {
            get
            {
                return caminhoFicheiroDefeito(_Diretorio);
            }
        }

        public Caminhos()
        {

        }

        private string diretorioDefeito(string file)
        {
            //Retorna caminho para descomprimir para um diretorio por defeito (diretorio onde se encontra o ficheiro)

            int ultimoDiretorio = file.LastIndexOf('\\');
            string dir = file.Substring(0, ultimoDiretorio);
            return dir;
        }

        private string caminhoFicheiroDefeito(string dir)
        {
            // Retorna um nome por defeito para o ficheiro comprimido (nome do diretorio a ser comprimido)

            int tamanhoCaminho = dir.Length;
            int ultimoDiretorio = dir.LastIndexOf('\\');
            int tamanhoNomeFicheiro = tamanhoCaminho - ultimoDiretorio;
            string diretorioRaiz = dir.Substring(0, ultimoDiretorio);
            string file = diretorioRaiz + dir.Substring(ultimoDiretorio, tamanhoNomeFicheiro) + ".7z";
            return file;
        }
    }
}
