using System;

namespace Training
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime timeUtc = DateTime.UtcNow;
           var x = timeUtc.ToLocalTime();

            int? a = 1;

            var e = a.HasValue;

            try
            {
                TimeZoneInfo cstZone = TimeZoneInfo.FindSystemTimeZoneById("W. Europe Standard Time");
                DateTime cstTime = TimeZoneInfo.ConvertTimeFromUtc(timeUtc, cstZone);
                Console.WriteLine("The date and time are {0} {1}.",
                                  cstTime,
                                  cstZone.IsDaylightSavingTime(cstTime) ?
                                          cstZone.DaylightName : cstZone.StandardName);
            }
            catch (TimeZoneNotFoundException)
            {
                Console.WriteLine("The registry does not define the Central Standard Time zone.");
            }

            Console.WriteLine("Hello World!");
        }
    }
}
