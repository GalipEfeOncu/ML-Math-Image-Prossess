# 📸 ML Matematik Temelleri ve Görüntü İşleme - Dönem Ödevi

Bu proje, Bilgisayarlı Görü (Computer Vision) ve Makine Öğrenmesi (ML) algoritmalarının temelinde yatan matematiksel işlemleri simüle etmek amacıyla hazırlanmıştır. Hazır bir ML kütüphanesi kullanılmadan, saf C# kodu ve matris operasyonları ile **Kenar Bulma (Edge Detection)** işlemi gerçekleştirilmiştir.

## 🚀 Proje Özellikleri
* **Kütüphanesiz Yaklaşım:** Görüntü işleme kütüphaneleri yerine doğrudan piksel matrisleri üzerinde matematiksel işlemler (türev alma) uygulanmıştır.
* **Sobel Mantığı:** Piksellerin renk yoğunluk farkları hesaplanarak, yapay zekanın görüntüleri algılamasındaki ilk adım olan "Feature Extraction" (Özellik Çıkarımı) manuel olarak kodlanmıştır.
* **Performans:** Büyük resimlerde bile döngülerin optimize çalışması hedeflenmiştir.

## 🛠 Kullanılan Teknolojiler
* **Dil:** C# (.NET Framework)
* **Arayüz:** Windows Forms (WinForms)
* **Yöntem:** `System.Drawing` ve Temel Matematik Algoritmaları

## 🧠 Nasıl Çalışır?
Uygulama, yüklenen resmin her bir pikselini gezer ve komşu piksellerle arasındaki renk farkını (gradient) hesaplar. Bu işlem, görüntüdeki ani renk değişimlerini (kenarları) ortaya çıkararak resmi analiz edilebilir bir veri matrisine dönüştürür.
