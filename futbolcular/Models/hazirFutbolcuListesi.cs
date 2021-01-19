using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace futbolcular.Models
{
    public class hazirFutbolcuListesi : List<futbocularx>
    {
        public hazirFutbolcuListesi()
        {
            this.Add(new futbocularx {ID=1,Ad="Thierry",Soyad="Henry",Yas=34,Url= "https://d3nfwcxd527z59.cloudfront.net/content/uploads/2019/07/29081249/Thierry-Herny-Arsenal-Real-Madrid-2006.jpg",Yazi= "Henry, gençlik yıllarında yerel takımında oynadığı ve büyük umut vadeden bir futbolcu olduğunu gösterdiği Paris'in varoş semtlerinden olan Les Ulis, Essonne'da doğdu ve yetişti. AS Monaco tarafından yetenekleri fark edilen Henry'le hemen sözleşme imzalandı ve Henry profesyonel anlamda sahalara ilk olarak 1994'te adım attı. Sergilediği güzel grafik onu İtalya şampiyonu Juventus'a transfer olmadan önce Fransa millî futbol takımına kadar yükseltti. Arsenal'e 10,5 milyon £'e transfer olmadan önce kanatta sergilediği performansla düş kırıklığı yaratan bir sezon geçirdi." });
            this.Add(new futbocularx { ID = 2, Ad = "David", Soyad = "Trezeguet", Yas = 32, Url = "https://thesefootballtimes.co/wp-content/uploads/2019/01/trezeguet.jpg" ,Yazi= "Trezeguet 1998 FIFA Dünya Kupası'nı kazanan takımda yer aldı. 2000 Avrupa Şampiyonası'nda final maçında İtalya'ya attığı altın golle takımına kupayı kazandırdı. Takımıyla beraber 2002 FIFA Dünya Kupası ve 2004 Avrupa Şampiyonası'nda da yer aldı. Mart 2004'te Yaşayan En İyi 125 futbolcu arasına seçildi." });
            this.Add(new futbocularx { ID = 3, Ad = "Patrick", Soyad = "Viera", Yas = 32, Url = "https://images.daznservices.com/di/library/GOAL/61/3a/patrick-vieira-arsenal_d9xgruk8pnfk1j0oqbbpzac9a.jpg?t=1602473340&quality=100",Yazi= "Patrick Donalé Vieira (d. 23 Haziran 1976, Dakar, Senegal[1]) Senegal asıllı Fransız eski futbolcudur. 2011'de futbolu bırakmıştır. Vieira, son olarak Manchester City forması giymiştir. Şu anda New York City'de teknik direktör olarak görev yapmaktadır." });

        }
    }
}