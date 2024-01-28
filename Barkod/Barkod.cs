using System;
using System.IO;

namespace barkod_olusturucu_okuyucu;

partial class Barkod
{
    string directoryPath, filePath;

    internal Barkod()
    {
        directoryPath = @"C:\MyBarcode";
        filePath = directoryPath + @"\myBarcode.png";
        VarlikKontrolu();
    }

    void VarlikKontrolu()
    {
        if (!Directory.Exists(directoryPath)) // Dizin mevcut değilse
            Directory.CreateDirectory(directoryPath); // oluştur!
        
        if (!File.Exists(filePath)) // Dosya mevcut değil ise
            File.Create(filePath).Close();  // oluştur ve kapat!
    }

    internal void GoreveBasla()
    {
    Baslangic:
        Console.WriteLine("\nYapmak istediğiniz işlemi seçin! \n 1.Barkod Üret \n 2.Barkod Oku \n 3.Çıkış Yap \n-----------------------------------");
        switch (Console.ReadLine())
        {
            case "1": Uret();
                break;
            case "2": Oku();
                break;
            case "3":
                Console.WriteLine("Oturum sonlandırıldı!");
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Geçersiz seçim yaptınız! \n");
                goto Baslangic;
        }
    }
}