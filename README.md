# C# WinForms – KNN ile Obezite Sınıflandırma Projesi

Bu proje, C# WinForms ve .NET Framework kullanılarak CSV formatındaki bir veri seti üzerinde
temel makine öğrenmesi (KNN) uygulamasını göstermek amacıyla geliştirilmiştir.

Amaç; veri okuma, ön işleme, sınıflandırma ve sonuç değerlendirme adımlarını uygulamalı olarak göstermektir.

---

## 📌 Projede Ne Yapıldı?

Bu projede sırasıyla şu işlemler yapılmıştır:

1. CSV dosyasının WinForms uygulamasına yüklenmesi  
2. Verilerin tablo (DataGridView) üzerinde gösterilmesi  
3. Sayısal verilerin normalize edilmesi  
4. Verilerin grafik ile görselleştirilmesi  
5. KNN algoritması ile sınıflandırma yapılması  
6. Model performansının accuracy, confusion matrix, precision ve recall ile değerlendirilmesi  

---

## 📊 Kullanılan Veri Seti

Veri seti obezite sınıflandırmasına aittir ve aşağıdaki özellikleri içerir:

- Yaş (Age)
- Boy (Height)
- Kilo (Weight)
- Beslenme ve yaşam alışkanlıkları
- **Hedef sütun:** `NObeyesdad`

`NObeyesdad` sütunu bireylerin kilo sınıfını belirtir (Normal_Weight, Overweight vb.)
ve KNN algoritmasında **label (hedef değişken)** olarak kullanılmıştır.

---

## 🔧 Kullanılan Teknolojiler

- C#
- WinForms
- .NET Framework
- CSV dosya okuma
- DataGridView
- Chart (Grafik)
- Temel makine öğrenmesi algoritması (KNN)

---

## 🔄 Normalizasyon (Ön İşleme)

KNN algoritması mesafeye dayalı olduğu için,
sayısal veriler Min–Max normalizasyonu ile 0–1 aralığına ölçeklendirilmiştir.

Bu işlem sayesinde:
- Büyük sayılar küçükleri ezmez
- Mesafe hesaplaması daha sağlıklı yapılır

Kategorik (metinsel) sütunlar mesafe hesabına dahil edilmemiştir.

---

## 🤖 KNN (K-Nearest Neighbors) Algoritması

KNN algoritması şu şekilde çalışır:

- Her bir veri satırı için
- Diğer satırlara olan mesafe hesaplanır
- En yakın **K adet komşu** seçilir
- Çoğunluk hangi sınıftaysa, tahmin o sınıf olur

Bu projede:
- K değeri **3** olarak seçilmiştir

---

## 📈 Model Değerlendirme

Model performansı aşağıdaki metriklerle değerlendirilmiştir:

- **Accuracy:** Doğru tahmin oranı  
- **Confusion Matrix:** Hangi sınıfların karıştığını gösterir  
- **Precision & Recall:** Sınıf bazlı başarıyı ölçer  

Elde edilen accuracy değeri yaklaşık **%54**’tür.
Bu değer, veri sayısının sınırlı olması ve sınıfların dengesizliği nedeniyle normal kabul edilmektedir.

Projenin amacı yüksek doğruluk değil, algoritmanın mantığını göstermektir.

---

## 🖼️ Uygulama Özellikleri

- CSV yükleme
- Tablo görünümü
- Normalizasyon sonrası grafik çizimi
- KNN çalıştırma
- Accuracy gösterimi
- Confusion Matrix tablosu
- Precision / Recall hesaplama

---

## 🧠 Akademik Not

Bu proje eğitim amaçlıdır.
Endüstriyel bir makine öğrenmesi performansı hedeflenmemiştir.
Amaç, ders kapsamında algoritma mantığını uygulamalı olarak göstermektir.

---

## ✅ Sonuç

Bu proje ile:
- C# WinForms kullanılarak veri işleme
- Temel makine öğrenmesi algoritması kullanımı
- Model değerlendirme metrikleri
başarıyla uygulanmıştır.

Ders kapsamında istenen tüm gereksinimler karşılanmıştır.
