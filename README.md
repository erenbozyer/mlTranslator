# 🌐 mlTranslator

![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![Windows Forms](https://img.shields.io/badge/Windows%20Forms-Local-blue?style=for-the-badge)
![Status](https://img.shields.io/badge/Durum-Tamamland%C4%B1-success?style=for-the-badge)

**mlTranslator**, C# ve Windows Forms (WinForms) kullanılarak geliştirilmiş, modern arayüze sahip, açık kaynaklı bir çoklu dil çeviri uygulamasıdır. Nesne Tabanlı Programlama (OOP) prensiplerine uygun olarak tasarlanmış ve asenkron mimari ile güçlendirilmiştir.

---

## 📸 Ekran Görüntüsü

[Uygulama Görüntüsü](screenshots/app.jpg)

---

## ✨ Özellikler

* **Çoklu Dil Desteği:** Türkçe, İngilizce, Almanca, Fransızca, İtalyanca, İspanyolca ve Rusça dilleri arasında anlık çeviri.
* **OOP Mimarisi:** İş mantığı (Business Logic) ve Arayüz (UI) birbirinden ayrılarak **SOLID** prensiplerine uygun tasarım yapılmıştır.
* **Asenkron Çalışma:** `async/await` yapısı sayesinde çeviri yapılırken arayüz donmaz.
* **REST API Entegrasyonu:** `HttpClient` kullanılarak MyMemory API ile JSON tabanlı veri alışverişi.
* **Modern Arayüz:** Kullanıcı dostu ve sade tasarım.
* **API Key Gerektirmez:** Ücretsiz ve açık kaynaklı API kullanımı.

---

## 🛠️ Kullanılan Teknolojiler ve Kütüphaneler

Bu proje geliştirilirken aşağıdaki teknolojiler kullanılmıştır:

* **Dil:** C#
* **Framework:** .NET Framework (Windows Forms Application)
* **IDE:** Visual Studio 2022
* **JSON İşleme:** [Newtonsoft.Json](https://www.nuget.org/packages/Newtonsoft.Json/)
* **API:** [MyMemory API](https://mymemory.translated.net/doc/spec.php)

---

## 📂 Proje Mimarisi

Proje, kod okunabilirliğini ve bakımını kolaylaştırmak için **katmanlı** bir yapıda tasarlanmıştır:

1.  **Form1.cs (UI Katmanı):**
    * Kullanıcı etkileşimlerini (Buton tıklama, metin girişi) yönetir.
    * `CeviriServisi` sınıfını çağırarak sonucu ekrana basar.
    
2.  **CeviriServisi.cs (Mantık Katmanı):**
    * Uygulamanın "Backend" mantığını içerir.
    * `HttpClient` ile dış dünyaya istek atar.
    * Gelen JSON verisini C# nesnelerine dönüştürür.
    * Hata yönetimi (Try-Catch) burada yapılır.

3.  **Modeller:**
    * `ApiResponse`, `ResponseData` ve `Dil` sınıfları, verileri düzenli tutmak için kullanılmıştır.

---

## 🚀 Kurulum ve Çalıştırma

Projeyi kendi bilgisayarınızda çalıştırmak için adımları izleyin:

1.  **Projeyi Klonlayın:**
    ```bash
    git clone https://github.com/erenbozyer/mlTranslator.git
    ```
2.  **Visual Studio ile Açın:**
    `mlTranslator.sln` dosyasını çift tıklayarak açın.
3.  **Paketleri Yükleyin:**
    Solution Explorer'da projeye sağ tıklayın ve **"Restore NuGet Packages"** diyerek `Newtonsoft.Json` kütüphanesinin inmesini sağlayın.
4.  **Çalıştırın:**
    `F5` tuşuna basarak veya "Start" butonuna tıklayarak uygulamayı başlatın.

---
