using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Lesson_16
{
    class Measurement
    {
        public string Loacation { get; set; }
        public DateTime Date { get; set; }
        public float MeasureValue { get; set; }
    }
    class MeasurementsList
    {
        public Measurement[] ListOfMeasurements { get; set; }

        public MeasurementsList(params Measurement[] listOfMeasurements)
        {
            ListOfMeasurements = listOfMeasurements;
        }

        public float this[DateTime date]
        {
            get
            {
                for (int i = 0; i < ListOfMeasurements.Length; i++)
                {
                    if (date == ListOfMeasurements[i].Date)
                    {
                        return ListOfMeasurements[i].MeasureValue;
                    }
                }
                return -1;
            }
        }
        //public Measurement this[DateTime date]
        //{
        //    get
        //    {
        //        for (int i = 0; i < ListOfMeasurements.Length; i++)
        //        {
        //            if (date == ListOfMeasurements[i].Date)
        //            {
        //                return ListOfMeasurements[i];
        //            }
        //        }
        //        return null;
        //    }
        //}

        public Measurement GetMeasurementByDate(DateTime date)
        {
            for (int i = 0; i < ListOfMeasurements.Length; i++)
            {
                if (date == ListOfMeasurements[i].Date)
                {
                    return ListOfMeasurements[i];
                }
            }
            return null;
        }
        public Measurement this[string location]
        {
            get 
            {
                DateTime date = DateTime.MaxValue;
                for (int i = 0; i < ListOfMeasurements.Length; i++)
                {
                    if (location == ListOfMeasurements[i].Loacation)
                    {
                        if (ListOfMeasurements[i].Date < date)
                        {
                            date = ListOfMeasurements[i].Date;
                        }
                    }
                }
                for (int i = 0; i < ListOfMeasurements.Length; i++)
                {
                    if (ListOfMeasurements[i].Loacation == location && ListOfMeasurements[i].Date == date)
                    {
                        return ListOfMeasurements[i];
                    }
                }
                return null;
            }
        }
        public Measurement GetFirstMeasurementByCity(string location)
        {
            DateTime date = DateTime.MaxValue;
            for (int i = 0; i < ListOfMeasurements.Length; i++)
            {
                if (location == ListOfMeasurements[i].Loacation)
                {
                    if (ListOfMeasurements[i].Date < date)
                    {
                        date = ListOfMeasurements[i].Date;
                    }
                }
            }
            for (int i = 0; i < ListOfMeasurements.Length; i++)
            {
                if (ListOfMeasurements[i].Loacation == location && ListOfMeasurements[i].Date == date)
                {
                    return ListOfMeasurements[i];
                }
            }
            return null;
        }
        public bool this[string location, DateTime date]
        {
            get
            {
                for (int i = 0; i < ListOfMeasurements.Length; i++)
                {
                    if (ListOfMeasurements[i].Loacation == location && ListOfMeasurements[i].Date == date)
                    {
                        return true;
                    }
                }
                return false;
            }
        }
        public bool WasThereMeasurement(string location, DateTime date)
        {
            for (int i = 0; i < ListOfMeasurements.Length; i++)
            {
                if (ListOfMeasurements[i].Loacation == location && ListOfMeasurements[i].Date == date)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
