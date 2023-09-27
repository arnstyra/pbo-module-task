using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

//Vga
class Vga
{
    public string merk;

    public Vga(string merk)
    {
        this.merk = merk;
    }
}

class Nvidia : Vga
{
    public Nvidia(string merk) : base(merk)
    {
        merk = "Nvidia";
    }
}

class Amd : Vga
{
    public Amd(string merk) : base(merk)
    {
        merk = "AMD";
    }

}


//PROCESSOR
class Processor
{
    public string merk;
    public string tipe;

    public Processor(string merk, string tipe)
    {
        this.merk = merk;
    }

}

class Intel : Processor
{
    public Intel(string tipe) : base("Intel", tipe)
    {
        this.tipe = tipe;
    }


}

class Corei3 : Intel
{
    public Corei3(string tipe) : base(tipe)
    {
        tipe = "Core i3";
    }

}
class Corei5 : Intel
{
    public Corei5(string tipe) : base(tipe)
    {
        tipe = "Core i5";
    }
}

class Corei7 : Intel
{
    public Corei7(string tipe) : base(tipe)
    {
        tipe = "Core i7";
    }
}

class AMD : Processor
{

    public AMD(string tipe) : base("AMD", tipe)
    {
        this.tipe = tipe;
    }
}
class Ryzen : AMD
{
    public Ryzen(string tipe) : base(tipe)
    {
        tipe = "RAYZEN";
    }
}
class Athlon : AMD
{
    public Athlon(string tipe) : base(tipe)
    {
        tipe = "ATHLON";
    }
}


//LAPTOP
class Laptop
{
    public string merk;
    public string tipe;
    public Vga vga;
    public Processor processor;

    public Laptop(string merk, string tipe, Vga vga, Processor processor)
    {
        this.merk = merk;
        this.tipe = tipe;
        this.vga = vga;
        this.processor = processor;
    }

    public void LaptopDinyalakan()
    {
        Console.WriteLine("Laptop "+this.merk +this.tipe + " menyala");
    }
    public void LaptopDimatikan()
    {
        Console.WriteLine("Laptop "+this.merk + this.tipe + " mati" );
    }
}

class ASUS : Laptop
{
    public ASUS(string tipe, Vga vga, Processor processor) : base("ASUS", tipe, vga, processor)
    {
        this.tipe = tipe;
        this.vga = vga;
        this.processor = processor;
    }
}

class ROG : ASUS
{
    public ROG(Vga vga, Processor processor) : base("ROG", vga, processor)
    {
        this.vga = vga;
        this.processor = processor;
    }
}

class Vivobook : ASUS
{
    public Vivobook(Vga vga, Processor processor) : base("Vivobook", vga, processor)
    {
        this.vga = vga;
        this.processor = processor;
    }
    public void Ngoding()
    {
        Console.WriteLine("Ctak Ctak Ctak, error lagi !");
    }
}

class ACER : Laptop
{
    public ACER(string tipe, Vga vga, Processor processor) : base("ACER", tipe, vga, processor)
    {
        this.tipe = tipe;
        this.vga = vga;
        this.processor = processor;
    }

}

class Swift : ACER
{
    public Swift(Vga vga, Processor processor) : base("Swift", vga, processor)
    {
        this.vga = vga;
        this.processor = processor;
    }
}

class Predator : ACER
{
    public Predator(Vga vga, Processor processor) : base("Predator", vga, processor)
    {
        this.vga = vga;
        this.processor = processor;
    }

    public void BermainGame()
    {
        Console.WriteLine("Laptop "+this.merk+ " "+this.tipe+" sedang memainkan game");
    }
}

class Lenovo : Laptop
{
    public Lenovo(string tipe, Vga vga, Processor processor) : base("Lenovo", tipe, vga, processor)
    {
        this.tipe = tipe;
        this.vga = vga;
        this.processor = processor;

    }
}
class IdeaPad : Lenovo
{
    public IdeaPad(Vga vga, Processor processor) : base("IdeaPad", vga, processor)
    {
        this.vga = vga;
        this.processor = processor;
    }
}

class Legion : Lenovo
{
    public Legion(Vga vga, Processor processor) : base("Legion", vga, processor)
    {
        this.vga = vga;
        this.processor = processor;
    }
}

class Program
{
    static void Main(string[] args)
    {

        //Vga
        Nvidia nvdia = new Nvidia("Nvidia");
        Amd amd = new Amd("AMD");

        //Processor
        Corei3 core3 = new Corei3("Core i3");
        Corei5 core5 = new Corei5("Core i5");
        Corei7 core7 = new Corei7("Core i7");
        Ryzen ryzen = new Ryzen("RAYZEN");

        //Laptop
        Laptop laptop1 = new Vivobook(nvdia, core5);
        laptop1.LaptopDinyalakan();
        Laptop laptop2 = new IdeaPad(amd, ryzen);
        laptop1.LaptopDimatikan();
        Predator predator = new Predator(amd, core7);

       /* Soal1
        laptop2.LaptopDinyalakan();
        laptop2.LaptopDimatikan();*/


       /* Soal2
        laptop1.Ngoding();
*/
/*
        //Soal3
        Console.WriteLine("Merk = " + laptop1.vga);
        Console.WriteLine("Processor = " + laptop1.processor.merk);
        Console.WriteLine("Tipe = " + laptop1.processor);
*/


        //Soal4 
       // predator.BermainGame();


        //Soal5
       /* ACER acer = new Predator(amd, ryzen);
        acer.BermainGame();*/

    }
}
