using Odev;

public class Mesaj
{
    static void Main()
    {
        Bmw araba1 = new Bmw();
        araba1.marka = ("BMW");
        araba1.vites = ("Otamatik");
        araba1.Ozellikler();
       
        
        Porshce araba2 = new Porshce();
        araba2.marka = ("Porsche");
        araba2.vites = ("Manuel");
        araba2.Ozellikler();

        Audi araba3 = new Audi();
        araba3.marka = ("Audi");
        araba3.vites = ("Yarı otamatik");
        araba3.Ozellikler();

        Toyota araba4 = new Toyota();
        araba4.marka=("Toyota");
        araba4.vites = ("Otomatik");
        araba4.Ozellikler();
        
    
    
    
    
    }
}