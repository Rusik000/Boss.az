using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOSSAZ
{
    public abstract class Human : UniqueStaticID
    {
        private string _name;
        private string _surname;
        private string _age;

        public Human(in string name, in string surname, in string age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = Verify.IsDataContainsOnlyLetters(value) ? value : throw new InvalidOperationException("Name contains space and letters.");
            }
        }
        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                _surname = Verify.IsDataContainsOnlyLetters(value) ? value : throw new InvalidOperationException("Surname contains space and letters.");
            }
        }
        public string Age
        {
            get
            {
                return _age;
            }
            set
            {
                _age = Verify.IsDataContainsOnlyIntegers(value) && Verify.IsPersonAgeMoreThanSeventeen(value) ? value : throw new InvalidOperationException("Age must contain numbers more than 17");
            }
        }

    }
}
