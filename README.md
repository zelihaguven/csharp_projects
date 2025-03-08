# C# Konsol Uygulamaları

Bu repository, C# dilinde yazılmış birkaç konsol uygulamasını içermektedir. Uygulamalar, kullanıcıdan alınan girdilere göre çeşitli işlemler yapmaktadır. Aşağıda her bir uygulamanın kısa bir açıklaması ve nasıl çalıştığına dair bilgiler bulunmaktadır.

## Projeler

Tabii! İşte uçuşların ve pilotların yönetimi için geliştirdiğiniz sistem için örnek bir README.md dosyası:

⸻

## Uçuş Yönetim Sistemi 

Bu proje, hava yolu şirketleri, uçuşlar, uçaklar, pilotlar ve havaalanları ile ilgili bilgilerin yönetimini sağlayan bir yazılım sistemidir. Sistem, uçuşların, pilotların ve uçakların durumu hakkında bilgi sağlar ve hava yolu şirketi operasyonlarını yönetmek için kullanılır.

## Özellikler
	•	Hava Yolu Şirketleri: Her hava yolu şirketinin bir kimliği vardır ve uçaklar ile pilotları yönetir.
	•	Uçaklar: Uçaklar belirli bir tipe (model) sahip olup, çalışır ya da onarım durumunda olabilir.
	•	Pilotlar: Her pilotun deneyim seviyesi bulunmaktadır ve uçuşlarda kaptan veya yardımcı pilot olarak görev alabilirler.
	•	Uçuşlar: Her uçuşun benzersiz kimliği, kalkış ve iniş saatleri, kalkış ve iniş havaalanları, kaptan ve yardımcı pilot bilgileri vardır.
	•	Havaalanları: Havaalanlarının benzersiz kimlikleri ve isimleri vardır.

## Sistem Bileşenleri
	1.	Airport (Havaalanı): Havaalanlarının benzersiz kimlikleri ve isimlerini içerir.
	2.	Airplane (Uçak): Uçaklar, tiplerine göre yönetilir ve her uçak çalışır ya da onarım durumundadır.
	3.	Pilot (Pilot): Pilotlar, deneyim seviyesi ve isimleri ile birlikte sistemde tanımlanır.
	4.	Flight (Uçuş): Uçuşlar, kalkış ve iniş saatleri, kalkış ve iniş havaalanları ile birlikte yönetilir.
	5.	Airline (Hava Yolu Şirketi): Hava yolu şirketi, uçakları, pilotları ve uçuşları yönetir.

# Kullanım
	1.	Proje Yapılandırması: Bu projede C# kullanılarak sınıf yapıları oluşturulmuş ve her sınıfın kendi özellikleri ve işlevsellikleri tanımlanmıştır.
	2.	Ana Sınıf - Program: Sistemin çalıştığı ana sınıf olan Program sınıfı, uçuşlar, pilotlar, uçaklar ve havaalanları gibi nesnelerin örneklerini oluşturur. Bu nesneler daha sonra birbirleriyle ilişkilendirilir ve uçuş bilgileri yazdırılır.
	3.	Sınıf Etkileşimleri:
	•	Airline: Uçaklar, pilotlar ve uçuşlar bu sınıf aracılığıyla yönetilir.
	•	Airplane: Uçaklar, bir AirplaneType nesnesine sahip olup, her uçak bir kimlik ve çalışma durumu ile tanımlanır.
	•	Pilot: Pilotlar, deneyim seviyeleri ile birlikte uçuşlarda görev alırlar.
	•	Flight: Her uçuşun kalkış/iniş bilgileri ve pilotları bu sınıfta tanımlanır.
	4.	Sistemin Çalışma Prensibi:
	•	Hava yolu şirketi birden fazla uçak, pilot ve uçuş yönetebilir.
	•	Her uçuşun bir kalkış ve iniş noktası vardır.
	•	Uçuşlar, belirli bir zaman diliminde gerçekleşir ve pilotlar bu uçuşlara atanır.
	•	Her uçuş, belirli bir uçak tipi kullanır ve her uçak tipi belirli sayıda pilot gerektirir.


# Örnek çıktı:

Flight ID: F1
Departure: Istanbul Airport at 2025-03-10 14:00:00
Arrival: London Heathrow at 2025-03-10 17:00:00
Captain: John Doe, CoPilot: Jane Smith
Airplane Model: Boeing 747

# Hayvanat Bahçesi Yönetim Sistemi

Bu proje, farklı hayvan grupları (atlar, kedigiller, kemirgenler vb.) için beslenme düzeni ve ilaç dozajı hesaplamaları yapan bir yönetim sistemini simüle etmektedir. Polimorfizm kullanarak her hayvan türü için özelleştirilmiş hesaplama yöntemleri uygulanmıştır.

## Özellikler

- **Hayvan Sınıfları**: Atlar, kedigiller, kemirgenler gibi farklı hayvan türleri sınıflandırılmıştır.
- **İlaç Dozajı Hesaplaması**: Her hayvan türü için özel dozaj hesaplama fonksiyonları mevcuttur.
- **Yem Verme Zamanı**: Her hayvan türüne özel yem verme zamanları hesaplanmaktadır.
  

## Sınıflar ve Metodlar

### `Animals` Sınıfı
Tüm hayvanlar için ortak özellikleri içerir. Her hayvanın adı, ağırlığı ve yaşı bulunmaktadır. Ayrıca, tüm hayvanlar için genel dozaj ve yem verme zamanı hesaplamak için sanal (`virtual`) metodlar tanımlanmıştır.

- **Özellikler**:
  - `name`: Hayvanın adı.
  - `weight`: Hayvanın ağırlığı.
  - `age`: Hayvanın yaşı.

