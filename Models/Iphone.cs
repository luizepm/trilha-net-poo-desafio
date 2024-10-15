namespace DesafioPOO.Models
{
        public class Iphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero,  modelo, imei, memoria)
        {
        }
        
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no Iphone");
        }
    }
}
