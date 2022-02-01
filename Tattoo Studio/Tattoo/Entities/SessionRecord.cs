using System;

namespace Entities
{
    public class SessionRecord
    {
        public int? ID { get; set; }
        public string Master { get; set; }
        public string Client { get; set; }
        public string SketchInfo { get; set; }
        public string WorkType { get; set; }
        public DateTime Date { get; set; }
        public string Time { get; set; }
        public double WorkTime { get; set; }
        public double Price { get; set; }

        public SessionRecord(string master, string client, string sketchStyle, string sketchSize, 
            double sketchTime, string workType, DateTime date, DateTime time, double workTime, double price)
        {
            ID = null;
            Master = master;
            Client = client;
            SketchInfo = GetSketchInfo(sketchStyle, sketchSize, sketchTime);
            WorkType = workType;
            Date = date;
            Time = time.ToString("hh:mm");
            WorkTime = workTime;
            Price = price;
        }
        public SessionRecord(int id, string master, string client, string sketchStyle, string sketchSize,
            double sketchTime, string workType, DateTime date, DateTime time, double workTime, double price)
        {
            ID = id;
            Master = master;
            Client = client;
            SketchInfo = GetSketchInfo(sketchStyle, sketchSize, sketchTime);
            WorkType = workType;
            Date = date;
            Time = time.ToString("hh:mm");
            WorkTime = workTime;
            Price = price;
        }

        private string GetSketchInfo(string sketchStyle, string sketchSize, double sketchTime)
        {
            return string.Format("{0} | {1} | {2}", sketchStyle, sketchSize, sketchTime);
        }
    }
}
