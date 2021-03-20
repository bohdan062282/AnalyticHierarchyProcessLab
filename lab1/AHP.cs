using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class AHP
    {
        public static string getPriorityValues(AHP criterionsLvl2, List<AHP> criterionsLvl3)
        {
            StringBuilder stringBuilder = new StringBuilder();
            AHP firstEl = criterionsLvl3.ElementAt(0);
            for (int i = 0; i < firstEl.Amount; i++)
            {
                stringBuilder.Append(firstEl.Names[i] + " = ");
                double tmpValue = 0;
                for(int j = 0; j < criterionsLvl2.Amount; j++)
                {
                    tmpValue += criterionsLvl3.ElementAt(j).priorityVectors[i] * criterionsLvl2.priorityVectors[j];
                }
                stringBuilder.Append(tmpValue.ToString() + "\n");
            }
            return stringBuilder.ToString();
        }

        public AHP(string []names)
        {
            Names = names;
            Amount = Names.Length;
            priorities = new double[Amount, Amount];
            vectors = new double[Amount];
            priorityVectors = new double[Amount];
            sums = new double[Amount];
            lambdas = new double[Amount];
            for (int i = 0; i < Amount; i++)
            {
                priorities[i, i] = 1;
            }
        }
        public void setPriority(int firstCriterion, int secondCriterion, int value)
        {
            priorities[firstCriterion, secondCriterion] = value;
            priorities[secondCriterion, firstCriterion] = 1.0 / value;
        }
        public void calculateVectors()
        {
            double selfVectorsSum = 0;
            for(int i = 0; i < Amount; i++)
            {
                double columnSum = 0;
                double mult = 1;
                for(int j = 0; j < Amount; j++)
                {
                    mult *= priorities[i, j];
                    columnSum += priorities[j, i];
                }
                vectors[i] = Math.Pow(mult, 1.0 / Amount);
                selfVectorsSum += vectors[i];
                sums[i] = columnSum;
                mult = 1;
            }
            for(int i = 0; i < Amount; i++)
            {
                priorityVectors[i] = vectors[i] / selfVectorsSum;
                lambdas[i] = sums[i] * priorityVectors[i];
            }
            IU = (lambdas.Sum() - Amount) / (Amount - 1);
            VU = IU / setIU[Amount - 1];
        }
        public void PRINTFORILLYA()
        {
            for(int i = 0; i < Amount; i++)
            {
                for(int j = 0; j < Amount; j++)
                {
                    Console.Write(priorities[i, j].ToString() + "\t");
                }
                Console.Write("\t\t" + vectors[i].ToString() + "\t" + priorityVectors[i].ToString() + "\t" + lambdas[i].ToString() + "\n");
            }
            Console.WriteLine("IU = " + IU.ToString() + " VU = " + VU.ToString());
        }

        public string[] Names { get; set; }
        public int Amount { get; set; }
        private double[,] priorities;
        private double[] vectors;
        private double[] priorityVectors;
        private double[] sums;
        private double[] lambdas;
        public double IU { get; set; }
        public double VU { get; set; }

        static private float[] setIU = new []{ 0.0f, 0.0f, 0.058f, 0.90f, 1.12f, 1.24f, 1.32f, 1.41f, 1.45f, 1.49f };

    }
}
