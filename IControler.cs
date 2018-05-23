using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace My7zip
{
    interface IControler
    {
        event EventHandler sai;
        void descomprimir(string ficheiro, string dir);
        void comprimir(string ficheiro, string dir);
        void Onsair(EventoSair e);
    }
}
