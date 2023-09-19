//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace exercicios
//{
//    internal class DateETimeSpan
//    {
//        DateTime d1 = new DateTime(2019, 11, 23, 19, 07, 57, 678);
//            Console.WriteLine(d1);

//            var d4 = DateTime.Now;
//            var d5 = DateTime.Today;
//            var d6 = DateTime.UtcNow;

//            Console.WriteLine(d4);
//            Console.WriteLine(d5);
//            Console.WriteLine(d6);

//            DateTime d2 = DateTime.Parse("2001-09-11 09:50:23");
//            DateTime d3 = DateTime.Parse("29/04/2004 03:50:23");
//            DateTime d7 = DateTime.ParseExact("1981-11-23", "yyyy-MM-dd", ci);
//            DateTime d8 = DateTime.ParseExact("02/09/2004 15:32:45", "dd/MM/yyyy HH:mm:ss", ci);

//            Console.WriteLine(d2);
//            Console.WriteLine(d3);
//            Console.WriteLine(d7);
//            Console.WriteLine(d8);

//            Console.WriteLine();
//            Console.WriteLine("=================================");
//            Console.WriteLine("DATA: " + d1.Date);
//            Console.WriteLine("=================================");
//            Console.WriteLine("DIA: " + d1.Day);
//            Console.WriteLine("=================================");
//            Console.WriteLine("DIA DA SEMANA: " + d1.DayOfWeek);
//            Console.WriteLine("=================================");
//            Console.WriteLine("DIA DO ANO: " + d1.DayOfYear);
//            Console.WriteLine("=================================");
//            Console.WriteLine("KIND: " + d1.Kind);
//            Console.WriteLine("=================================");
//            Console.WriteLine("MILISEGUNDO: " + d1.Millisecond);
//            Console.WriteLine("=================================");
//            Console.WriteLine("MINUTE: " + d1.Minute);
//            Console.WriteLine("=================================");
//            Console.WriteLine("MONTH: " + d1.Month);
//            Console.WriteLine("=================================");
//            Console.WriteLine("SECOND: " + d1.Second);
//            Console.WriteLine("=================================");
//            Console.WriteLine("TICKS: " + d1.Ticks);
//            Console.WriteLine("=================================");
//            Console.WriteLine("TIMEOFDAY: " + d1.TimeOfDay);
//            Console.WriteLine("=================================");
//            Console.WriteLine("YEAR: " + d1.Year);
//            Console.WriteLine("=================================");
//            Console.WriteLine();

//            Console.WriteLine(d1.ToLongDateString());
//            Console.WriteLine(d1.ToLongTimeString());
//            Console.WriteLine(d1.ToShortDateString());
//            Console.WriteLine(d1.ToShortTimeString());
//            Console.WriteLine(d1.ToString());
//            Console.WriteLine(d1.ToString("yyyy-MM-dd HH:mm:ss"));
//            Console.WriteLine(d1.ToString("yyyy-MM-dd HH:mm:ss.fff"));

//            DateTime de = d1.AddDays(5);
//            DateTime d = new DateTime(2009, 07, 29, 20, 14, 53, 649);
//            Console.WriteLine(de);
//            Console.WriteLine();
//            Console.WriteLine("===============TIMESPAN==================");
//            Console.WriteLine();
//            TimeSpan t = d1.Subtract(d);
//            Console.WriteLine(t);
//            Console.WriteLine();

//            TimeSpan t1 = new TimeSpan(56, 21, 14, 30, 678);
//            Console.WriteLine(t1);
//            TimeSpan t2 = new TimeSpan(900000000L);
//            Console.WriteLine(t2);
//            TimeSpan t3 = TimeSpan.FromDays(1.83);
//            Console.WriteLine(t3);
//            TimeSpan t4 = TimeSpan.FromHours(5.35);
//            Console.WriteLine(t4);
//            TimeSpan t5 = TimeSpan.FromTicks(234430005360L);
//            Console.WriteLine(t5);
//            Console.WriteLine();

//            TimeSpan ts1 = TimeSpan.MaxValue;
//            TimeSpan ts2 = TimeSpan.MinValue;
//            TimeSpan ts3 = TimeSpan.Zero;

//            Console.WriteLine(ts1);
//            Console.WriteLine(ts2);
//            Console.WriteLine(ts3);

