using System;
using System.Reflection;

namespace ConsoleApplication
{
    class ClassRoom
    {
        Pupil[] pupils = new Pupil[4];
        public ClassRoom(Pupil A, Pupil B, Pupil C, Pupil D)
        {
            pupils[0] = A;
            pupils[1] = B;
            pupils[2] = C;
            pupils[3] = D;
        }
        public ClassRoom(Pupil A, Pupil B, Pupil C)
        {
            pupils[0] = A;
            pupils[1] = B;
            pupils[2] = C;
        }
        public ClassRoom(Pupil A, Pupil B)
        {
            pupils[0] = A;
            pupils[1] = B;
        }
        public void Print()
        {
            foreach (Pupil p in pupils)
            {
                Console.WriteLine($"Student number {Array.IndexOf(pupils, p)}");
                p.Study();
                p.Relax();
                p.Read();
                p.Write();
            }
        }
        public class Pupil
        {
            public virtual void Study()
            {

            }
            public virtual void Read()
            {
            }
            public virtual void Write()
            {
            }
            public virtual void Relax()
            {
            }
        }
        public class ExcelentPupil : Pupil
        {
            public override void Study()
            {
                Console.WriteLine($"Excelent study");
            }
            public override void Read()
            {
                Console.WriteLine($"Excelent read");
            }
            public override void Write()
            {
                Console.WriteLine($"Excelent write");
            }
            public override void Relax()
            {
                Console.WriteLine($"Bad relax");
            }
        }
        public class GoodPupil : Pupil
        {
            public override void Study()
            {
                Console.WriteLine($"Good study");
            }
            public override void Read()
            {
                Console.WriteLine($"Good read");
            }
            public override void Write()
            {
                Console.WriteLine($"Good write");
            }
            public override void Relax()
            {
                Console.WriteLine($"Good relax");
            }
        }
        public class BadPupil : Pupil
        {
            public override void Study()
            {
                Console.WriteLine($"Bad study");
            }
            public override void Read()
            {
                Console.WriteLine($"Bad read");
            }
            public override void Write()
            {
                Console.WriteLine($"Bad write");
            }
            public override void Relax()
            {
                Console.WriteLine($"Excelent relax");
            }
        }
        public class Vehicle
        {
            public int x, y, price, speed, year;

        }
        public class Plane : Vehicle
        {
            int z, passengers;
            public Plane(int x, int y, int z, int price, int speed, int year, int passengers)
            {
                this.x = x;
                this.y = y;
                this.z = z;
                this.price = price;
                this.speed = speed;
                this.year = year;
                this.passengers = passengers;
            }
            public void Set(int x, int y, int z, int price, int speed, int year, int passengers)
            {
                this.x = x;
                this.y = y;
                this.z = z;
                this.price = price;
                this.speed = speed;
                this.year = year;
                this.passengers = passengers;
            }
            public void Print()
            {
                Console.WriteLine($"X:{x} Y:{y} Z:{z}");
                Console.WriteLine($"Price:{price}");
                Console.WriteLine($"Speed:{speed}");
                Console.WriteLine($"Year:{year}");
                Console.WriteLine($"Passengers:{passengers}");
            }
        }
        public class Car : Vehicle
        {
            public Car(int x, int y, int price, int speed, int year)
            {
                this.x = x;
                this.y = y;
                this.price = price;
                this.speed = speed;
                this.year = year;
            }
            public void Set(int x, int y, int price, int speed, int year)
            {
                this.x = x;
                this.y = y;
                this.price = price;
                this.speed = speed;
                this.year = year;
            }
            public void Print()
            {
                Console.WriteLine($"X:{x} Y:{y}");
                Console.WriteLine($"Price:{price}");
                Console.WriteLine($"Speed:{speed}");
                Console.WriteLine($"Year:{year}");
            }
        }
        public class Ship : Vehicle
        {
            int passengers;
            string port;
            public Ship(int x, int y, int price, int speed, int year, int passengers, string port)
            {
                this.x = x;
                this.y = y;
                this.port = port;
                this.price = price;
                this.speed = speed;
                this.year = year;
                this.passengers = passengers;
            }
            public void Set(int x, int y, int price, int speed, int year, int passengers, string port)
            {
                this.x = x;
                this.y = y;
                this.port = port;
                this.price = price;
                this.speed = speed;
                this.year = year;
                this.passengers = passengers;
            }
            public void Print()
            {
                Console.WriteLine($"X:{x} Y:{y}");
                Console.WriteLine($"Price:{price}");
                Console.WriteLine($"Speed:{speed}");
                Console.WriteLine($"Year:{year}");
                Console.WriteLine($"Passengers:{passengers}");
                Console.WriteLine($"Port:{port}");
            }
        }
        public class DocumentWorker
        {
            public virtual void OpenDocument()
            { Console.WriteLine($"Document is opened"); }
            public virtual void EditDocument()
            { Console.WriteLine($"Editing available in PRO version"); }
            public virtual void SaveDocument()
            { Console.WriteLine($"Saving available in PRO version"); }
        }
        public class ProDocumentWorker : DocumentWorker
        {
            public override void OpenDocument()
            { Console.WriteLine($"Document is opened"); }
            public override void EditDocument()
            { Console.WriteLine($"Document is edited"); }
            public override void SaveDocument()
            { Console.WriteLine($"Document is saved in old format, saving in other formats available in Expert version"); }
        }
        public class ExpertDocumentWorker : DocumentWorker
        {
            public override void OpenDocument()
            { Console.WriteLine($"Document is opened"); }
            public override void EditDocument()
            { Console.WriteLine($"Document is edited"); }
            public override void SaveDocument()
            { Console.WriteLine($"Document is saved in new format"); }
        }
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Task 1:");
                Pupil p1 = new BadPupil();
                Pupil p2 = new GoodPupil();
                Pupil p3 = new ExcelentPupil();
                Pupil p4 = new BadPupil();
                ClassRoom c1 = new ClassRoom(p1, p2, p3, p4);
                c1.Print();
                Console.WriteLine("Task 2");
                Plane v1 = new Plane(100, 200, 300, 800000, 900, 1998,200);
                Car v2 = new Car(100, 100, 20000, 90, 2001);
                Ship v3 = new Ship(500, 600, 50000, 30, 1958, 50, "Moscow");
                v1.Print();
                v2.Print();
                v3.Print();
                Console.WriteLine("Task 3");
                string prokey = "1";
                string expertkey = "2";
                Console.WriteLine("Enter key: ");
                string key = Console.ReadLine();
                if (key == prokey)
                {
                    ProDocumentWorker d1 = new ProDocumentWorker();
                    d1.OpenDocument();
                    d1.EditDocument();
                    d1.SaveDocument();
                 }
                if (key == expertkey)
                {
                    ExpertDocumentWorker d2 = new ExpertDocumentWorker();
                    d2.OpenDocument();
                    d2.EditDocument();
                    d2.SaveDocument();
                }
                if ((key != prokey)&(key != expertkey))
                {
                    DocumentWorker d3 = new DocumentWorker();
                    d3.OpenDocument();
                    d3.EditDocument();
                    d3.SaveDocument();
                }
            }
        }
    }
}
