namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Abrindo a pagina do app {nomeApp} na loja App Store");
            Console.WriteLine($"Verificando pré-requisitos para o modelo {getModelo()}");
            Console.WriteLine($"Instalando aplicativo {nomeApp} no modelo iPhone {getModelo()}");
        }
    }
}