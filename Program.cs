using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ArabicText
{
    class Program //الصنف
    {
        public static void Main() // وسيلة برمجية ثابتة
        {
            Console.OutputEncoding = Encoding.UTF8; //يو تي إف 8  تتيح حروفاً بلغات متعددة
            Program program = new Program(); // أنشأت مثيلاً عن الصنف ءءء برنامج ءءء
            program.Arabi("أدخل 1 أو 2 أو 3 أو 4");//بدايةُ البُرَيْمِجِ
            string edkhal = Console.ReadLine();// لاستقبال المعطيات من المستخدم
            // صيغة إِمَّاْ أَوْ
            if (edkhal == "1") { program.Arabi("أيمن الأفندي"); }
            else if (edkhal == "2") { Console.WriteLine("Ayman Alafandy"); }
            else if (edkhal == "3") { program.Arabi("نحتاج لغة برمجة عربية"); }
            else { Console.WriteLine("We need arabic programming language"); }
            Console.Read();//لإيقاف البرنامج مؤقتاً حتى يقوم المستخدم بأيِّ إدخالٍ للإغلاقِ
        }
        //ءءءالوسيلة البرمجية ءءء أنشأتُها لترتيب الحروف من اليمين إلى اليسار
        public string Arabi(string arabicString)
        {
            char[] arabi = arabicString.ToCharArray();//تحويل نص إلى مصفوفة حروف و إسناده لمتغير
            Array.Reverse(arabi);// عَكْسُ ترتيب مصفوفةِ الحروفِ
            string str = new string(arabi);//إعادة تحويل المصفوفة إلى نص مع إسنادها لمتغير
            Console.WriteLine(str);//طباعة الناتج
            return (str);//إعادة قيمة الناتج
        }
    }
}
