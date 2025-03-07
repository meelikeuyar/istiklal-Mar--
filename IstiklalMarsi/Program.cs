// İstiklal Marşı Ödevi
// Adı Soyadı : Melike Uyar
// Öğrenci No: 220502021
// Tarih : 03.11.2023
using System;
using System.Collections.Generic; // koleksiyon oluşturmak için gerekli olan yapı.

class istiklalMarsi
{
    static void Main()
    {
        Dictionary<string, int[]> notalar = new Dictionary<string, int[]>();
        notalar.Add("DO", new int[] { 16, 33, 65, 131, 262, 523, 1046, 2093 });
        notalar.Add("DO#", new int[] { 17, 35, 69, 139, 277, 554, 1109, 2217 });
        notalar.Add("RE", new int[] { 18, 37, 73, 147, 294, 587, 1175, 2349 });
        notalar.Add("RE#", new int[] { 19, 39, 78, 155, 311, 622, 1244, 2489 });
        notalar.Add("MI", new int[] { 21, 41, 82, 165, 330, 659, 1328, 2637 });             // Nota frekansları eklendi.
        notalar.Add("FA", new int[] { 22, 44, 87, 175, 349, 698, 1397, 2794 });
        notalar.Add("FA#", new int[] { 23, 46, 92, 185, 370, 740, 1480, 2960 });
        notalar.Add("SOL", new int[] { 24, 49, 98, 196, 392, 784, 1568, 3136 });
        notalar.Add("SOL#", new int[] { 26, 52, 104, 208, 415, 831, 1661, 3322 });
        notalar.Add("LA", new int[] { 27, 55, 110, 220, 440, 880, 1760, 3520 });
        notalar.Add("LA#", new int[] { 29, 58, 116, 233, 466, 932, 1865, 3729 });
        notalar.Add("SI", new int[] { 31, 62, 123, 245, 494, 988, 1975, 3951 });

        Dictionary<string, int> sureler = new Dictionary<string, int>();
        sureler.Add("tam", 1600);
        sureler.Add("yarim", 800);
        sureler.Add("ceyrek", 400);     // Süre ayarları ekledik.
        sureler.Add("sekiz", 200);
        sureler.Add("onalti", 100);

        string istiklalMarsi = // İstiklal Marşı notalarını içeren string tanımladık.
            "SI-5-yarim,SI-5-onalti,SI-5-onalti,SI-5-yarim,SI-5-onalti,SI-5-onalti,SI-5-sekiz,SI-5-sekiz,SI-5-sekiz,SI-5-sekiz," +
            "SI-5-ceyrek,SI-4-ceyrek,MI-5-ceyrek,FA#-5-ceyrek,SOL-5-ceyrek,RE#-5-ceyrek,FA#-5-onalti,MI-5-tam,MI-5-ceyrek,LA-5-ceyrek," +
            "SI-5-ceyrek,DO-6-ceyrek,SI-5-onalti,SOL#-5-ceyrek,SI-5-onalti,LA-5-tam,SI-5-onalti,LA#-5-onalti,SI-5-onalti,FA#-5-ceyrek," +
            "FA#-5-yarim,LA-5-onalti,SOL-5-ceyrek,RE#-5-onalti,MI-5-ceyrek,FA#-5-onalti,SOL-5-ceyrek,LA-5-onalti,SI-5-ceyrek," +
            "DO-6-onalti,RE-6-ceyrek,MI-6-onalti,RE-6-ceyrek,RE-5-onalti,DO#-5-onalti,RE-5-onalti,SI-5-ceyrek,LA-5-ceyrek,SOL-5-tam," +
            "SI-4-onalti,LA#-4-onalti,SI-4-onalti,FA#-5-ceyrek,SI-4-ceyrek,SI-5-ceyrek,LA-5-onalti,SOL-5-onalti,FA#-5-onalti,SOL-5-onalti," +
            "MI-5-ceyrek,MI-6-yarim,RE-6-onalti,DO-6-ceyrek,SI-5-onalti,LA-5-ceyrek,SOL-5-onalti,FA#-5-ceyrek,MI-5-onalti,SI-5-ceyrek," +
            "SI-4-ceyrek,MI-5-tam,SI-4-ceyrek,MI-5-ceyrek,FA#-5-ceyrek,SOL-5-ceyrek,RE#-5-ceyrek,FA#-5-onalti,MI-5-tam," +
            "MI-5-ceyrek,LA-5-ceyrek,SI-5-ceyrek,DO-6-ceyrek,SI-5-onalti,SOL#-5-ceyrek,SI-5-onalti,LA-5-tam,SI-5-onalti," +
            "LA#-5-onalti,SI-5-onalti,FA#-5-ceyrek,FA#-5-yarim,LA-5-onalti,SOL-5-ceyrek,RE#-5-onalti,MI-5-ceyrek,FA#-5-onalti,SOL-5-ceyrek," +
            "LA-5-onalti,SI-5-ceyrek,DO-6-onalti,RE-6-ceyrek,MI-6-onalti,RE-6-ceyrek,RE-5-onalti,DO#-5-onalti,RE-5-onalti,SI-5-ceyrek," +
            "LA-5-ceyrek,SOL-5-tam,SI-4-onalti,LA#-4-onalti,SI-4-onalti,FA#-5-ceyrek,SI-4-ceyrek,SI-5-ceyrek,LA-5-onalti,SOL-5-onalti," +
            "FA#-5-onalti,SOL-5-onalti,MI-5-ceyrek,MI-6-yarim,RE-6-onalti,DO-6-ceyrek,SI-5-onalti,LA-5-ceyrek,SOL-5-onalti,FA#-5-ceyrek," +
            "MI-5-onalti,SI-5-ceyrek,SI-4-ceyrek,MI-5-tam";

        string[] notalarArray = istiklalMarsi.Split(','); // notalar ayrıldı ve virgüllerle bölündü.

        foreach (var notalarStr in notalarArray) // her bir nota için işlem yapılacak.
        {
            // Notaları, oktavları ve süreyi ayırdık.
            // Oktav: bir do sesiyle ondan sonraki do sesi arasındaki uzaklık.
            /* String.Split giriş dizesini bir veya daha fazla sınırlayıcıya göre bölerek bir alt dize dizisi oluşturur.
            Bu yöntem sözcük sınırlarındaki bir dizeyi ayırmanın en kolay yoludur. */
            string[] notalarParcalari = notalarStr.Split('-');
            string nota = notalarParcalari[0];
            int oktav = int.Parse(notalarParcalari[1]);
            string sure = notalarParcalari[2];

            // Seçtiğimiz nota ve oktav frekanslarını aldık.
            int frekans = notalar[nota][oktav - 1];
            int sureMs = sureler[sure];

            Console.Beep(frekans, sureMs); // Nota çalmamız için gerekli olan metod.

            Console.Write($"{nota}-{oktav}-{sure},"); // Çaldığımız nota, oktav, süreyi ekrana yazdırdık.
        }
    }
}
