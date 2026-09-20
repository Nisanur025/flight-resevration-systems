# EN
# ✈️ Airline Reservation System (C# Windows Forms)

This project is an Airline Reservation Management System developed using C# Windows Forms architecture and local file management (File I/O) as a course graduation project. Without requiring any external database drivers, it securely stores and processes all system data in .txt format files.

📌 Features

🔒 User Authentication & Verification:

User credentials are read from text-based storage files.

Dynamic warning messages are displayed in case of incorrect email or password entries.

🛫 Flight Search & Listing:

Departure/Arrival locations (e.g., Turkey ➔ Germany) and airline information are dynamically retrieved from files.

Available flights are listed in a structured table format using DataGridView.

The user is notified if no flights match the search criteria.

💳 Card Verification & Payment:

Card details entered on the payment screen are verified against valid card records in the system.

If the card details are invalid, the transaction is rejected and the user is alerted.

🎟️ Ticket Generation & Download:

Upon successful payment, ticket details are saved to the project directory (downloadable in Flight_Ticket.txt format).

The user can access and view the generated ticket file directly from the project directory at any time.

👤 Profile & Ticket Management:

Users can view their active tickets on the Profile page.

Purchased tickets can be cancelled via the Profile screen; cancelled ticket statuses are updated in the data file.

⚠️ Error Handling & Notifications:

User-friendly notifications and error handling for cases such as failed login, invalid card information, empty inputs, or unavailable flights.

🛠️ Technologies & Requirements

Language: C# (.NET Framework)

UI Architecture: Windows Forms (WinForms)

Data Storage: File I/O (System.IO - StreamReader, StreamWriter, File.ReadAllLines)

Development Environment: Visual Studio 2022

📁 File Structure (Data Model)

The system uses the following text files as its data repository:

userinfo.txt: Stores user details such as name, surname, email, password, address, country, and phone number.

login.txt: Contains user email and password credentials for login verification.

Availableflights.txt: Holds departure, arrival, airline name, flight date, and pricing information.

cardInfo.txt: Contains valid card numbers and expiration dates for payment verification.

seatStatus.txt: Tracks available and occupied seat allocations.

task.txt: Saves the user's selected flight details to be read and displayed on the profile page.

🚀 How to Run

Clone or download the project repository to your local computer.

Open the solution file (.sln) using Visual Studio 2022.

Ensure all required .txt data files exist in the project directory.

Press F5 to build and run the application.

================================================================================

# TR
# ✈️ Uçak Rezervasyon Sistemi (C# Windows Forms)

Bu proje, C# Windows Forms mimarisi ve yerel dosya yönetimi (File I/O) kullanılarak geliştirilmiş bir **Uçak Rezervasyon Yönetim Sistemi** ders bitirme projesidir. Herhangi bir harici veritabanı sürücüsü gerektirmeden, tüm verileri `.txt`  formatındaki dosyalarda güvenli bir şekilde depolar ve işler.

---

## 📌 Özellikler

- **🔒 Kullanıcı Girişi ve Doğrulama:**
  - Kullanıcı kimlik bilgileri metin tabanlı veritabanı dosyasından okunur.
  - Hatalı kullanıcı adı veya şifre girişlerinde dinamik uyarı mesajları verilir.

- **🛫 Uçuş Arama ve Listeleme:**
  - Kalkış/Varış noktaları (örneğin: Türkiye ➔ Almanya) ve havayolu şirketleri dosyalardan dinamik olarak çekilir.
  - Uygun uçuşlar `DataGridView` üzerinde düzenli bir tablo halinde listelenir.
  - Aranan kriterlere uygun uçuş bulunamadığında kullanıcı bilgilendirilir.

- **💳 Kart Doğrulama ve Ödeme:**
  - Ödeme ekranında girilen kart bilgileri, sistemdeki geçerli kart verileriyle karşılaştırılarak doğrulanır.
  - Kart bilgileri hatalı ise işlem reddedilir ve kullanıcı uyarılır.

- **🎟️ Bilet Oluşturma ve İndirme:**
  - Ödeme başarıyla tamamlandığında bilet bilgileri proje klasörüne kayıt olarak yazılır (`Flight_Ticket.txt` formatında indirilir).
  - Kullanıcı dilediği zaman bilet çıktısını proje klasöründen erişilebilir şekilde kaydedebilir.

- **👤 Profil ve Bilet Yönetimi:**
  - Kullanıcı profil sayfasından aktif biletini görüntüleyebilir.
  - Satın alınan biletler profil ekranı üzerinden iptal edilebilir; iptal edilen biletlerin durumu dosyada güncellenir.

- **⚠️ Hata ve Bildirim Yönetimi:**
  - Hatalı giriş, geçersiz kart bilgisi, boş alan bırakılması veya uçuş bulunamaması gibi durumlar için uyarılar gösterilir.

---

## 🛠️ Teknolojiler ve Gereksinimler

- **Dil:** C# (.NET Framework)
- **Arayüz:** Windows Forms
- **Veri Depolama:** File I/O (`System.IO` - StreamReader, StreamWriter, File.ReadAllLines)
- **Geliştirme Ortamı:** Visual Studio 2022

---

## 📁 Dosya Yapısı (Veri Modeli)

Sistem aşağıdaki metin dosyalarını veri deposu olarak kullanır:

- `userinfo.txt`: Kullanıcı adı, soyadı, email, şifre, adres, ülke ve telefon bilgilerini içerir.
- `login.txt`: Kullanıcı email ve şifre bilgilerini tutar.
- `Availableflights.txt`: Kalkış yeri, varış yeri, havayolu, tarih ve fiyat bilgilerini içerir.
- `cardInfo.txt`: Ödeme doğrulaması için geçerli kart numaraları ve son kullanma tarihlerini barındırır.
- `seatStatus.txt`: Boş ve dolu koltuk bilgilerini barındırır.
- `task.txt`: Kullanıcının uçuş seçimi kaydedilerek profil sayfasında dosyadan okunarak gösterilir.

---

## 🚀 Projenin Çalıştırılması

1. Proje dosyalarını bilgisayarınıza indirin veya klonlayın.
2. Visual Studio ile `.sln` uzantılı çözüm dosyasını açın.
3. Proje klasöründeki `.txt` veri dosyalarının varlığından emin olun.
4. `F5` tuşuna basarak projeyi derleyin ve çalıştırın.
