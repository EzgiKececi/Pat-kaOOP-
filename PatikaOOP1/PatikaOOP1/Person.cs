using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaOOP1
{
    public class Person
    {
        //Person sınıfına ait field'lar
        private string name;
        private string surname;
        private int birthDate;

        //Properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        public int BirthDate
        {
            get { return birthDate; }

            set
            {
                if (value > 0)
                {
                    birthDate = value;
                }
                else
                    Console.WriteLine("Yanlış bir tarih girildi.");
            }
        }

        //Kişi detaylarını konsola yazdırmak için metot oluşturma
        public void TeacherInfo()
        {
            Console.WriteLine($"Öğretmenin adı : {Name}\nÖğretmenin soyadı : {surname}\nÖğretmenin doğum yılı: {birthDate}");

        }

        public void StudentInfo()
        {
            Console.WriteLine($"Öğrencinin adı : {name}\nÖğrencinin soyadı : {surname}\nÖğrencinin doğum yılı : {birthDate}");
        }
    }
}
