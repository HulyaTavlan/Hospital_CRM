using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Toolbox
{
    //Bu sınıf daha kolay kullanım ve yüksek performans göstermesi için 'Singleton' tasarım şablonu kullanılarak çağırılacaktır.
    public class ValidationService
    {
        //Singleton: Bir sınıftan oturum boyunca bir daha örnek (instance) alınamaması için kullanılan bir şablondur. Bu sayede bu sınıf sadece bir kere üretilir. Bunun için sadece basit bir kapsülleme kullanılır. 
        //Önce sınıfın kendisini temsilen statik (static: Sabit bellek adresli) bir field oluşturulur.
        private static ValidationService instance;
        public static ValidationService Instance
        {
            get
            {
                //Bu sayede Okunan Instance sadece oturumun (session) ilk seferinde oluşturulur.
                if (instance == null)
                {
                    instance = new ValidationService();
                }
                return instance;
            }
        }

        public bool ValidateTCKN(string txt_tckno)
        {
            if (txt_tckno.Length == 11 && !txt_tckno.StartsWith("0"))
            {
                Int64.TryParse(txt_tckno, out long tckn);

                long test_tckn = tckn / 100, tekler = 0, ciftler = 0, s10, s11;
                long[] b = new long[9];
                for (int i = 8; i >= 0; i--)
                {
                    b[i] = test_tckn % 10; test_tckn /= 10;
                    if (i % 2 == 0)
                    {
                        tekler += b[i];
                    }
                    else
                    {
                        ciftler += b[i];
                    }
                }
                s10 = (tekler * 7 - ciftler) % 10;
                s11 = (tekler + ciftler + s10) % 10;
                return (s10 * 10 + s11) == tckn % 100;
            }
            return false;
        }

        public bool ValidateEMail(string txt_email)
        {
            string regex_template = @"^([\w\.-]+)@([\w-]+(\.\w{2,})+)$";
            Regex regex = new Regex(regex_template);
            return regex.IsMatch(txt_email);
        }

        public bool ValidatePhone(string txt_phone)
        {
            //https://tr.wikipedia.org/wiki/T%C3%BCrkiye_Ulusal_Numaraland%C4%B1rma_Plan%C4%B1
            string regex_template = @"^(\+90|90|0)?5[0345][0-9]{8}$";
            Regex regex = new Regex(regex_template);
            return regex.IsMatch(txt_phone);
        }
    }
}
