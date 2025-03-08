# C# Konsol Uygulamaları

Bu repository, C# dilinde yazılmış birkaç konsol uygulamasını içermektedir. Uygulamalar, kullanıcıdan alınan girdilere göre çeşitli işlemler yapmaktadır. Aşağıda her bir uygulamanın kısa bir açıklaması ve nasıl çalıştığına dair bilgiler bulunmaktadır.

---

## Barcode Generator/Reader Uygulaması

Bu uygulama, kullanıcının metin girerek barcode üretmesini sağlar ve daha sonra bu barcode'u bir dosyaya kaydeder. Barcode daha sonra bir resim dosyasından okunarak geri döndürülür.

### Gereksinimler
- **.NET Core Console Application**
- **ZXing.Net Kütüphanesi**

### Kullanılan Kütüphane
Bu uygulama için ZXing.Net kütüphanesi kullanılmıştır. ZXing.Net, barcode üretimi ve okunmasını sağlar.

---

## ATM Uygulaması 

Bu ATM uygulaması, kullanıcıların çeşitli bankacılık işlemleri yapabilmesini sağlar. Kullanıcılar para çekme, para yatırma, ödeme yapma gibi işlemleri gerçekleştirebilirler. Ayrıca, gün sonu raporu (EOD) alabilir ve işlem geçmişini dosyaya kaydedebilirler.

### Özellikler

- **Kullanıcı Doğrulaması:**
  - Kullanıcılar, kullanıcı adı ve şifre ile sisteme giriş yaparlar.
  - Geçersiz girişler fraud loguna kaydedilir.
  
- **İşlemler:**
  - **Para Çekme**: Kullanıcılar hesaplarından para çekebilirler.
  - **Para Yatırma**: Kullanıcılar hesabına para yatırabilirler.
  - **Ödeme Yapma**: Kullanıcılar ödeme yapabilirler.
  
- **Gün Sonu (EOD) Raporu:**
  - Kullanıcılar "End of Day" raporunu alabilirler.
  - Tüm işlemler ve hatalı girişler bir dosyaya kaydedilir.
  
- **Fraud Log:**
  - Hatalı girişler kaydedilir ve fraud loguna eklenir.

### Kullanıcı Girişi
Kullanıcı adı ve şifre, `registeredUsers` sözlüğünde saklanır. Kullanıcı doğrulaması yapıldıktan sonra ATM işlemleri yapılabilir.

### İşlem Günlüğü
Her işlem yapıldığında işlem kaydı `transactionLog` listesine eklenir. Bu liste, gün sonu raporunda dosyaya yazılır.

### Gün Sonu (EOD) Raporu
- Rapor, o günkü tüm işlemleri ve hatalı girişleri içerir.
- Rapor, bilgisayarınızdaki çalışma dizinine `.txt` formatında kaydedilir. Dosya adı şu formatta olur: `EOD_DDMMYYYY.txt`.

### Kullanım Adımları

1. **Giriş Yapın:**
   - Kullanıcı adı ve şifre girin.
   
2. **İşlem Seçin:**
   - Para çekme, para yatırma veya ödeme yapma işlemlerini seçin.
   
3. **Gün Sonu Raporu:**
   - Gün sonu raporu almak için `EOD` seçeneğini kullanın.

4. **Çıkış Yapın:**
   - ATM uygulamasından çıkmak için "Exit" seçeneğini seçin.

---

## Voting Uygulaması Tasarımı

Bu uygulama, kullanıcıların belirli kategorilerde oylama yapmalarını sağlayan bir sistemdir. Kullanıcılar sadece sisteme kayıtlı olduklarında oy verebilirler. Uygulama sonunda oylama sonuçları rakamsal ve yüzdesel olarak gösterilecektir. Kullanıcılar kategorileri seçebilir, oylama yapabilir ve sisteme kaydolabilir.

### Sistemdeki Bileşenler

1. **Kategoriler**
   - Oylama yapılacak kategoriler önceden tanımlanmış olacak. Kullanıcılar bu kategorilerde oy kullanabilirler. 
   - Örnek Kategoriler:
     - **Film Kategorileri**: En iyi film, En iyi oyuncu, En iyi yönetmen
     - **Tech Stack Kategorileri**: En iyi yazılım dili, En iyi framework
     - **Spor Kategorileri**: En iyi futbolcu, En iyi takım

