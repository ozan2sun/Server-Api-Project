### Server Api Projesi ###
</br>
<p>Collection Adı : Kişi 
Alanlar: 
TC Kimlik No: integer, TcKimlik son 5 rakamı, değiştirilemez olmalı Ad: string, maksimum 20 karakter, giriş zorunlu Soyadı: string, maksimum 50 karakter, giriş zorunlu, Büyük Harf olacak Doğum Tarihi: Date, giriş zorunlu, En az 20 yaşında olacak. Cinsiyet: string, bir karakter maksimum, Enum(E veya K) · Lokal Sunucunu Yaratı ve Lokal Wep API sunucunu yaratıldı.  Denemeler lokal database ile yapıldı. o “/”: Tüm kişileri adına göre sıralandı. o “/ben/12345”: TcKimlik nosu girilen kişi gösterildi o “/ekle/”: yeni kişi eklendi (bodyden) o “/degistir/”:kişi değiştir (bilgileri bodyden al) id ye göre değiştirildi. o “sil:/{isim}/{soyisim}/”: Ad soyadı bilgisine göre kişi silindi o “/dogumgünü/5”: Mayıs ayında doğanları gençten yaşlıya göre sıralandı. (ad, soyadı, yaş)</p>
