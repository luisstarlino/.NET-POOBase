namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Number { get; set; }
        private string Model { get; set; }
        private string IMEI { get; set; }
        private int Memory { get; set; }

        public Smartphone(string number, string imei, int memomy, string model)
        {
            Number = number;
            IMEI = imei;
            Memory = memomy;
            Model = model;
            // TODO: Passar os parâmetros do construtor para as propriedades
        }

        public void Call()
        {
            Console.WriteLine("Calling...");
        }

        public void ReceiveCall()
        {
            Console.WriteLine("Someone is call....");
        }

        public abstract void InstallApp(string nomeApp);

        public void ShowInfo()
        {
            Console.WriteLine();
            Console.WriteLine("📱 PHONE INFORMATIONS");
            Console.WriteLine($"⚫ Model: {Model}");
            Console.WriteLine($"⚫ Number: {Model}");
            Console.WriteLine($"⚫ IMEI: {IMEI}");
            Console.WriteLine($"⚫ Memory: {Memory}GB");
            Console.WriteLine();
        }
    }
}