using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace RegexPerformance
{
    public class Redux
    {
        private readonly string sequences;

        public Redux()
        {
            sequences = System.IO.File.ReadAllText("input5000000.txt");
        }

        [Benchmark]
        public void Do() => regexredux.Main(sequences);
    }

    public static class Program
    {
        public static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<Redux>(new MainConfig());
        }
    }
}
