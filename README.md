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


