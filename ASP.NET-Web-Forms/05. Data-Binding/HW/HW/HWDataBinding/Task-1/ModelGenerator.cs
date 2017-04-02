using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HWDataBinding.Task_1
{
    public static class ModelGenerator
    {
        public static List<string> GetMercedesModels()
        {
            return new List<string>() {"A class", "B class", "C class" ,
                "E class", "S class", "ML class", "GLK class","G class" };
        }

        public static List<string> GetBMWModels()
        {
            return new List<string>() { "1 series" , "2 series" , "3 series" ,
                "4 series" , "5 series" , "6 series" , "7 series" ,"X5 series","X6 series"};
        }

        public static List<string> GetAudiModels()
        {
            return new List<string>() { "A 1", "A 3", "A 4",
                "A 6", "A 7", "A 8", "RS 6", "Q 7", "R 8"};
        }

        public static List<string> GetVWModels()
        {
            return new List<string>() { "Polo", "Golf", "Passat",
                "Phaeton", "Touareg", "Scirocco", "Jetta", "Tiguan", "Beetle"};
        }
    }
}