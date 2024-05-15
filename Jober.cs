using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_5
{
    public class Jober
    {
        public string FIO {  get; set; }
        public DateTime DateOfBirth {  get; set; }
        public string Phone {  get; set; }
        public string Email {  get; set; }
        public string Position {  get; set; }
        public string Responsibilites {  get; set; }

        public decimal Salary {  get; set; }
        public Jober(string fIO, DateTime dateOfBirth, string phone, string email, string position, string responsibilites, decimal salary)
        {
            this.FIO = fIO;
            this.DateOfBirth = dateOfBirth;
            this.Phone = phone;
            this.Email = email;
            this.Position = position;
            this.Responsibilites = responsibilites;
            this.Salary = salary;
        }

        public static decimal operator+(Jober a, decimal salary)
        {
            return a.Salary + salary;
        }
        public static decimal operator -(Jober a, decimal salary)
        {
            return a.Salary - salary;
        }
        public static bool operator==(Jober a, Jober b)
        {
            return a.Salary == b.Salary;
        }
        public static bool operator !=(Jober a, Jober b)
        {
            return a.Salary != b.Salary;
        }
        public static bool operator>(Jober a, Jober b)
        {
            if(a.Salary > b.Salary) return false;
            else return true;
        }
        public static bool operator <(Jober a, Jober b)
        {
            if (a.Salary < b.Salary) return false;
            else return true;
        }
        public override bool Equals(object? obj)
        {
            if(obj is Jober other)
            {
                return this.Salary == other.Salary;
            }
            return false;
        }

        public override string ToString()
        {
            return $"FIO: {FIO}, Date: {DateOfBirth}, Phone: {Phone}, Email: {Email}, Position: {Position}, Responsibilites: {Responsibilites}, Salary: {Salary} ";
        }


    }
}
