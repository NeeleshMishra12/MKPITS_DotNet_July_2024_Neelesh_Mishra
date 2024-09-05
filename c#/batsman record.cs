using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace declared_batsman_oops
{
    class Cricketer
    {
        protected string name;
        protected int age;

        public void SetCricketerData(string Name, int Age)
        {
            name = Name;
            age = Age;
        }

        public void ShowCricketerData()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
        }
    }

    class Batsman : Cricketer
    {
        private int TotalRuns;
        private double averageRuns;
        private int BestPerformance;
        private int NumberOfMatches;

        public void SetBatsmanData(string Name, int Age, int totalRuns, int bestPerformance,int numberofMatches)
        {
            SetCricketerData(Name, Age);
            TotalRuns = totalRuns;
            BestPerformance = bestPerformance;
            NumberOfMatches = numberofMatches;
            CalculateAverageRuns();
        }
        private void CalculateAverageRuns()
        {
            if (NumberOfMatches > 0)
            {
                averageRuns = (double)TotalRuns / NumberOfMatches;
            }
            else
            {
                averageRuns = 0;
            }
        }

        public void ShowBatsmanData()
        {
            ShowCricketerData();
            Console.WriteLine("Total Runs: " + TotalRuns);
            Console.WriteLine("Average Runs: " + averageRuns);
            Console.WriteLine("Best Performance: " + BestPerformance);
            Console.WriteLine("Number of Matches : " + NumberOfMatches);

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Batsman batsman = new Batsman();
            batsman.SetBatsmanData("Neeraj Rajbhar", 20, 5000, 150,50);
            batsman.ShowBatsmanData();
            Console.ReadLine();
        }
    }


}