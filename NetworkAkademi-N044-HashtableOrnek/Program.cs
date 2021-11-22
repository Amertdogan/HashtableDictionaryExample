using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace NetworkAkademi_N044_HashtableOrnek
{
    class Program
    {
        static void Main(string[] args)
        {

            Hashtable sozluk = new Hashtable();
            Console.WriteLine("Hashtable içerisine ENG-TR olarak data eklenmektedir.");
            baslangıc:
            Console.WriteLine("Yeni kayıt eklemek istiyor musunuz ? E/H");
            string secim = Console.ReadLine();
            string girilenDegerKeys;
            string girilenDegerValue;

            if (secim.ToLower()=="e")
            {
                 baslangıc1:
                Console.WriteLine("Eklemek istediğiniz sözlük degerini ENG giriniz . ");
               
                girilenDegerKeys = Console.ReadLine();
                
                bool kontrol = sozluk.ContainsKey(girilenDegerKeys);
                if (kontrol==true)
                {
                    Console.WriteLine("Bu deger önceden eklenmiştir. Sistemde vardır.");
                    goto baslangıc1;
                }
                else
                {
                    Console.WriteLine("Eklediginiz ENG degerinin TR karsılıgını yazınız.");
                    girilenDegerValue = Console.ReadLine();
                    sozluk.Add(girilenDegerKeys, girilenDegerValue);
                    goto baslangıc;
                }               
    

            }
            else if (secim.ToLower() == "h")
            {
                Console.WriteLine("Tüm listeyi yazdırıyor..");
                //1.Yöntem
                foreach (var item in sozluk.Keys)
                {
                    Console.WriteLine("ENG : {0} = TR : {1}",item,sozluk[item]);
                 
                }
                // 2.Yöntem
                //foreach (DictionaryEntry item in sozluk)
                //{
                //    Console.WriteLine("ENG : {0} = TR : {1}",item.Key,item.Value);
                //}

            }
            
            Console.ReadLine();
        }
    }
}
