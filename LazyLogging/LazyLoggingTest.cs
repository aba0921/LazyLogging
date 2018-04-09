using System;
using BenchmarkDotNet.Attributes;

namespace LazyLogging
{
    [MemoryDiagnoser]
    public class LazyLoggingTest
    {
        private const int Count = 2000;
        private readonly int value;
        public string Field { get; private set; }

        [Benchmark]
        public void DirectLogging()
        {
            for (int i = 0; i < Count; i++)
            {
                DirectLoggingInternal(new string('a', Count));
            }
        }

        private void DirectLoggingInternal(string s)
        {
            if (value == 0)
            {
                return;
            }

            Field = s;
        }

        [Benchmark]
        public void LazyLogging()
        {
            for (int i = 0; i < Count; i++)
            {
                LazyLoggingInternal(() => new string('a', Count));
            }
        }

        private void LazyLoggingInternal(Func<string> func)
        {
            if (value == 0)
            {
                return;
            }

            Field = func();
        }
    }
}