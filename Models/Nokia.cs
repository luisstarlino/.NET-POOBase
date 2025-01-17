namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string number, string imei, int memory) : base(number, imei, memory, "Nokia")
        {

        }

        public override void InstallApp(string appName)
        {
            Console.WriteLine($"Installing app {appName} on Nokia..");
        }
    }
}