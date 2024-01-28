using System;
using System.Linq;
using IronBarCode;

namespace barkod_olusturucu_okuyucu;

partial class Barkod
{
    void Uret()
    {
        try
        {
            Console.Write("Barkod üretmek için metni girin: ");
            GeneratedBarcode myBarcode = BarcodeWriter.CreateBarcode(Console.ReadLine(), BarcodeWriterEncoding.EAN8);
            myBarcode.SaveAsImage(filePath);
            Console.WriteLine("Barkod üretildi!");
        }
        catch (Exception)
        {
            Console.WriteLine("Geçersiz barkod formatı girdiniz!");
        }
    }

    void Oku()
    {
        try
        {
            Console.WriteLine("Barkod okunuyor ...");

            BarcodeResult[] results = BarcodeReader.Read(filePath).ToArray();
            Console.WriteLine(results[0].Text);
            Console.WriteLine("Barkod okundu!");
        }
        catch (Exception)
        {
            Console.WriteLine("Barkod bulunamadı!");
        }
    }
}