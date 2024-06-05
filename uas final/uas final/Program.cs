public class Ticket
{
    public string Nama { get; set; }
    public string NIK { get; set; }
    public string Telepon { get; set; }
    public string NomorKartuVaksin { get; set; }
    public string Alamat { get; set; }

    public void PrintTicketDetails()
    {
        Console.WriteLine("Data Penumpang");
        Console.WriteLine("Nama              : " + Nama);
        Console.WriteLine("NIK               : " + NIK);
        Console.WriteLine("No. HP            : " + Telepon);
        Console.WriteLine("Nomor Kartu Vaksin: " + NomorKartuVaksin);
        Console.WriteLine("Alamat            : " + Alamat);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Aplikasi Pemesanan Tiket");

        List<Ticket> tickets = new List<Ticket>(); 

        bool isRunning = true;
        while (isRunning)
        {            
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Input data");
            Console.WriteLine("2. Tampilkan data");
            Console.WriteLine("3. Keluar");
            Console.Write("Pilih menu: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("\nInput Data Tiket");

                    Console.Write("Masukkan Nama              : ");
                    string nama = Console.ReadLine();

                    Console.Write("Masukkan NIK               : ");
                    string nik = Console.ReadLine();

                    Console.Write("Masukkan No. HP            : ");
                    string telepon = Console.ReadLine();

                    Console.Write("Masukkan Nomor Kartu Vaksin: ");
                    string nomorkartuvaksin = Console.ReadLine();

                    Console.Write("Masukkan Alamat            : ");
                    string alamat = Console.ReadLine();

                    Ticket ticket = new Ticket();
                    ticket.Nama = nama;
                    ticket.NIK = nik;
                    ticket.Telepon = telepon;
                    ticket.NomorKartuVaksin = nomorkartuvaksin;
                    ticket.Alamat = alamat;

                    tickets.Add(ticket); 
                    break;

                case "2":
                    Console.WriteLine("\nData Tiket");

                    if (tickets.Count == 0)
                    {
                        Console.WriteLine("Tidak ada data tiket yang tersedia.");
                    }
                    else
                    {
                        foreach (Ticket t in tickets)
                        {
                            t.PrintTicketDetails();
                            Console.WriteLine();
                        }
                    }
                    break;

                case "3":
                    isRunning = false;
                    break;

                default:
                    Console.WriteLine("Pilihan tidak valid.");
                    break;
            }
        }

        Console.WriteLine("\nTerima kasih.");
    }
}
