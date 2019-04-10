using Registration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registraciya
{
    class Program
    {
        static void Main(string[] args)
        {
            Check registration = new Check();
            registration.ValidationCheck();
            registration.SendSms();
        }
    }
}
