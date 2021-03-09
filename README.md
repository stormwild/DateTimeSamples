# DateTime Samples

Sample code using DateTime, DateTimeOffset

```

            var sample = DateTimeOffset.Parse(SAMPLE_DATE_1);

            Console.WriteLine($"{sample.Offset}");
            Console.WriteLine($"{sample.DateTime.Kind}");

            Console.WriteLine($"--------------------");

            Console.WriteLine($"{sample:o}");
            Console.WriteLine($"{sample.ToLocalTime():o}");

            Console.WriteLine($"--------------------");
            
            Console.WriteLine($"{sample:u}");
            Console.WriteLine($"{sample.ToLocalTime():u}");
```