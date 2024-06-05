// Kelas induk
public class Keyboard
{
    public string Nama { get; set; }   // Deklarasi nama keyboard
    public string Ukuran { get; set; } // Deklarasi ukuran keyboard
    public int Harga { get; set; }     // Deklarasi harga keyboard
    public void GetDescription()
    {
        Console.WriteLine("Keyboard {0} ini berukuran {1} dengan harga {2}.", Nama, Ukuran, Harga);        
    }
}

// Kelas turunan yang mewarisi dari Keyboard
public class Mechanical : Keyboard
{
    public string Switch { get; set; } // Deklarasi switch yang digunakan
    public void Mecha()
    {
        Console.WriteLine("Merupakan keyboard dengan fitur {0}.", this.Switch);
    }
}

// Kelas turunan yang mewarisi dari Keyboard
public class Membrane : Keyboard
{
    public string Fitur { get; set; } // Deklarasi fitur yang diunggulkan
    public void Membran()
    {
        Console.WriteLine("Merupakan keyboard dengan fitur {0}.", this.Fitur);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Membuat objek dari kelas turunan (Mechanical)
        Mechanical mechanical = new Mechanical();
        mechanical.Nama = "Vortexseries GT65";
        mechanical.Ukuran = "65 %";
        mechanical.Harga = 990000;
        mechanical.Switch = "Gateron Brown";
        // Memanggil method yang diwarisi dari kelas induk (Keyboard)     
        mechanical.GetDescription();
        // Memanggil method yang hanya ada di kelas turunan (Mechanical)
        mechanical.Mecha();

        Console.WriteLine();

        // Membuat objek dari kelas turunan (Membrane)
        Membrane membrane = new Membrane();
        membrane.Nama = "ROBOT KM3000";
        membrane.Ukuran = "79 keys";
        membrane.Harga = 170000;
        membrane.Fitur = "Wireless";
        // Memanggil method yang diwarisi dari kelas induk (Keyboard) 
        membrane.GetDescription();
        // Memanggil method yang hanya ada di kelas turunan (Membrane)
        membrane.Membran();

        Console.ReadKey();
    }
}
