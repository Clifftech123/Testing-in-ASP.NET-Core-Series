namespace AspNetCore_Testing_Part2_UnitTesting
{
    public class UnitTestingBase
    {

        // Track test result for reporting 

        private readonly List<TestResult> _testResults = new List<TestResult>();


        protected void Assert(bool condition, string testName)
        {
            var result = new TestResult
            {
                TestName = testName,
                Passed = condition,
                ExecutedAt = DateTime.UtcNow,

            };

            // Store the  result reporting 
            _testResults.Add(result);


            Console.ForegroundColor = ConsoleColor.DarkCyan;
            TimeSpan executionTime = DateTime.UtcNow - result.ExecutedAt;
            Console.WriteLine($"Execution Time: {executionTime.Microseconds} ms");


            // Display the result immediately 

            if (condition)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"✅ PASSED: {testName}");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"❌ FAILED: {testName}");
            }
            Console.ResetColor();
        }


        // Virtual method to be overridden by test of classes

        public virtual void RunTests()
        {

        }



        public void PrintTestSummary()
        {
            var totalTests = _testResults.Count;
            var passedTests = _testResults.Count(r => r.Passed);
            var failedTests = totalTests - passedTests;

            Console.WriteLine("\n📊 TEST SUMMARY");
            Console.WriteLine($"Total Tests: {totalTests}");
            Console.WriteLine($"Passed Tests: {passedTests}");
            Console.WriteLine($"Failed Tests: {failedTests}");


            double successRate = totalTests > 0 ? (double)passedTests / totalTests * 100 : 0;
            Console.WriteLine($"Success Rate: {successRate:F2}%");



            if (failedTests > 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n❌ FAILED TESTS:");
                foreach (var failedTest in _testResults.Where(r => !r.Passed))
                {
                    Console.WriteLine($"- {failedTest.TestName}");
                }
                Console.ResetColor();
            }
        }




        private sealed class TestResult
        {
            public string? TestName { get; set; }
            public bool Passed { get; set; }
            public DateTime ExecutedAt { get; set; }
        }



    }
}
