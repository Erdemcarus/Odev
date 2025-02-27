ABSTRACT CLASS NEDİR:

Abstract classların kullanılma amacı, temel sınıfı tanımlamaktır. Hiyerarşik düzende en üst class’ın tanımlanması olarak yorumlayabilirsiniz. Yeni türetilecek olan classlar, abstract keyword’ü verilen class üzerinden türeyecektir.
Abstract classların en önemli detaylarından biri new keyword’ü ile nesne türetemez. Türeyememe nedeni, base class olmasından kaynaklıdır. Nesne oluşturamıyoruz ama kalıtım özelliğini kullanabiliriz, kod tekrarını azaltmış oluruz. 


ABSTRACTİON (SOYUTLAMA) NEDİR:
Karmaşıklığı yönetmek için kullanılır. Nesnenin diğer tüm nesne türlerinden ayıran temel özelliklerini belirtir, böylece izleyicinin bakış açısından açıkça tanımlanmış bir kavramsal sınır sağlar. Nesne yönelimli programlamada, ayırma, ayrıntıları tanımlamaktan ziyade sınıflar veya yöntemler için temel görevleri tanımlamak anlamına gelir. Temel olarak, problemi çözmek için kullanılan yöntem öncelikle daha genel, daha basit ve soyut olmalıdır.
Örneğin Bir daire, kare, üçgen tanımlarken bunları soyut olan bir şekilden somut olarak düşünerek bir nesneye çeviririz. Şeklin bir nesneye çevrilmesi işte bu gibi durumlarda OOP yapısına aykırı olacaktır . Çünkü şekil sadece türetmek (somut bir nesneyi oluşturma içindir) ama kendisinden nesne oluşturulması durumunda gereksiz bir sınıf ortaya çıkacaktır.

POLYMORPHİSM(ÇOK BİÇİMLİLİK)NEDİR:
Polymorphism bir sınıfa aynı isimde farklı uygulamalar yapabilme özelliği sağlar.
2 tür polimorphism (çok biçimlilik) vardır;
1.	Compile Time Polymorphism (Derleme Zamanı Çok Biçimlilik)
2.	Runtime Polymorphism (Çalışma Zamanı Çok Biçimlilik)
Compile Time Polymorphism
Metot aşırı yükleme (overloading) bir compile time polymorphism örneğidir. Overloading aynı isme sahip metotların farklı parametreler alacak şekilde tanımlanmasıdır. Compile Time denmesinin sebebi hangi metodun çağırılacağına derleme zamanı karar verileceğidir. C# Compiler (Derleyici) parametrelerin sayısına ve parametre türüne bakar ve eşleşen metodu çağırır. Eğer eşleşen metot yoksa hata verir.


Runtime Polymorphism
Metot override (geçersiz kılma) Runtime Polymorphism’in bir örneğidir. Burada metot adı ve metot parametreleri farklı olabilir. Kalıtım alınan sınıf içerisinde overriding işlemi yapılır ve metot değiştirilir. Metot overriding yapısında, temel sınıf ile türettiğimiz sınıf aynı metot adı ve özelliklerine de sahip olabilir. Temel sınıftan oluşturduğumuz instance nesnesi içerisinde overriding yapmamız için istenen metot temel sınıf içerisinde virtual olarak tanımlanır. 

