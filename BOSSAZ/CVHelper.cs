using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOSSAZ
{
    public static class CVHelper
    {
        public static CV CreateNewCV()
        {
            Console.Write("Enter speciality: ");
            string speciality = Console.ReadLine();
            Console.Write("Enter city: ");
            string city = Console.ReadLine();
            Console.Write("Enter school: ");
            string school = Console.ReadLine();
            Console.Write("Enter linkedin: ");
            string linkedin = Console.ReadLine();
            Console.Write("Enter gitlink: ");
            string gitLink = Console.ReadLine();
            Console.Write("Enter foreign language: ");
            string foreignLanguage = Console.ReadLine();
            Console.Write("Enter worked companies: ");
            string workedCompanies = Console.ReadLine();
            Console.Write("Enter skills: ");
            string skills = Console.ReadLine();
            Console.Write("Enter accept score: ");
            string acceptScore = Console.ReadLine();

            Console.Write("Enter started date with this format(Month/Day/Year) input this => / symbol to(ex: 12/21/2012): ");
            string started = Console.ReadLine();
            Console.Write("Enter end date with this format(Month/Day/Year) input this => / symbol to(ex: 12/21/2012): ");
            string ended = Console.ReadLine();
            Console.Clear();


            DateTime start = Convert.ToDateTime(started);
            DateTime end = Convert.ToDateTime(ended);

            CV cv = new CV(speciality, city, school, linkedin, gitLink, foreignLanguage, workedCompanies, skills, acceptScore,
                start, end);

            --UniqueStaticID.id;
            return cv;
        }

    }
}

