using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FitTracker.FitTracker
{
    class UserProfile
    {
        private string userName { get; set; }
        private double height { get; set; }
        private double weight { get; set; }
        private int age { get; set; }

        public UserProfile(string userName, double height, double weight, int age)
        {
            this.userName = userName;
            this.height = height;
            this.weight = weight;
            this.age = age;
        }

        public string GetName()
        {
            return userName;
        }
        public void SetName(string name)
        {
           userName = name;
        }

        public double Getheight()
        {
            return height;
        }
        public void Setheight(double h)
        {
            height = h;
        }

        public double GetWeight()
        {
            return weight;
        }
        public void SetWeight(double w)
        {
            weight=w;
        }

        public int GetAge()
        {
            return age;
        }
        public void SetAge(int a)
        {
            age=a;
        }

        public void DisplayProfile()
        {
            Console.WriteLine($"\nUser: {GetName()} | Age: {GetAge()} | Weight: {GetWeight()} kg");
        }
    }
}
