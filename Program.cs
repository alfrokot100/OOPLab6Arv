using System.Runtime.CompilerServices;

namespace Lab6Arv
{
     class Animal //Skapar klassen animal
    {
        public int _age;
        public string _color;
        public string _country;
        public string _food;
        public string _nickname;

        //Skapar konstruktorn animal med default värden
        public Animal(int age = 11, string color = "Oändlig",
            string country = "Världen", string food = "Allt", string nickname = "Odjuret")
        {
            this._age = age;
            this._color = color;
            this._country = country;
            this._food = food;
            this._nickname = nickname;
        }

        public virtual void makeSound() 
        {
            Console.WriteLine("Djuret gör ett ljud");
        }
       public virtual void  favFood()
        {
            Console.WriteLine("Jag äter " + _food);
        }
        public virtual void Country()
        {
            Console.WriteLine("Jag bor i " + _country);
        }
    }

    class Dog : Animal
    {
        public string _isTrained;
        public Dog(int age = 9, string color = "Rosa", string country = "Dominikanska Republicken",
            string food = "Kött", string nickname = "Rex", string isTrained = "Ja")
       : base(age, color, country, food, nickname) // Anropar basklassens konstruktor
        {
            this._isTrained = isTrained; 
        }
        public override void makeSound()
        {
            Console.WriteLine("Woof!");
        }

        public virtual void Trained()//Ny metod
        {
            Console.WriteLine("Är hunden tränad? {0}", _isTrained);
        }
    }

    class Pitbull : Dog //Hunden pitbull som ärver från Dog
    {
        public string _size;
        public Pitbull(string size = "Medium")
        {
            this._size = size;
            this._isTrained = "Ja";
        }
        public override void Trained()
        {
            Console.WriteLine("Är hunden tränad? {0}", _isTrained);
        }

        public void Size()//Ny metod
        {
            Console.WriteLine("Hundends storlek är {0}", _size);
        }
    }

    class Rottweiler : Dog
    {
        public int _age;

        public Rottweiler(int age = 9)
        {
            this._age = age;
            this._isTrained = "Nej";
        }

        public override void Trained()
        {
            Console.WriteLine("Är hunden tränad? {0}", _isTrained);
        }

        public void Age()//Ny metod
        {
            Console.WriteLine("Denna hund är {0} år gammal", _age);
        }
    }
    
    class Lion : Animal
    {
        public string isMale;
        public int prideSize;
        
        public Lion(int age = 4, string color = "Guld", string country = "Zanzi",
            string food = "Allt", string nickname = "King",string isMale = "Man", int prideSize = 23 )
      : base(age, color, country, food, nickname) // Anropar basklassens konstruktor
        {
            this.isMale = isMale;
            this.prideSize = prideSize;
        }
        
        public override void makeSound()
        {
            Console.WriteLine("Rawrrr");
        }

        public void MaleOrNo() //Ny metod
        {
            Console.WriteLine("Är lejonet en man eller kvinna? {0}", isMale);
        }
    }
    class Zebra : Animal
    {
        public string isWild;

        public Zebra(int age = 5 , string color = "Black and white", string country = "Sydafrika",
            string food = "Gräs", string nickname = "Flash", string isWild = "Yes")
      : base(age, color, country, food, nickname) // Anropar basklassens konstruktor
        {
            this.isWild = isWild;
        }
        public override void makeSound()
        {
            Console.WriteLine("Pruuu");
        }
        public void Wild()//Ny metod
        {
            Console.WriteLine("Är djuret en fara för andra människor? {0}", isWild);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            Lion lion = new Lion();
            Zebra zebra = new Zebra();
            Pitbull p = new Pitbull();
            Rottweiler r = new Rottweiler();

            p.Country();
            p.Trained();
            p.Size();

            r.Trained();
            r.Age();
            
            zebra.makeSound();
            lion.makeSound();
            dog.makeSound();

        }
    }
}
