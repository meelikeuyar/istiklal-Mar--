# 🇹🇷 İstiklal Marşı — Console.Beep() ile

Türkiye Cumhuriyeti İstiklal Marşı'nı **nota nota** bilgisayar hoparlöründen çalan bir C# konsol uygulaması.

## 🎵 Nasıl Çalışır?

- Her müzik notasının (DO, RE, MI, FA, SOL, LA, SI) 8 oktavdaki frekansları bir sözlükte tutulur.
- Marşın notaları `"SI-5-yarim,MI-5-ceyrek,..."` formatında sıralanır.
- Program bu notaları tek tek okuyup `Console.Beep(frekans, süre)` ile çalar.

## 🚀 Çalıştırma

**.NET 6 SDK** ve **Windows** gereklidir (`Console.Beep` yalnızca Windows'ta ses üretir).

```bash
cd IstiklalMarsi
dotnet run
```

## 📝 Not

Bu proje bir üniversite ödevi olarak hazırlanmıştır.
 
