public class Obat
{
    // private variables atau fields
    private string nama; 
    private string merk;
    private int harga;
    
    // property
    public string Nama { get; set; }

    public string Merk { get; set; }
    
    public int Harga { get; set; }



    public void InformasiObat() // mengambil nilai dengan property

    {
        Console.WriteLine("Nama: " + Nama);
        Console.WriteLine("Merk: " + Merk);
        Console.WriteLine("Harga: " + Harga);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // memberi nilai property
        Obat obat1 = new Obat();
        obat1.Nama = "Promag";
        obat1.Merk = "Kalbe";
        obat1.Harga = 9350;

        Obat obat2 = new Obat();
        obat2.Nama = "Intunal";
        obat2.Merk = "mepro";
        obat2.Harga = 10000;

        // menampilkan hasil
        obat1.InformasiObat();
        Console.WriteLine();

        obat2.InformasiObat();
        Console.WriteLine();

        Console.ReadKey();
    }
}
