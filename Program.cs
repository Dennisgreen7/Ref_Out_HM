using System;

namespace Ref_Out_HM
{
    class Program
    {
        public static void addnum(ref int num)
        {
            num++;
        }
        public static void addval(out int num)
        {
            Console.WriteLine("Enter num");
            num = int.Parse(Console.ReadLine());
        }
        public static string ValidateValues(string name_,string last_name,string phone_num,string tz,int age, out string erormessege)
        {
            erormessege = "";
            if(name_ == "" ||name_ == ""null|| last_name == ""|| last_name == null)
            {
                erormessege = "name or last name are empty";
                return erormessege;
            }
            if(phone_num[0] != '0'||phone_num.Length < 9)
            {
                erormessege = " phone number must start with 0";
                return erormessege;
            }
            if(tz.Length != 9)
            {
                erormessege = " tz must be 9 digits";
                return erormessege;
            }
            if(age < 1 || age > 120)
            {
                erormessege = "age out of rage 1-120";

                return erormessege;
            }
            return "True";
        }
        static void Main(string[] args)
        {
            int a = 0;
            int b = 1;
            //addnum(ref a);
            //addnum(ref b);
            //Console.WriteLine("a = "+a+", b = "+b);
            int c, d;
            //addval(out c);
            //addval(out d);
            //Console.WriteLine("c = " + c + ", d = " + d);
            string erormessege;
            string a1 = ValidateValues("d", "greenberg", "0526551089", "315976233", 25,out erormessege);
            Console.WriteLine(a1);
            Console.ReadLine();
        }
    }
}
