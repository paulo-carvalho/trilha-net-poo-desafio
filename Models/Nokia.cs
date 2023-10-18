namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
            
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            try {
                throw new InvalidOperationException();
            } catch (InvalidOperationException) {
                Console.WriteLine($"Modelos Nokia nao recebem mais suporte da loja para o aplicativo {nomeApp}");
            }
        }
    }
}