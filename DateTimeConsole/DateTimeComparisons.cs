using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeConsole
{
    public class DateTimeComparisons
    {
        // Baseline
        private const string SAMPLE_DATE_1 = "2021-03-09T07:00:00+00:00";
        private const string SAMPLE_DATE_2 = "2021-03-09T15:00:00+08:00";
        private const string SAMPLE_DATE_3 = "2021-03-09T02:00:00-13:00";

        // 1 Hour earlier than baseline
        private const string SAMPLE_DATE_4 = "2021-03-09T06:00:00+00:00";
        private const string SAMPLE_DATE_5 = "2021-03-09T14:00:00+08:00";
        private const string SAMPLE_DATE_6 = "2021-03-09T01:00:00-13:00";

        // Baseline with no offset
        private const string SAMPLE_DATE_7 = "2021-03-09T07:00:00";
        private const string SAMPLE_DATE_8 = "2021-03-09T15:00:00";
        private const string SAMPLE_DATE_9 = "2021-03-09T02:00:00";


        public DateTimeComparisons()
        {
                    
        }

        public void Compare()
        {
            // create a new datetime from baseline
            // create a new datetime offset

            var date1 = DateTimeOffset.Parse(SAMPLE_DATE_1);
            var date1_copy = DateTimeOffset.Parse(SAMPLE_DATE_1);
            var date7 = DateTime.Parse(SAMPLE_DATE_7);

            var same = date1 == date7;

            Console.WriteLine($"{date1:o} == {date7:o} result is {same}");

            var sameCopy = date1 == date1_copy;

            //Console.WriteLine($"{sameCopy}");
            Console.WriteLine($"{date1:o} == {date1_copy:o} result is {sameCopy}");

            var sameWithKindUtc = date1 == DateTime.SpecifyKind(date7, DateTimeKind.Utc);

            //Console.WriteLine($"{sameWithKindUtc}");
            Console.WriteLine($"{date1:o} == {DateTime.SpecifyKind(date7, DateTimeKind.Utc):o} result is {sameWithKindUtc}");
        }
    }
}
