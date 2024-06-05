// Interface IEat
public interface IEat
{
    void Antre();
    void Bayar();
}

// Kelas Dine yang mengimplementasikan interface IEat
public class Dine : IEat
{
    public void Antre()
    {
        Console.WriteLine("Antre ambil makanan di tempat yang disediakan.");
    }

    public void Bayar()
    {
        Console.WriteLine("Bayar makanan sesudah selesai makan.");
    }
}

// Kelas Take yang mengimplementasikan interface IEat
public class Take : IEat
{
    public void Antre()
    {
        Console.WriteLine("Antre pesan makanan di tempat yang disediakan.");
    }

    public void Bayar()
    {
        Console.WriteLine("Langsung bayar makanan.");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Selamat datang di RM Padang Benderang");
        Console.WriteLine("Pilih opsi makan:");
        Console.WriteLine("1. Makan di Tempat");
        Console.WriteLine("2. Bungkus");
        Console.Write("Masukkan pilihanmu: ");
        int opsi = Convert.ToInt32(Console.ReadLine());

        IEat eat;

        // Percabangan
        if (opsi == 1)
        {
            eat = new Dine();
        }
        else if (opsi == 2)
        {
            eat = new Take();
        }
        else
        {
            Console.WriteLine("Pilihan tidak ada.");
            return;
        }

        Console.WriteLine();
        // Memanggil metode Antre
        eat.Antre();

        // Memanggil metode Bayar
        eat.Bayar();

        Console.WriteLine();
        Console.WriteLine("Terimakasih sudah datang.");

        Console.ReadLine();
    }
}
