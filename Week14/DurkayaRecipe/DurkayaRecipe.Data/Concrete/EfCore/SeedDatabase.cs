using DurkayaRecipe.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DurkayaRecipe.Data.Concrete.EfCore
{
    public static class SeedDatabase
    {
        public static void Seed()
        {
            var context = new DurkayaRecipeContext();
            if (context.Database.GetPendingMigrations().Count() == 0)
            {
                if (context.Categories.Count() == 0)
                {
                    context.Categories.AddRange(Categories);
                }
                if (context.Foods.Count() == 0)
                {
                    context.Foods.AddRange(Foods);
                }
                if (context.FoodCategories.Count() == 0)
                {
                    context.FoodCategories.AddRange(FoodCategories);
                }
                context.SaveChanges();
            }
        }

        private static Category[] Categories =
        {
            new Category() {CategoryName="Çorba", CategoryDescription="Yemek sıcak yenir.", Url="corba"},
            new Category() {CategoryName="Ana Yemek", CategoryDescription ="Yemek sıcak yenir.", Url="ana-yemek"},
            new Category() {CategoryName="Ara Sıcak", CategoryDescription ="Yemek sıcak yenir.", Url="ara-sicaka"},
            new Category() {CategoryName="Tatlı", CategoryDescription ="Yemek sıcak yenir.", Url="tatli"}
        };

        private static Food[] Foods =
        {
            new Food() {FoodName="Mercimek Çorbası", FoodMaterial="2 su bardağı kırmızı mercimek, 1 adet soğan, 2 yemek kaşığı un, 1 adet havuç",
                FoodDescription="Bu tarifte soğan, un, salça önceden güzelce kavrulur ve diğer malzemeler eklenerek çorba pişmeye bırakılır. Un sevmeyenler yerine bir patates kullanabilirler, un ve patates çorbanın kıvamının daha koyu olmasını sağlayacaktır. Hemen hemen her çorbaya kemik suyu ya da tavuk suyu kullanırım.",
                Url="mercimek-corbasi", IsApproved = true, IsHome = true}, 
            new Food() {FoodName="Tavuklu Pilav",
                FoodMaterial="500 gram tavuk göğüs eti, 2 su bardağı pirinç, 1 çay bardağı şehriye, 3 yemek kaşığı tereyağı, 1 su bardağı tavuk suyu, 2 su bardağı kaynamış su, 1 tatlı kaşığı tuz, 1/2 (yarım) tatlı kaşığı karabiber",
                FoodDescription="İlk olarak tavuklarımızı haşlamak için tencereye koyuyoruz ve üzerini bir parmak geçecek şekilde su ekleyerek kaynamaya bırakıyoruz. Haşlanan tavuklarımızı soğuması için kenara alıyoruz. Biraz soğuduğunda tavuklarımızı tiftikliyeceğiz. Bu sırada pirinçlerimizi de ılık suya koyup nişastasının çıkmasını bekliyoruz. Pilav tenceresine yağımızı ekleyip eridiğinde şehriyelerimizi kavuruyoruz. Şehriyelerin rengi değişip, kokusu çıktığında pirinçlerimizi de ekliyoruz ve 5-10 dakika kadar daha kavuruyoruz. Daha sonra pirinçimizin üzerine tiftiklediğimiz tavuğumuzu ekliyoruz. 1 bardak tavuk suyu ve 2 bardak kaynamış suyunu da ekledikten sonra tuz ve karabiberi de ilave edip bir kere karıştırıyoruz ve kapağını kapatarak kısık ateşte pişmeye bırakıyoruz. Ben pilav pişirirken çok fazla karıştırmıyorum size de böyle tavsiye ederim. Pilavımız suyunu çekip tane tane olduğunda altını kapatıp, kapağın üzerine demlenmesi için kağıt havlu koyuyoruz. Servis yaparken havluyu alarak afiyetle pilavımızı yiyoruz. Ellerinize sağlık.",
                Url="tavuklu-pilav", IsApproved = true, IsHome = true},
            new Food() {FoodName="Sigara Böreği", FoodMaterial="2 adet orta boy haşlanmış patates, 2 adet yufka, Karabiber, Pul biber, Yeterince tuz",
                FoodDescription="Patatesli sigara böreği için ilk olarak haşlanmış patatesleri küçük küçük doğrayın ve püre haline getirin ve baharatları ve tuzu ekleyerek iyice harmanlayın. Daha sonra yufkaları pizza dilimi şeklinde 8 ve 12 parçaya (yufkanız küçükse 8′ e büyükse 12 parçaya) kesin. Yufka dilimlerinin geniş olan kısımlarına iç  malzemesinden koyarak sarın. Uç kısımlarını açılmaması için su ile ıslatarak yapıştırabilirsiniz. Bu şekilde diğer yufkayı da hazırlayın. Daha sonra iyice ısınmış sıvı yağda sigara böreklerinizi çevirerek kızartın. Afiyet olsun.",
                Url="sigara-boregi", IsApproved = true, IsHome = true},
             new Food() {FoodName="Suffle", FoodMaterial="2 adet yumurta, 1/2 su bardağı un, 1/2 su bardağı toz şeker, 1/2 su bardağı sıvı yağ, 1 tatlı kaşığı kakao, 100 gram çikolata, 1 yemek kaşığı, pudra şekeri",
                FoodDescription="İlk önce yumurta ve şekeri bir kapta çırpalım 2-3 dakika yeterli olacaktır. Daha sonra unu ve kakaoyu ekleyip biraz daha çırpalım. Sıvı yağ ve çikolatayı ocakta eritelim. (sürekli karıştıralım çikolata iyicene erisin topak olmasın) daha sonra eriyen çikolatayı yumurtalı harcın içine dökelim. Karıştıralım bir kaşık ile. Fırına girecek olan kaplarımızı biraz tereyağı ile yağlayalım ve harçları çok dolu olmayacak şekilde paylaştıralım. Fırından fırına fark olabiliyor benim suflelerim 180 derece 8 dakikada pişti. 8 dakika dan sonra hafif sallayarak kontrol edebilirsiniz. Ortası biraz yumuşak kenarları sert olacak suflenin. Afiyet olsun.",
                Url="sigara-boregi", IsApproved = true, IsHome = true}
        };

        private static FoodCategory[] FoodCategories =
        {
            new FoodCategory() { Food = Foods[0], Category=Categories[0] },
            new FoodCategory() { Food = Foods[1], Category=Categories[1] },
            new FoodCategory() { Food = Foods[2], Category=Categories[2] },
            new FoodCategory() { Food = Foods[3], Category=Categories[3] }
        };


    }
}
