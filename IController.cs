
namespace My7zip
{
    interface IController
    {
        event EventHandler sai;
        void descomprimir(string ficheiro, string dir);
        void comprimir(string ficheiro, string dir);
        void OnSair(EventoSair e);
    }
}
