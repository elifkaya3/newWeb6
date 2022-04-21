using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //ToList metodu ile bölümleri listeleyelim.
            void BolumleriListele()
            {
                HastaneSabahEntities hastane = new HastaneSabahEntities();
                var bolumler = hastane.Bolumler.ToList();

                Console.WriteLine($"Böüm ID\t\tBölüm Adı");
                foreach (var bolum in bolumler)
                {
                    Console.WriteLine($"{bolum.ID}\t\t{bolum.BolumAd}");
                }
                Console.ReadLine();
            }

            //Where ile sorgulama,Diş Bölümünü getir.
            void BolumGetir()
            {
                //bu nesen bu scope içinde yaşayacak
                using (HastaneSabahEntities hastane = new HastaneSabahEntities())
                {
                    //var sonuc = hastane.Bolumler.Where(x =>x.BolumAd=="Diş");
                    var sonuc = hastane.Bolumler.Where(x => x.BolumAd.StartsWith("D"));//baslangıcı d ile başlayanlara startsWith komutu
                    foreach (var item in sonuc)
                    {
                        Console.WriteLine($"Bölüm ID: {item.ID} Bölüm Ad {item.BolumAd}");
                    }
                    Console.ReadLine();
                }
            }

            //Select ile veri çekme.
            void DoktorAdListele()
            {
                using (HastaneSabahEntities hastane=new HastaneSabahEntities())
                {
                  var adlar = hastane.Doktorlar.Select(x => x.AdSoyad);
                    Console.WriteLine($"Doktor Adı");
                    foreach (var ad in adlar)
                    {
                        Console.WriteLine(ad);
                    }
                    Console.ReadLine();
                }
            }

            //Find ile hızlı arama.
            void HızlıArama()
            {
                using (HastaneSabahEntities hastane = new HastaneSabahEntities())
                {
                    Doktorlar doktor = hastane.Doktorlar.Find(4);
                    //Find metodu ilgili tablodaki primary key üzerinden arama yapar bu da oldukça hızlıdır.
                    Console.WriteLine($"Doktor Adı: {doktor.AdSoyad} Bölümü: {doktor.Bolumler.BolumAd}");
                }
                Console.ReadLine();
            }

            //ilk kaydı getirme,ilk demet evgarı getir.
            void IlkKayıt()
            {
                using (HastaneSabahEntities hastane = new HastaneSabahEntities())
                {
                    Doktorlar doktor = hastane.Doktorlar
                        .Where(x => x.AdSoyad == "Demet Evgar")
                        .First();
                    Console.WriteLine($"Doktor Adı: {doktor.AdSoyad} Bölüm Ad: {doktor.Bolumler.BolumAd}");
                }
                Console.ReadLine();
            }

            //İlk 3 doktoru getir
            void IlkUcDoktor()
            {
                using (HastaneSabahEntities hastane = new HastaneSabahEntities())
                {
                    var ilkUcDoktor = hastane.Doktorlar.Take(3);
                    foreach (var doktor in ilkUcDoktor)
                    {
                        Console.WriteLine($"{doktor.AdSoyad}");
                    }
                }
                Console.ReadLine();
            }

            //var mı?
            void VarMi()
            {
                using (HastaneSabahEntities hastane = new HastaneSabahEntities())
                {
                    bool sonuc = hastane.Doktorlar.Any(x => x.AdSoyad == "Demet Evgar");
                    if (sonuc)
                    {
                        Console.WriteLine("aradığınız doktor vardır.");
                    }
                    else
                    {
                        Console.WriteLine("aradığınız kriterlere uygun doktor bulunamamıştır");
                    }
                }
                Console.ReadLine();
            }

            //uygunluk var mı?
            void UygunlukVarMi()
            {
                using (HastaneSabahEntities hastane = new HastaneSabahEntities())
                {
                    bool sonuc = hastane.Doktorlar.All(x=>x.AdSoyad == "Demet Evgar");
                    if (sonuc)
                    {
                        Console.WriteLine("Evet, tümü uygundur.");
                    }
                    else
                    {
                        Console.WriteLine("Hayır, İçinde uymayanlar var");
                    }
                }
                Console.ReadLine();
            }

            //Ascending(küçükten büyüğe A'dan Z'ye) Sıralama.
            void SiralaAsc()
            {
                using (HastaneSabahEntities hastane = new HastaneSabahEntities())
                {
                    var siraliDoktorlar = hastane.Doktorlar.OrderBy(x => x.AdSoyad);
                    foreach (var doktor in siraliDoktorlar)
                    {
                        Console.WriteLine(doktor.AdSoyad);
                    }
                }
                Console.ReadLine();
            }

            //Descending sıralam (büyükten küçüğe) Sıralama.
            void SiralaDesc()
            {
                using (HastaneSabahEntities hastane = new HastaneSabahEntities())
                {
                    var tersSiraliDoktorlar = hastane.Doktorlar.OrderByDescending(x=>x.AdSoyad);
                    foreach (var doktor in tersSiraliDoktorlar)
                    {
                        Console.WriteLine(doktor.AdSoyad);
                    }
                }
                Console.ReadLine();
            }

            //son 3 doktor
            void SonUcDoktor()
            {
                using (HastaneSabahEntities hastane = new HastaneSabahEntities())
                {
                    var sonUcDoktor = hastane.Doktorlar.OrderByDescending(x=>x.ID).Take(3);
                    foreach (var doktor in sonUcDoktor)
                    {
                        Console.WriteLine($"{doktor.AdSoyad}");
                    }
                }
                Console.ReadLine();
            }

            //Bölümlere göre doktor sayısı
            void BolumlereGoreDoktorGetir()
            {
                using (HastaneSabahEntities hastane = new HastaneSabahEntities())
                {
                    var sonuc = hastane.Doktorlar
                        .GroupBy(a => a.Bolumler.BolumAd)
                        .Select(b => new
                        {
                            name = b.Key,
                            count=b.Count()
                        });
                    Console.WriteLine($"Bölüm\tDoktor Sayısı");
                    foreach (var item in sonuc)
                    {
                        Console.WriteLine($"{item.name}\t{item.count}");
                    }
                }
                Console.ReadLine();
            }


            BolumlereGoreDoktorGetir();
            //SonUcDoktor();
            //BolumleriListele();
            //BolumGetir();
            //DoktorAdListele();
            //HızlıArama();
            //IlkKayıt();
            //IlkUcDoktor();
            //VarMi();
            //UygunlukVarMi();
            //SiralaAsc();
            //SiralaDesc();
        }
    }
}