//            Console.WriteLine();
//            Console.WriteLine("=================================");
//            Console.WriteLine("DAYS: " + t1.Days);
//            Console.WriteLine("=================================");
//            Console.WriteLine("HOURS: " + t1.Hours);
//            Console.WriteLine("=================================");
//            Console.WriteLine("MINUTE: " + t1.Minutes);
//            Console.WriteLine("=================================");
//            Console.WriteLine("SECOND: " + t1.Seconds);
//            Console.WriteLine("=================================");
//            Console.WriteLine("MILISEGUNDO: " + t1.Milliseconds);
//            Console.WriteLine("=================================");
//            Console.WriteLine("TICKS: " + t1.Ticks);
//            Console.WriteLine("=================================");
//            Console.WriteLine();
//            Console.WriteLine("=================================");
//            Console.WriteLine("TOTALDAYS: " + t1.TotalDays.ToString("F2", ci));
//            Console.WriteLine("=================================");
//            Console.WriteLine("TOTALHOURS: " + t1.TotalHours);
//            Console.WriteLine("=================================");
//            Console.WriteLine("TOTALMINUTES: " + t1.TotalMinutes);
//            Console.WriteLine("=================================");
//            Console.WriteLine("TOTALSECONDS: " + t1.TotalSeconds);
//            Console.WriteLine("=================================");
//            Console.WriteLine("TOTALMILlISECONDS: " + t1.TotalMilliseconds);
//            Console.WriteLine("=================================");
//            Console.WriteLine();

//            TimeSpan sum = t3.Add(t4);
//            Console.WriteLine("SOMA: " + sum);

//            TimeSpan diff = t3.Subtract(t4);
//            Console.WriteLine("DIFERENÇA: " + diff);

//            TimeSpan multi = t3.Multiply(3.0);
//            Console.WriteLine("MULTIPLICAÇÃO: " + multi);

//            TimeSpan div = t3.Divide(3.0);
//            Console.WriteLine("DIVISÃO: " + div);

//            DateTime d10 = new DateTime(2009, 07, 29, 20, 14, 53, 649, DateTimeKind.Local);
//            DateTime d11 = new DateTime(2009, 07, 29, 20, 14, 53, 649, DateTimeKind.Utc);
//            DateTime d12 = new DateTime(2009, 07, 29, 20, 14, 53, 649);

//            Console.WriteLine("=============DateTimeKind=============");
//            Console.WriteLine();
//            Console.WriteLine(d10);
//            Console.WriteLine("KIND: " + d10.Kind);
//            Console.WriteLine("LOCAL: " + d10.ToLocalTime());
//            Console.WriteLine("UTC: " + d10.ToUniversalTime());
//            Console.WriteLine();
//            Console.WriteLine(d11);
//            Console.WriteLine("KIND: " + d11.Kind);
//            Console.WriteLine("LOCAL: " + d11.ToLocalTime());
//            Console.WriteLine("UTC: " + d11.ToUniversalTime());
//            Console.WriteLine();
//            Console.WriteLine(d12);
//            Console.WriteLine("KIND: " + d12.Kind);
//            Console.WriteLine("LOCAL: " + d12.ToLocalTime());
//            Console.WriteLine("UTC: " + d12.ToUniversalTime());
//            Console.WriteLine();
//            Console.WriteLine("=============Padrão Iso=============");
//            Console.WriteLine();
//            DateTime dd = DateTime.Parse("2004-04-29 03:37:47");
//            DateTime dd1 = DateTime.Parse("2004-04-29T03:37:47Z");
//            Console.WriteLine(dd);
//            Console.WriteLine("KIND: " + dd.Kind);
//            Console.WriteLine("LOCAL: " + dd.ToLocalTime());
//            Console.WriteLine("UTC: " + dd.ToUniversalTime());
//            Console.WriteLine();
//            Console.WriteLine(dd1);
//            Console.WriteLine("KIND: " + dd1.Kind);
//            Console.WriteLine("LOCAL: " + dd1.ToLocalTime());
//            Console.WriteLine("UTC: " + dd1.ToUniversalTime());
//            Console.WriteLine();
//            Console.WriteLine(dd1.ToString("yyyy-MM-ddTHH:mm:ssZ")); // dangerous!
//            Console.WriteLine(dd1.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ")); // correct
//    }
//}