- **Metodlar**:
  - `GetDosage()`: Hayvanın ilaç dozajını hesaplar. (Polimorfizm ile her alt sınıf tarafından özelleştirilebilir)
  - `GetFeedSchedule()`: Hayvanın yem verme zamanını döndürür. (Polimorfizm ile her alt sınıf tarafından özelleştirilebilir)

### `Horses` Sınıfı
Atlar için özel bir sınıftır. `GetDosage()` ve `GetFeedSchedule()` metodlarını özelleştirir.

- **Özelleştirilmiş Metodlar**:
  - `GetDosage()`: Atlar için özel dozaj hesaplama formülü kullanır.
  - `GetFeedSchedule()`: Atlar için yem verme zamanlarını döndürür.

### `Cats` Sınıfı
Kedigiller (örneğin aslanlar) için özel bir sınıftır. `GetDosage()` ve `GetFeedSchedule()` metodlarını özelleştirir.

- **Özelleştirilmiş Metodlar**:
  - `GetDosage()`: Kediler için özel dozaj hesaplama formülü kullanır.
  - `GetFeedSchedule()`: Kediler için yem verme zamanlarını döndürür.

### `Chewer` Sınıfı
Kemirgenler (örneğin kunduzlar) için özel bir sınıftır. `GetDosage()` ve `GetFeedSchedule()` metodlarını özelleştirir.

- **Özelleştirilmiş Metodlar**:
  - `GetDosage()`: Kemirgenler için özel dozaj hesaplama formülü kullanır.
  - `GetFeedSchedule()`: Kemirgenler için yem verme zamanlarını döndürür.


# Film Sistemi

Bu uygulama, kullanıcılara online film kiralama ve satın alma imkanı sunan bir sistemin tasarımını sunmaktadır. Kullanıcılar, sisteme abone olarak film kiralayabilir ve kredi satın alabilirler. Ayrıca, film satın almak da mümkündür. Eğer film mevcut değilse, kullanıcılar bu filmi talep edebilirler.

## Sistemdeki Bileşenler

1. **Kullanıcılar**
   - **Normal Kullanıcı**: Film satın alabilir, ancak kredi ile film kiralayamaz.
   - **Abone Kullanıcı**: Film satın alabilir, kredi ile film kiralayabilir.

2. **Filmler**
   - Her filmin adı, türü, fiyatı ve mevcut durumu (mevcut veya talep edilmekte) vardır.

3. **Kredi Sistemi**
   - Kullanıcıların kredi satın alabilmesini sağlar ve sadece abone olan kullanıcılar kredilerini kullanarak film kiralayabilirler.

4. **Film Kiralama**
   - Aboneler yalnızca mevcut filmleri kiralayabilir. Kiralama işlemi, kullanıcının kredi miktarına göre yapılır.

5. **Talep Edilen Filmler**
   - Mevcut olmayan filmler talep edilebilir ve bir süre sonra sisteme eklenebilir.

### 1. Daire Çizimi

Bu uygulama, kullanıcıdan bir yarıçap alarak konsolda bir daire çizer.

#### Kullanım
1. Uygulamayı çalıştırın.
2. Dairenin yarıçapını girin.
3. Uygulama, belirtilen yarıçapa göre bir daire çizecektir.

### 2. Üçgen Çizimi

Bu uygulama, kullanıcıdan bir kenar sayısı alarak konsolda bir üçgen çizer.

#### Kullanım
1. Uygulamayı çalıştırın.
2. Üçgenin kenar sayısını girin (en az 3).
3. Uygulama, belirtilen kenar sayısına göre bir üçgen çizecektir.

### 3. Karakter Çıkarma

Bu uygulama, kullanıcıdan bir string ve bir indeks alarak belirtilen indeksteki karakteri çıkarır.

#### Kullanım
1. Uygulamayı çalıştırın.
2. Bir kelime ve bir indeks girin (örneğin: `Algoritma,3`).
3. Uygulama, belirtilen indeksteki karakteri çıkararak sonucu gösterecektir.

### 4. Fibonacci ve Ortalama Hesaplama

Bu uygulama, kullanıcıdan Fibonacci serisindeki terim sayısını alarak bu seriyi oluşturur ve ortalamasını hesaplar.

#### Kullanım
1. Uygulamayı çalıştırın.
2. Fibonacci serisindeki terim sayısını girin.
3. Uygulama, Fibonacci serisini ve ortalamasını gösterecektir.
 
### 5. Karakter Değiştirme

Bu uygulama, kullanıcıdan alınan bir string ifade içerisindeki karakterleri bir önceki karakter ile yer değiştirir.

#### Kullanım
1. Uygulamayı çalıştırın.
2. Bir string ifade girin (örneğin: `Merhaba Hello Question`).
3. Uygulama, her iki ardışık karakterin yerini değiştirerek sonucu gösterecektir.

### 6. Alan-Çevre Hesabı Yapma

## Uygulama Özellikleri
- Kullanıcıdan işlem yapmak istediği geometrik şekli (Dikdörtgen, Daire, Üçgen) alır.
- Seçilen şekle göre, kenar bilgilerini kullanıcıdan alır.
- Hesaplanmak istenen boyutu (Alan, Çevre) kullanıcıdan alır.
- Hesap sonucunu anlaşılır bir şekilde geri döndürür.

## Kullanım
1. Uygulamayı çalıştırın.
2. İşlem yapmak istediğiniz şekli girin (Dikdörtgen, Daire, Üçgen).
3. Seçtiğiniz şekle göre gerekli kenar bilgilerini girin.
4. Hesaplamak istediğiniz boyutu (alan/çevre) girin.
5. Uygulama, belirtilen şeklin alanını veya çevresini hesaplayarak sonucu gösterecektir.


