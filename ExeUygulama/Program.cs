

// DLL'in içerisinden gelen kodların namespace adresini using olarak ekledik.
using IlkKodKutuphanesi;

namespace ExeUygulama
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Dll bir kod kütüphanesidir. Çalıştırılacak bir çıktı vermez.

            // Dll çalışan projelere referans olmak amacı ile oluşturulur.
            // Dll daha önceden yazılmış kodun ana çalışan koda kod referans etmek için kullanılır.



            // DLL referans etmek için projeye sağ tık  Add bölümünden Add Project Reference menüsünden browse diyerek eklemek istediğiniz dll'i seçerek yapılır.
            // Dll seçtikten sonra dll projenize yüklenir. 

            // DLL'in içeriğine ulaşmak için DLL'in namespace'ini using direktifi olarak eklemek gerekir.ç
            WissenMath wissen = new WissenMath();
            wissen.Topla(50, 40);
        }
    }
}