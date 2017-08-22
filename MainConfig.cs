using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Diagnosers;
using BenchmarkDotNet.Environments;
using BenchmarkDotNet.Exporters;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Loggers;
using BenchmarkDotNet.Toolchains.CsProj;

namespace RegexPerformance
{
    public class MainConfig : ManualConfig
    {
        public MainConfig()
        {
            Add(Job.Default.With(Runtime.Clr)
                .With(Jit.RyuJit)
                .With(Platform.X64)
                .WithId("NET4.7_RyuJIT-x64")
                .WithLaunchCount(1)
                .WithWarmupCount(1)
                .WithInvocationCount(1)
                .WithUnrollFactor(1)
                .WithTargetCount(3));

            Add(Job.Default.With(Runtime.Core)
                .With(CsProjCoreToolchain.NetCoreApp20)
                .WithId("Core2.0-x64")
                .WithLaunchCount(1)
                .WithWarmupCount(1)
                .WithInvocationCount(1)
                .WithUnrollFactor(1)
                .WithTargetCount(3));

            Add(DefaultColumnProviders.Instance);
            Add(MarkdownExporter.GitHub);
            Add(new ConsoleLogger());
            Add(new HtmlExporter());
            Add(MemoryDiagnoser.Default);
        }
    }
}