2. **Kullanıcılar**
   - Sisteme kayıtlı kullanıcılar oylama yapabilirler.
   - Kullanıcılar, kullanıcı adıyla sisteme giriş yapar ve eğer sisteme kayıtlı değillerse kaydolabilirler.

3. **Oylama Sistemi**
   - Sisteme giriş yapan kullanıcılar, listelenen kategorilerde oy kullanabilirler.
   - Oy kullanımı, her kategoriye bir oy ile sınırlıdır.

4. **Sonuçlar**
   - Oylama bitiminde, her kategori için sonuçlar rakamsal ve yüzdesel olarak gösterilecektir.

### Temel Özellikler

1. **Pre-defined Kategoriler**
   - Film, Tech Stack ve Spor gibi kategoriler önceden belirlenmiş ve kullanıcıya oylama için sunulacak.

2. **Kullanıcı Kaydı ve Girişi**
   - Kayıtlı kullanıcılar giriş yaparak oylamaya başlayabilirler.
   - Eğer kullanıcı kayıtlı değilse, kullanıcı adı ile kaydolmasına olanak sağlanacaktır.
   
3. **Oylama**
   - Her kategori için kullanıcıya bir oy verdirilecektir.
   - Oylama sonucunda her kategori için oylama sonuçları gösterilecektir.

4. **Sonuç Gösterimi**
   - Oylama bitiminde her kategori için toplam oy sayısı ve yüzdesel dağılım görüntülenecektir.

### Kullanılacak Teknikler

- **Veritabanı**: Kullanıcıların bilgilerini ve oylama sonuçlarını saklamak için basit bir veritabanı kullanılabilir.
- **C# veya Python**: Sunucu tarafında oylama işlemleri ve kullanıcı kayıtları yönetilecektir.
- **CLI veya GUI**: Kullanıcıların oylama yapmasını sağlayan bir komut satırı arayüzü veya basit bir grafiksel kullanıcı arayüzü (GUI) kullanılabilir.

### Akış

#### 1. Kullanıcı Kaydı / Girişi
Kullanıcı, ilk olarak sistemde kaydolmak için kullanıcı adı girecektir. Eğer kullanıcı adı mevcutsa, sisteme giriş yapılır. Değilse, kullanıcı kaydı oluşturulur.

#### 2. Oylama
Kullanıcı sisteme giriş yaptıktan sonra, pre-defined kategoriler sunulur. Kullanıcı her kategori için bir oy verebilir.

#### 3. Sonuçlar
Oylama tamamlandığında, her kategorinin oy sonuçları hem rakamsal hem de yüzdesel olarak gösterilecektir.

#### 4. Uygulama Sonlandırma
Son olarak, kullanıcılar oylama sonuçlarını görüp, uygulama sonlandırılacaktır.     

---

## Uçuş Yönetim Sistemi

Bu proje, hava yolu şirketleri, uçuşlar, uçaklar, pilotlar ve havaalanları ile ilgili bilgilerin yönetimini sağlayan bir yazılım sistemidir. Sistem, uçuşların, pilotların ve uçakların durumu hakkında bilgi sağlar ve hava yolu şirketi operasyonlarını yönetmek için kullanılır.

### Özellikler
- **Hava Yolu Şirketleri**: Her hava yolu şirketinin bir kimliği vardır ve uçaklar ile pilotları yönetir.
- **Uçaklar**: Uçaklar belirli bir tipe (model) sahip olup, çalışır ya da onarım durumunda olabilir.
- **Pilotlar**: Her pilotun deneyim seviyesi bulunmaktadır ve uçuşlarda kaptan veya yardımcı pilot olarak görev alabilirler.
- **Uçuşlar**: Her uçuşun benzersiz kimliği, kalkış ve iniş saatleri, kalkış ve iniş havaalanları, kaptan ve yardımcı pilot bilgileri vardır.
- **Havaalanları**: Havaalanlarının benzersiz kimlikleri ve isimleri vardır.

### Sistem Bileşenleri
1. **Airport (Havaalanı)**: Havaalanlarının benzersiz kimlikleri ve isimlerini içerir.
2. **Airplane (Uçak)**: Uçaklar, tiplerine göre yönetilir ve her uçak çalışır ya da onarım durumundadır.
3. **Pilot (Pilot)**: Pilotlar, deneyim seviyesi ve isimleri ile birlikte sistemde tanımlanır.
4. **Flight (Uçuş)**: Uçuşlar, kalkış ve iniş saatleri, kalkış ve iniş havaalanları ile birlikte yönetilir.
5. **Airline (Hava Yolu Şirketi)**: Hava yolu şirketi, uçakları, pilotları ve uçuşları yönetir.

