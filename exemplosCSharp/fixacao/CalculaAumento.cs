
namespace exemplosCSharp.fixacao
{
    internal class CalculaAumento
    {
        public static int CalcularAumento(int salario, int porcentagem)
        {
            return salario + (salario * porcentagem / 100);
        }
    }
}
