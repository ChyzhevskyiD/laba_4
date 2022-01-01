using System;
namespace Lab_4444
{
    class Chislo
    {
        public int chiseln { get; set; }
        public int znamen { get; set; }
        public int chiseln1 { get; set; }
        public int znamen1 { get; set; }
        public Chislo(int chiseln,int znamen, int chiseln1, int znamen1)
        {
            this.chiseln = chiseln;
            this.znamen = znamen;
            this.chiseln1 = chiseln1;
            this.znamen1 = znamen1;
        }
        public virtual void ToString()
        {
            Console.WriteLine("Дрiб має такий вигляд:" + "\r\n" + chiseln + "   " + chiseln1 + "\r\n" +"- ? -" + "\r\n" + znamen+"   "+znamen1);
        }
    }
    class Drib : Chislo
    {
        public string znak { get; set; }
        public int x1 { get; set; }
        public int y1 { get; set; }
        public int x2 { get; set; }
        public int y2 { get; set; }
        public int x3 { get; set; }
        public int y3 { get; set; }
        public Drib(int a, int b, int c, int d, string e) : base(a, b, c, d)
        {
            this.znak = e;
            this.x1 = a;
            this.y1 = b;
            this.x2 = c;
            this.y2 = d;
            this.x3 = 0;
            this.y3 = 0;
        }
        void Plus()
        {
            Console.WriteLine("Додавання: ");
            x3 = y1 * x2 + x1 * y2;
            y3 = y1 * y2;
            Console.WriteLine(x3 + "\r\n" + "--" + "\r\n" + y3);
        }
        void Minus()
        {
            Console.WriteLine("Вiднiмання: ");
            x3 = y1 * x2 - x1 * y2;
            y3 = y1 * y2;
            Console.WriteLine(x3 + "\r\n" + "--" + "\r\n" + y3);
        }
        void Mnozhennya()
        {
            Console.WriteLine("Множення: ");
            x3 = x2 * x1;
            y3 = y1 * y2;
            Console.WriteLine(x3 + "\r\n" + "--" + "\r\n" + y3);
        }
        void Dilenya()
        {
            Console.WriteLine("Дiлення: ");
            x3 = x1 * y2;
            y3 = y1 * x2;
            Console.WriteLine(x3 + "\r\n" + "--" + "\r\n" + y3);
        }
        public override void ToString()
        {
          switch(znak)
          {
                case "+":
                    Plus();
                    break;
                case "-":
                    Minus();
                    break;
                case "*":
                    Mnozhennya();
                    break;
                case "/":
                    Dilenya();
                    break;
                case "all":
                    Plus();
                    Minus();
                    Mnozhennya();
                    Dilenya();
                    break;
            }
        }
    }
   
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введiть чисельник: ");
            int chiseln = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введiть знаменик: ");
            int znamen = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введiть чисельник: ");
            int chiseln1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введiть знаменик: ");
            int znamen1 = Convert.ToInt32(Console.ReadLine());
            Chislo q = new Chislo(chiseln, znamen, chiseln1, znamen1);
            q.ToString();
            Console.Write("Введiть дiю замiсть ?: ");
            string znak = Console.ReadLine();
            Drib s = new Drib(chiseln, znamen, chiseln1, znamen1,znak);
            s.ToString();
        }
    }
}
