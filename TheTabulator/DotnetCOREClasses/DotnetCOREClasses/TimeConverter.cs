using System;

namespace DotnetCOREClasses
{
    public static class TimeConverter
    {
        public static TimeSpan ConvertTime(string time)
        {
            int length = time.Length;
            TimeSpan convertedTime;
            
            if(length > 2)
            {
                if(time[length - 3] != ':')
                {
                    time = time.Insert(length - 2, ":");
                }
            }

            try
            {
                convertedTime = TimeSpan.Parse(time);
            }
            catch
            {
                convertedTime = TimeSpan.Zero;
            }

            return convertedTime;
        }
    }
}
