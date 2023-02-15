using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    #region 1
    public class Money
    {
        public string Currency { get; set; }
        public int Bills { get; set; }
        public double Coins { get; set; }
        public double Amount { get; set; }
        public Money() { }
        public Money(string c, int b, double cs, double a)
        { Currency = c; Bills = b; Coins = cs; Amount = a; }
        public void Sum()
        {
            Amount = Bills + Coins;
        }
        public void Print()
        {
            Console.WriteLine($"Currency: {Currency} | Amount: {Amount}");
        }
    }
    public class Product : Money
    {
        string Name { get; set; }
        double Price { get; set; }
        public Product() { }
        public Product(string c, int b, double cs, double a, string N, double P) : base(c, b, cs, a)
        { Currency = c; Bills = b; Coins = cs; Amount = a; Name = N; Price = P; }
        public void Sale(double SaleNum)
        {
            double NewPrice = Price - SaleNum;
            Console.WriteLine($"Name: {Name} | Old price: {Price} | New price: {NewPrice}");
        }
    }
    #endregion


    //--------------------

    #region 2
    class Device
    {
        public string Name { get; set; }
        public string Sound { get; set; }
        public int Price { get; set; }
        public Device() { }
        public Device(string N, string S, int P) { Name = N; Sound = S; Price = P; }
        public void Show()
        {
            Console.WriteLine(Name);
        }
        public void SoundF()
        {
            Console.WriteLine(Sound);
        }
        public void Desc()
        {
            Console.WriteLine(Price);
        }
    }
    class Kettle : Device
    {
        public Kettle() { }
        public Kettle(string N, string S, int P) : base(N, S, P) { Name = N; Sound = S; Price = P; }
        new public void Show()
        {
            Console.WriteLine(Name);
        }
        new public void SoundF()
        {
            Console.WriteLine(Sound);
        }
        new public void Desc()
        {
            Console.WriteLine(Price);
        }
    }
    class Microwave : Device
    {
        public Microwave() { }
        public Microwave(string N, string S, int P) : base(N, S, P)
        { Name = N; Sound = S; Price = P; }
        new public void Show()
        {
            Console.WriteLine(Name);
        }
        new public void SoundF()
        {
            Console.WriteLine(Sound);
        }
        new public void Desc()
        {
            Console.WriteLine(Price);
        }
    }
    class Car : Device
    {
        public Car() { }
        public Car(string N, string S, int P) : base(N, S, P) { Name = N; Sound = S; Price = P; }
        new public void Show()
        {
            Console.WriteLine(Name);
        }
        new public void SoundF()
        {
            Console.WriteLine(Sound);
        }
        new public void Desc()
        {
            Console.WriteLine(Price);
        }
    }
    #endregion

    //-----------------------------

    #region 3
    class MusicalInstrument
    {
        public string Name { get; set; }
        public string Sound { get; set; }
        public int Price { get; set; }
        public MusicalInstrument() { }
        public MusicalInstrument(string N, string S, int P)
        { Name = N; Sound = S; Price = P; }
        public void Show()
        {
            Console.WriteLine(Name);
        }
        public void SoundF()
        {
            Console.WriteLine(Sound);
        }
        public void Desc()
        {
            Console.WriteLine(Price);
        }
    }
    class Violin : MusicalInstrument
    {
        public Violin() { }
        public Violin(string N, string S, int P) : base(N, S, P)
        { Name = N; Sound = S; Price = P; }
        new public void Show()
        {
            Console.WriteLine(Name);
        }
        new public void SoundF()
        {
            Console.WriteLine(Sound);
        }
        new public void Desc()
        {
            Console.WriteLine(Price);
        }
    }
     class Trombone : MusicalInstrument
    {
        public Trombone() { }
        public Trombone(string N, string S, int P) : base(N, S, P)
        { Name = N; Sound = S; Price = P; }
        new public void Show()
        {
            Console.WriteLine(Name);
        }
        new public void SoundF()
        {
            Console.WriteLine(Sound);
        }
        new public void Desc()
        {
            Console.WriteLine(Price);
        }
    }
    class Ukulele : MusicalInstrument
    {
        public Ukulele() { }
        public Ukulele(string N, string S, int P) : base(N, S, P)
        { Name = N; Sound = S; Price = P; }
        new public void Show()
        {
            Console.WriteLine(Name);
        }
        new public void SoundF()
        {
            Console.WriteLine(Sound);
        }
        new public void Desc()
        {
            Console.WriteLine(Price);
        }
    }
    #endregion

    //----------------------------

    #region 4
    abstract class Worker
    {
        public Worker() { }
        abstract public void Print();
    }
    class President : Worker
    {
        public President() { }
        public override void Print()
        {
            Console.WriteLine("I'm president");
        }
    }
    class Security : Worker
    {
        public Security() { }
        public override void Print()
        {
            Console.WriteLine("I'm security");
        }
    }
    class Manager : Worker
    {
        public Manager() { }
        public override void Print()
        {
            Console.WriteLine("I'm manager");
        }
    }
    class Engineer : Worker
    {
        public Engineer() { }
        public override void Print()
        {
            Console.WriteLine("I'm enfineer");
        }
    }
    #endregion


    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
