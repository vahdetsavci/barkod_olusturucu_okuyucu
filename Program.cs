namespace barkod_olusturucu_okuyucu;

class Program
{
    static void Main(string[] args)
    {
        Barkod barkod = new();

        while (true)
            barkod.GoreveBasla();
    }
}
