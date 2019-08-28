using BenchmarkDotNet.Attributes;
using System.Collections.Generic;

namespace PerfTest
{
    [RankColumn]
    [MarkdownExporterAttribute.GitHub]
    [SimpleJob(launchCount: 1, warmupCount: 3, targetCount: 5, invocationCount: 100)]
    [CoreJob, ClrJob]
    public class ORMTests
    {
        private readonly DapperRepo dapperRepo = new DapperRepo();
        private readonly InsightRepo insightRepo = new InsightRepo();
        private readonly ADORepo adoRepo = new ADORepo();

        [Benchmark]
        public IList<User> Dapper_GetUsers() => dapperRepo.GetUsers();

        [Benchmark]
        public IList<User> Insight_GetUsers() => insightRepo.GetUsers();

        [Benchmark]
        public IList<User> ADO_GetUsers() => adoRepo.GetUsers();

        //[Benchmark]
        //public User Dapper_GetSingleUser() => dapperRepo.GetSingleUser();

        //[Benchmark]
        //public User Insight_GetSingleUser() => insightRepo.GetSingleUser();

        //[Benchmark]
        //public User ADO_GetSingleUser() => adoRepo.GetSingleUser();

    }
}
