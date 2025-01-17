namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string number, string imei, int memory) : base(number, imei, memory, "Iphone")
        {

        }

        public override void InstallApp(string appName)
        {
            Console.WriteLine($"Installing app {appName} on Iphone..");
        }
    }
}