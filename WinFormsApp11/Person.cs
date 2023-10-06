using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp11
{
    public class Person
    {

        public  string ?Name{ get; set; }
        public  string ?Surname{ get; set; }
        public  string ?Fname{ get; set; }
        public  string ?Country{ get; set; }
        public  string ?City{ get; set; }
        public  string ?Phone{ get; set; }
        public DateTime Date { get; set; }
        public  string ?Gender{ get; set; }
        public Person(string? name, string? surname, string? fname, string? country, string? city, string? phone, DateTime date, string ?gender)
        {
            Name = name;
            Surname = surname;
            Fname = fname;
            Country = country;
            City = city;
            Phone = phone;
            Date = date;
            Gender = gender;
        }

        public override string ToString()
        {
            return $"Name : {Name}\nSurname : {Surname}\nFname : {Fname}\nCountry : {Country}\nCity : {City}\nPhone : {Phone}\nDate :{Date.ToString()}\nGender : {Gender}";
        }

    }
}
