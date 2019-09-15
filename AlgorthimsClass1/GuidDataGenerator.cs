using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorthimsClass1
{
    public class GuidDataGenerator
    {
       
        
        public List<int> myInts;
        public List<double> myDoubles;
        public List<Guid> myGuids;

        //This is to make it easier to read the loops that generate the million values of: Ints, Guids, and Doubles
        public int million = 1000000;

        public GuidDataGenerator()
        {
            myGuids = new List<Guid>();
            myInts = new List<int>();
            myDoubles = new List<double>();
        }


        public void MyInts()
        {
            for(int i = 0; i < million; i++)
            {
                myInts.Add(i);
            }
        }

        public void MyDoubles()
        {
            //Just need random to generate doubles to myDoubles List
            Random rnd = new Random();
            for (int i = 0; i < million; i++)
            {
                double randomDouble = rnd.NextDouble();
                myDoubles.Add(randomDouble);
            }
        }

        public void MyGuids()
        {
            for(int i = 0; i < million; i++)
            {
                //this will create a new guid for us
                Guid g = Guid.NewGuid();
                myGuids.Add(g);
            }
        }

        public void AddValueToCSV()
        {
            MyInts();
            MyDoubles();
            MyGuids();
            try
            {       
                //The path I use is for my computer specifically.      
                string path = @"c:\Workspace\Algorithms\MyTest.csv";
                //This will create a csv file in the desired location we make variable path equal to
                    using (System.IO.StreamWriter file = new System.IO.StreamWriter(path, true))
                    {
                    for (int i = 0; i < million; i++)
                    {
                        //this for loop writes all the lines we have in each list into our csv file. It seperates each type with commas
                        file.WriteLine(myInts[i] + "," + myGuids[i].ToString() + "," + myDoubles[i]);
                    }
                    }     
            }

            catch (Exception ex)
            {
                throw new ApplicationException("This program did not work:", ex);
            }
        }

    }
}