### Kullanım
1. **Proje Yapılandırması**: Bu projede C# kullanılarak sınıf yapıları oluşturulmuş ve her sınıfın kendi özellikleri ve işlevsellikleri tanımlanmıştır.
2. **Ana Sınıf - Program**: Sistemin çalıştığı ana sınıf olan Program sınıfı, uçuşlar, pilotlar, uçaklar ve havaalanları gibi nesnelerin örneklerini oluşturur. Bu nesneler daha sonra birbirleriyle ilişkilendirilir ve uçuş bilgileri yazdırılır.
3. **Sınıf Etkileşimleri**:
   - **Flight**: Bir uçuşun kalkış ve iniş zamanları, kalkış ve iniş havaalanları, pilot bilgileri gibi veriler içerir.
   - **Airline**: Hava yolu şirketinin uçakları ve pilotları içerir. Sistem, bu uçuşları yönlendirir ve uçuş bilgilerini gösterir.

---

# Matematiksel Projeler 

Bu repo, farklı matematiksel ve geometrik işlemleri gerçekleştiren basit uygulamaları içermektedir. Her bir uygulama, kullanıcının girdiği verilere göre çeşitli hesaplamalar yapar ve sonuçları gösterir.

---

### 1. Daire Çizimi

Bu uygulama, kullanıcıdan bir yarıçap alarak konsolda bir daire çizer.

#### Kullanım
1. Uygulamayı çalıştırın.
2. Dairenin yarıçapını girin.
3. Uygulama, belirtilen yarıçapa göre bir daire çizecektir.

---

### 2. Üçgen Çizimi

Bu uygulama, kullanıcıdan bir kenar sayısı alarak konsolda bir üçgen çizer.

#### Kullanım
1. Uygulamayı çalıştırın.
2. Üçgenin kenar sayısını girin (en az 3).
3. Uygulama, belirtilen kenar sayısına göre bir üçgen çizecektir.

---

### 3. Karakter Çıkarma

Bu uygulama, kullanıcıdan bir string ve bir indeks alarak belirtilen indeksteki karakteri çıkarır.

#### Kullanım
1. Uygulamayı çalıştırın.
2. Bir kelime ve bir indeks girin (örneğin: `Algoritma,3`).
3. Uygulama, belirtilen indeksteki karakteri çıkararak sonucu gösterecektir.

---

### 4. Fibonacci ve Ortalama Hesaplama

Bu uygulama, kullanıcıdan Fibonacci serisindeki terim sayısını alarak bu seriyi oluşturur ve ortalamasını hesaplar.

#### Kullanım
1. Uygulamayı çalıştırın.
2. Fibonacci serisindeki terim sayısını girin.
3. Uygulama, Fibonacci serisini ve ortalamasını gösterecektir.

---

### 5. Karakter Değiştirme

Bu uygulama, kullanıcıdan alınan bir string ifade içerisindeki karakterleri bir önceki karakter ile yer değiştirir.

#### Kullanım
1. Uygulamayı çalıştırın.
2. Bir string ifade girin (örneğin: `Merhaba Hello Question`).
3. Uygulama, her iki ardışık karakterin yerini değiştirerek sonucu gösterecektir.

---

### 6. Alan-Çevre Hesabı Yapma

Bu uygulama, kullanıcıdan işlem yapmak istediği geometrik şekli (Dikdörtgen, Daire, Üçgen) alır, seçilen şekle göre kenar bilgilerini kullanıcıdan alır ve hesaplanmak istenen boyutu (Alan, Çevre) kullanıcıdan alarak sonucu gösterir.

#### Kullanım
1. Uygulamayı çalıştırın.
2. İşlem yapmak istediğiniz şekli girin (Dikdörtgen, Daire, Üçgen).
3. Seçtiğiniz şekle göre gerekli kenar bilgilerini girin.
4. Hesaplamak istediğiniz boyutu (alan/çevre) girin.
5. Uygulama, belirtilen şeklin alanını veya çevresini hesaplayarak sonucu gösterecektir.
----

Bu repository, temel C# projeleri geliştirme ve uygulama yapmayı hedefleyenler için faydalı bir kaynak olabilir. Bu tür projeler üzerinde çalışarak, C# dilini ve temel programlama kavramlarını pekiştirebilirsiniz.
