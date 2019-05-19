using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary_Application
{
    public class SozlukKelime : Kelime
    {
        //Bu metod sözlük dosyasına yazılacak bilgileri belirliyor.
        public override string YazilacaklariBelirle()
        {
            base.YazilacaklariBelirle();

            return kelimeAdi.ToLower() + "\t" + kelimeKarsiligi.ToLower() + "\t" + kelimeTuru.ToLower();
        }

    }
}
