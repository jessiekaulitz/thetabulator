using System;


namespace DotnetCOREClasses
{
    public static class TimeConverter
    {
        public static TimeSpan ConvertTime(string time)
        {
            TimeSpan convertedTime;
            string newTime = "";


            for(int i = 0; i < time.Length; i++)
            {
                if(Char.IsDigit(time, i))
                {
                    newTime += time[i];
                }
            }
            
            if(newTime.Length > 2)
            {
                newTime = newTime.Insert(newTime.Length - 2, ":");
            }

            try
            {
                convertedTime = TimeSpan.Parse(newTime);
            }
            catch
            {
                convertedTime = TimeSpan.Zero;
            }

            return convertedTime;
        }
    }
}
