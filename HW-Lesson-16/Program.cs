using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Lesson_16
{
    class Program
    {
        static void Main(string[] args)
        {
            float[,] temps = new float[2, 28];

            for (int i = 0; i < 28; i++)
            {
                temps[0, i] = i + 1;
            }

            Random rand = new Random();
            for (int i = 0; i < 28; i++)
            {
                temps[1, i] = (rand.Next(161) + 240) / 10f;
            }

            Measurement m1 = new Measurement()
            {
                Date = new DateTime(2001, 5, 23),
                Loacation = "paris",
                MeasureValue = (rand.Next(161) + 240) / 10f
            };
            Measurement m2 = new Measurement()
            {
                Date = new DateTime(2011, 5, 23),
                Loacation = "london",
                MeasureValue = (rand.Next(161) + 240) / 10f
            };
            Measurement m3 = new Measurement()
            {
                Date = new DateTime(2001, 4, 23),
                Loacation = "madrid",
                MeasureValue = (rand.Next(161) + 240) / 10f
            };
            Measurement m4 = new Measurement()
            {
                Date = new DateTime(2000, 5, 28),
                Loacation = "paris",
                MeasureValue = (rand.Next(161) + 240) / 10f
            };
            Measurement m5 = new Measurement()
            {
                Date = new DateTime(2001, 5, 23),
                Loacation = "berlin",
                MeasureValue = (rand.Next(161) + 240) / 10f
            };
            Measurement m6 = new Measurement()
            {
                Date = new DateTime(2001, 5, 4),
                Loacation = "tel aviv",
                MeasureValue = (rand.Next(161) + 240) / 10f
            };

            MeasurementsList ml = new MeasurementsList(m1, m2, m3, m4, m5, m6);

            //Console.WriteLine(ml.GetMeasureValueByDate(new DateTime(2001,5,4)));
            Measurement m7 = ml.GetMeasurementByDate(new DateTime(2001, 4, 23));
            Measurement m8 = ml.GetFirstMeasurementByCity("paris");
            Console.WriteLine("true " + ml.WasThereMeasurement("berlin", new DateTime(2001, 5, 23)));
            Console.WriteLine("false " + ml.WasThereMeasurement("berlin", new DateTime(2001, 5, 4)));

            float check = ml[m2.Date];
            Measurement m9 = ml["paris"];
            bool flag = ml["berlin", new DateTime(2001, 5, 13)];


            Console.ReadLine();
        }
        static float GetTemp(int day, float[,] temps)
        {
            return temps[1, day - 1];
        }
    }
}
