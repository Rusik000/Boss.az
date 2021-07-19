using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOSSAZ
{

    public abstract class Require : UniqueStaticID
    {
        private string _speciality;
        private string _city;

        public Require(in string speciality, in string city)
        {
            Speciality = speciality;
            City = city;
        }

        public string Speciality
        {
            get
            {
                return _speciality;
            }
            set
            {
                _speciality = Verify.IsDataCorrectFormat(value) ? value : throw new InvalidOperationException("Speciality is not correct format");
            }
        }
        public string City
        {
            get
            {
                return _city;
            }
            set
            {
                _city = Verify.IsDataContainsOnlyLetters(value) ? value : throw new InvalidOperationException("City contains space and letters");
            }
        }
    }

}

