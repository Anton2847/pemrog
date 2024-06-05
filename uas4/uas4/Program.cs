// Masak sebagai kelas abstrak
public abstract class Masak
{
    // Proses sebagai metode abstrak
    public abstract void Proses();

    // Kegiatan sebagai metode konkret
    public void Kegiatan()
    {
        Console.WriteLine("Makanan sedang dimasak.");
    }
}

// Subclass Rebus yang mewarisi dari kelas abstrak Masak
public class Rebus : Masak
{
    // Implementasi metode abstrak Proses
    public override void Proses()
    {
        Console.WriteLine("Masakan sedang direbus.");
    }
}

// Subclass Goreng yang mewarisi dari kelas abstrak Masak
public class Goreng : Masak
{
    // Implementasi metode abstrak Proses
    public override void Proses()
    {
        Console.WriteLine("Masakan sedang digoreng.");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Membuat objek dari kelas turunan Rebus
        Rebus rebus = new Rebus();

        // Memanggil metode Proses
        rebus.Proses();

        // Memanggil metode yang diwarisi dari kelas Masak
        rebus.Kegiatan();

        Console.WriteLine();
        // Membuat objek dari kelas turunan Goreng
        Goreng goreng = new Goreng();

        // Memanggil metode Proses
        goreng.Proses();

        // Memanggil metode yang diwarisi dari kelas Masak
        goreng.Kegiatan();

        Console.ReadLine();
    }
}
