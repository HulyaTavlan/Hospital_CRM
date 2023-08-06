using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Toolbox
{
    public class Cities
    {
        public Dictionary<string, string[]> CityList { get; private set; }

        private static Cities instance;
        public static Cities Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Cities();
                }
                return instance;
            }
        }

        private Cities()
        {
            string data = File.ReadAllText("../../../ToolBox/cities.json");
            CityList= JsonSerializer.Deserialize<Dictionary<string, string[]>>(data);  


            /* CityList = new Dictionary<string, string[]>
            {
                {  "Ankara", new string[]{ "Altındağ", "Ayaş", "Bala", "Beypazarı", "Çamlıdere", "Çankaya", "Çubuk", "Etimesgut", "Haymana", "Kalecik", "Keçiören", "Kızılcahamam", "Mamak", "Nallıhan", "Polatlı", "Şereflikoçhisar", "Sincan", "Yenimahalle" }},
                {  "İstanbul", new string[]{ "Adalar", "Bağcılar", "Bahçelievler", "Bakırköy", "Beşiktaş", "Beykoz", "Beyoğlu", "Büyükçekmece", "Çatalca", "Eminönü", "Esenler", "Eyüp", "Fatih", "Gaziosmanpaşa", "Güngören", "Kadıköy", "Kağıthane", "Kartal", "Küçükçekmece", "Maltepe", "Pendik", "Sarıyer", "Silivri", "Şile", "Şişli", "Sultanbeyli", "Tuzla", "Ümraniye", "Üsküdar", "Zeytinburnu" }},{
  "İzmir", new string[]{ "Aliağa", "Balçova", "Bayındır", "Bergama", "Beydağ", "Bornova", "Buca", "Çeşme", "Dikili", "Foça", "Güzelbahçe", "Karaburun", "Karşıyaka", "Kemalpaşa", "Kınık", "Kiraz", "Konak", "Menderes", "Menemen", "Narlıdere", "Ödemiş", "Seferihisar", "Selçuk", "Tire", "Torbalı", "Urla" }},{
  "Adana", new string[]{ "Aladağ", "Ceyhan", "Feke", "Karaisalı", "Kozan", "Pozantı", "Saimbeyli", "Seyhan", "Yumurtalı", "Yüreğir" }},{
  "Adıyaman", new string[]{ "Besni", "Gölbaşı", "Kahta", "Merkez" }},{
  "Afyon", new string[]{ "Başmakçı", "Bolvadin", "Çay", "Çobanlar", "Dinar", "Emirdağ", "İhsaniye", "Kızılören", "Merkez", "Sandıklı", "Sincanlı", "Suhut", "Sultandağı" }},{
  "Ağrı", new string[]{ "Diyadin", "Doğubeyazıt", "Merkez", "Patnos", "Tutak" }},{
  "Aksaray", new string[]{ "Eskil", "Gülağaç", "Güzelyurt", "Merkez" }},{
  "Amasya", new string[]{ "Göynücek", "Gümüşhacıköy", "Merkez", "Merzifon", "Suluova", "Taşova" }},{
  "Antalya", new string[]{ "Akseki", "Alanya", "Elmalı", "Finike", "Gazipaşa", "İbradi", "Kale", "Kaş", "Korkuteli", "Kumluca", "Manavgat", "Merkez", "Serik" }},{
  "Ardahan", new string[]{ "Çıldır", "Göle", "Merkez" }},{
  "Artvin", new string[]{ "Ardanuc", "Arhavi", "Hopa", "Merkez", "Murgül", "Savsat", "Yusufeli" }},{
  "Aydın", new string[]{ "Bozdoğan", "Buharkent", "Çine", "Germencik", "İncirliova", "Karacasu", "Karpuzlu", "Koçarlı", "Köşk", "Kuşadası", "Kuyucak", "Merkez", "Nazilli", "Söke", "Sultanhisar", "Yenihisar", "Yenipazar" }},{
  "Balıkesir", new string[]{ "Ayvalık", "Balya", "Bandırma", "Bigadiç", "Burhaniye", "Dursunbey", "Edremit", "Erdek", "Gömeç", "Gönen", "Havran", "İvrindi", "Kepsut", "Manyas", "Merkez", "Savaştepe", "Sındırgı", "Susurluk" }},{
  "Bartın", new string[]{ "Amasra", "Merkez", "Ulus" }},{
  "Batman", new string[]{ "Hasankeyf", "Merkez" }},{
  "Bayburt", new string[]{ "Aydıntepe", "Demirözü", "Merkez" }},{
  "Bilecek", new string[]{ "Bozhüyük", "Gölpazarı", "Merkez", "Osmaneli", "Pazaryeri", "Söğüt" }},{
  "Bingöl", new string[]{ "Adaklı", "Genç", "Karlıova", "Kiğı", "Merkez", "Solhan", "Yayladere", "Yedisu" }},{
  "Bitlis", new string[]{ "Adilcevaz", "Ahlat", "Güloymak", "Merkez", "Mutki", "Tatvan" }},{
  "Bolu", new string[]{ "Dörtdivan", "Gerede", "Göynük", "Mengen", "Merkez", "Mudurnu", "Yeniçağa" }},{
  "Burdur", new string[]{ "Ağlasun", "Bucak", "Çavdır", "Gölhisar", "Karamanlı", "Merkez", "Tefenni", "Yeşilova" }},{
  "Bursa", new string[]{ "Gemlik", "Gürsu", "İnegöl", "İznik", "Karacabey", "Keleş", "Kestel", "Mudanya", "MustafaKemalPaşa", "Nilüfer", "Orhaneli", "Orhangazi", "Osmangazi", "Yenişehir", "Yıldırım" }},{
  "Çanakkale", new string[]{ "Ayvacık", "Bayramiç", "Biga", "Bozcaada", "Çan", "Eceabat", "Ezine", "Gölbaşı", "Gökçeada", "Lapseki", "Merkez", "Yenice" }},{
  "Çankırı", new string[]{ "Atkaracalar", "Bayramören", "Çerkeş", "Eldivan", "Ilgaz", "Kurşunlu", "Merkez", "Orta", "Şabanözü", "Yapraklı" }},{
  "Çorum", new string[]{ "Alaca", "Boğazkale", "Iskılıp", "Kargı", "Mecitözü", "Merkez", "Oğuzlar", "Osmancık", "Sungurlu", "Uğurludağ" }},{
  "Denizli", new string[]{ "Acıpayam", "Babadağ", "Buldan", "Çal", "Çardak", "Çivril", "Güney", "Holaz", "Kale", "Merkez", "Sarayköy", "Tavaş" }},{
  "Diyarbakır", new string[]{ "Çermik", "Eğil", "Ergani", "Hani", "Hazro", "Kocaköy", "Lice", "Merkez", "Silvan" }},{
  "Düzce", new string[]{ "Akçakoca", "Çilimli", "Merkez", "Yığılca" }},{
  "Edirne", new string[]{ "Enes", "Havsa", "İpsala", "Keşan", "Lalapaşa", "Meriç", "Merkez", "Uzunköprü" }},{
  "Elazığ", new string[]{ "Ağin", "Arıcak", "Baskıl", "Karakoçan", "Keban", "Kovancılar", "Maden", "Merkez", "Palu", "Sivrice" }},{
  "Erzincan", new string[]{ "Çayırlı", "Ilıç", "Kemah", "Kemaliye", "Merkez", "Refahiye", "Tercan", "Üzümlü" }},{
  "Erzurum", new string[]{ "Aşkale", "Hınıs", "Horasan", "Ilıca", "İspir", "Narman", "Oltu", "Olur", "Pasinler", "Tortum" }},{
  "Eskişehir", new string[]{ "Alpu", "Beylikova", "Çifteler", "Günyüzü", "Han", "İnönü", "Mahmudiye", "Merkez", "Mihalıçcık", "Seyitgazi", "Sivrihisar" }},{
  "Gaziantep", new string[]{ "Araban", "Islahiye", "Nizip", "Nurdağı", "Oğuzeli", "Şahinbey", "Şehitkamil", "Yavuzeli" }},{
  "Giresun", new string[]{ "Alucra", "Bulancak", "Dereli", "Espiye", "Eynesil", "Görele", "Keşap", "Merkez", "Şebinkarahisar", "Tirebolu" }},{
  "Gümüşhane", new string[]{ "Kelkit", "Kurtun", "Merkez", "Şiran" }},{
  "Hakkari", new string[]{ "Çukurca", "Merkez", "Şemdilli", "Yüksekova" }},{
  "Hatay", new string[]{ "Altınözü", "Belen", "Dörtyol", "Yüksekova", "Erzin", "İskenderun", "Kırıkhan", "Kumlu", "Merkez", "Reyhanlı", "Samandağı", "Yayladağı" }},{
  "Iğdır", new string[]{ "Aralık", "Karakoyunlu", "Merkez", "Tuzluca" }},{
  "Isparta", new string[]{ "Aksu", "Atabey", "Eğirdir", "Gelendost", "Gönen", "Keçiborlu", "Merkez", "Sarkıkaraağaç", "Senirkent", "Sütçüler", "Uluborlu", "Yalvaç" }},{
  "Kahramanmaraş", new string[]{ "Afşın", "Andırın", "Çağlayancerit", "Elbistan", "Göksun", "Merkez", "Pazarcık" }},{
  "Karabük", new string[]{ "Eskipazar", "Merkez", "Safranbolu" }},{
  "Karaman", new string[]{ "Ayrancı", "Başyayla", "Ermenek", "Merkez" }},{
  "Kars", new string[]{ "Kağızman", "Merkez", "Sarıkamış" }},{
  "Kastamonu", new string[]{ "Abana", "Arac", "Bozkurt", "Çatalzeytin", "Cide", "Daday", "Devrenkanı", "Hanönü", "İhsangazi", "İnebolu", "Küre", "Merkez", "Taşköprü", "Tosya" }},{
  "Kayseri", new string[]{ "Akkışla", "Bünyan", "Develi", "Felahiye", "Hacılar", "İncesu", "Kocasinan", "Melekgazi", "Özvatan", "Pınarbaşı", "Talas", "Tomarza", "Yahyalı", "Yeşilhisar" }},{
  "Kilis", new string[]{ "Elbeyli", "Merkez", "Musabeyli", "Polateli" }},{
  "Kırıkkale", new string[]{ "Karakeçili", "Keskin", "Merkez", "Sulakyurt" }},{
  "Kırklareli", new string[]{ "Babaski", "Lüleburgaz", "Merkez", "Pehlivanköy", "Pınarhisar", "Vize" }},{
  "Kırşehir", new string[]{ "Akpınar", "Çiçekdağı", "Kaman", "Merkez", "Mucur" }},{
  "Kocaeli", new string[]{ "Derince", "Gebze", "Gölcük", "Kandıra", "Karamürsel", "Merkez" }},{
  "Konya", new string[]{ "Akören", "Akşehir", "Altınekin", "Beyşehir", "Bozkır", "Çeltik", "Cihanbeyli", "Çumra", "Derbent", "Doğanhisar", "Emirgazi", "Ereğli", "Hadım", "Hüyük", "Ilgın", "Kadınhanı", "Karapınar", "Karatay", "Meram", "Sarayönü", "Selçuklu", "Seydişehir", "Taşkent", "Yunak" }},{
  "Kütahya", new string[]{ "Altıntaş", "Domaniç", "Dumlupınar", "Emet", "Gediz", "Merkez", "Pazarlar", "Simav", "Tavşanlı" }},{
  "Malatya", new string[]{ "Akçadağ", "Arapkır", "Arguvan", "Battalgazi", "Darende", "Doğanşehir", "Hekimhan", "Merkez", "Pötürge", "Yazıhan", "Yeşilhan" }},{
  "Manisa", new string[]{ "Ahmetli", "Akhisar", "Alaşehir", "Demirci", "Gölmarmara", "Gördes", "Kırkağaç", "Kula", "Merkez", "Salihli", "Sarıhanlı", "Soma", "Turgutlu" }},{
  "Mardin", new string[]{ "Derik", "Kızıltepe", "Mazıdağı", "Merkez", "Midyat", "Nusaybin", "Ömerli", "Savur" }},{
  "Mersin", new string[]{ "Anamur", "Bozyazı", "Çamlıyayla", "Erdemli", "Gülnar", "Merkez", "Mut", "Silifke", "Tarsus" }},{
  "Muğla", new string[]{ "Bodrum", "Datça", "Fathiye", "Kavaklıdere", "Köyceğiz", "Marmaris", "Merkez", "Milas", "Ortaca", "Ula", "Yatağan" }},{
  "Muş", new string[]{ "Bulanık", "Korkut", "Malazgirt", "Merkez" }},{
  "Nevşehir", new string[]{ "Avanos", "Derinkuyu", "Gülşehir", "Hacıbektaş", "Kozaklı", "Merkez", "Ürgüp" }},{
  "Niğde", new string[]{ "Altunhisar", "Bor", "Çamardı", "Çiftlik", "Ulukışla" }},{
  "Ordu", new string[]{ "Akkuş", "Fatsa", "Görköy", "Kabadüz", "Merkez", "Mesudiye", "Perşembe", "Ulubey", "Ünye" }},{
  "Osmaniye", new string[]{ "Bahçe", "Kadirli", "Merkez" }},{
  "Rize", new string[]{ "Ardeşen", "Çayeli", "Fındıklı", "Merkez", "Pazar", "Çamlıhemşin" }},{
  "Sakarya", new string[]{ "Akyazı", "Geyve", "Hendek", "Karasu", "Kaynarca", "Merkez", "Sapanca", "Taraklı" }},{
  "Samsun", new string[]{ "Alaçam", "Bafra", "Çarşamba", "Havza", "Kavak", "Ladik", "Merkez", "Salıpazarı", "Tekkeköy", "Terme", "Vezirköprü" }},{
  "Şanlıurfa", new string[]{ "Akçakale", "Birecik", "Bozova", "Halfeti", "Harran", "Hilvan", "Merkez", "Siverek", "Suruç", "Viranşehir" }},{
  "Siirt", new string[]{ "Aydınlar", "Baykan", "Eruh", "Kurtalan", "Merkez" }},{
  "Sinop", new string[]{ "Ayancık", "Boyabat", "Durağan", "Elfelek", "Gerze", "Merkez" }},{
  "Şırnak", new string[]{ "Cizre", "İdil", "Merkez", "Silopi" }},{
  "Sivas", new string[]{ "Altınyayla", "Divriği", "Doğansar", "Gemerek", "Hafik", "Kangal", "Merkez", "Şarkışla", "Suşehri", "Yılızeli", "Zara" }},{
  "Tekirdağ", new string[]{ "Çerkezköy", "Çorlu", "Hayrabolu", "Malkara", "MarmaraEreğlisi", "Merkez", "Muratlı", "Saray", "Şarköy" }},{
  "Tokat", new string[]{ "Almuz", "Erbaa", "Merkez", "Niksar", "Pazar", "Reşadiye", "Sulusaray", "Turhal", "Zile" }},{
  "Trabzon", new string[]{ "Akçabat", "Araklı", "Arşin", "Beşikdüzü", "Çarşıbaşı", "Çaykara", "Dernekpazarı", "Maçka", "Merkez", "Of", "Sürmene", "Tonya", "Vakfıkebir", "Yomra" }},{
  "Tunceli", new string[]{ "Çemişgezek", "Hozat", "Mazgirt", "Merkez", "Nazimiye", "Pertek" }},{
  "Uşak", new string[]{ "Banaz", "Eşme", "Merkez", "Sivaslı", "Ulubey" }},{
  "Van", new string[]{ "Başkale", "Çaldıran", "Çatak", "Erciş", "Gevaş", "Gürpınar", "Merkez", "Muradiye", "Özalp" }},{
  "Yalova", new string[]{ "Altınova", "Armutlu", "Merkez" }},{
  "Yozgat", new string[]{ "Boğazlıyan", "Çandır", "Çayıralan", "Merkez", "Sarıkaya", "Sefaatli", "Sorgun", "Yenifakili", "Yerköy" }},
                {  "Zonguldak", new string[]{ "Araplı", "Çaycuma", "Devrek", "Ereğli", "Merkez" } }
            };
            */
        }
    }
}
