
using Dumpify;

namespace AspNetCore_Testing_Part2_UnitTesting
{

    /*
     * CALCULATOR TEST CLASS
     * ====================
     * 
     * This class demonstrates comprehensive testing of a calculator class using:
     * - The AAA pattern (Arrange-Act-Assert)
     * - Dumpify for rich test output visualization
     * - Various test scenarios covering normal cases, edge cases, and error conditions
     * 
     * Each test method follows a consistent structure:
     * 1. ARRANGE: Prepare test inputs and expected outputs
     * 2. ACT: Execute the method being tested
     * 3. ASSERT: Verify the results match expectations
     * 4. DUMP: Visualize the test data and results using Dumpify
     */
    public class AddingNumberAndReturnItTests : UnitTestingBase
    {
        // The System Under Test (SUT) - the calculator instance we're testing
        private readonly AddingNumbersAndReturnIt _calculator;

        public AddingNumberAndReturnItTests()
        {
            // Create a fresh calculator instance for each test run
            _calculator = new AddingNumbersAndReturnIt();
        }

        public override void RunTests()
        {

            // Group 1: Addition Tests - Testing the AddNumberTwo method
            "📋 ADDITION TESTS".Dump();
            TestAddNumberTwo_PositiveNumbers();
            TestAddNumberTwo_NegativeNumbers();
            TestAddNumberTwo_ZeroValues();

            // Group 2: Division Tests - Testing the DivededTwoNumber method
            "📋 DIVISION TESTS".Dump();
            TestDivideTwoNumber_PositiveNumbers();
            TestDivideTwoNumber_NegativeNumbers();
            TestDivideTwoNumber_DivideByZero();

            // Group 3: String Tests - Testing the TakeStrinAndReturnIt method
            "📋 STRING TESTS".Dump();
            TestTakeStringAndReturnIt_NormalString();
            TestTakeStringAndReturnIt_EmptyString();
            TestTakeStringAndReturnIt_NullString();

            // Print the summary of all tests
            PrintTestSummary();
        }

        /*
         * TEST SCENARIO 1: Addition with positive numbers
         * 
         * PURPOSE: Verify that the calculator can correctly add two positive integers
         * 
         * WHY THIS MATTERS:
         * - This is the most basic functionality of the calculator
         * - It tests the "happy path" with standard inputs
         * - If this fails, the core functionality is broken
         
         */
        private void TestAddNumberTwo_PositiveNumbers()
        {
            // ARRANGE: Set up two positive integers and calculate expected sum
            int a = 5;
            int b = 7;
            int expected = 12; // 5 + 7 = 12

            // ACT: Call the addition method with our test values
            int result = _calculator.AddNumberTwo(a, b);

            // ASSERT: Verify the result matches our expected value
            Assert(result == expected, "AddNumberTwo should correctly add two positive numbers");

            // DUMP: Visualize the test data and results for better understanding
            new
            {
                TestCase = "Addition with positive numbers",
                Input_a = a,
                Input_b = b,
                Expected = expected,
                Actual = result,
                IsCorrect = result == expected
            }.Dump();
        }

        /*
         * TEST SCENARIO 2: Addition with negative numbers
         * 
         * PURPOSE: Verify that the calculator correctly handles negative integers
         * 
         * WHY THIS MATTERS:
         * - Tests that the method works with negative values
         * - Ensures the sign is properly maintained in calculations
         * - Negative numbers are common in real-world calculations
         */
        private void TestAddNumberTwo_NegativeNumbers()
        {
            // ARRANGE: Set up two negative integers and calculate expected sum
            int a = -3;
            int b = -4;
            int expected = -7; // -3 + (-4) = -7

            // ACT: Call the addition method with negative values
            int result = _calculator.AddNumberTwo(a, b);



            // ASSERT: Verify the result matches our expected value
            Assert(result == expected, "AddNumberTwo should correctly add two negative numbers");

            // DUMP: Visualize the test data and results
            new
            {
                TestCase = "Addition with negative numbers",
                Input_a = a,
                Input_b = b,
                Expected = expected,
                Actual = result,

                IsCorrect = result == expected
            }.Dump();
        }

        /*
         * TEST SCENARIO 3: Addition with zero values
         * 
         * PURPOSE: Verify that the calculator correctly handles zero values
         * 
         * WHY THIS MATTERS:
         * - Zero is a special case in mathematics
         * - Tests the identity property of addition (a + 0 = a)
         * - Edge cases like zero often reveal bugs in implementations
         */
        private void TestAddNumberTwo_ZeroValues()
        {
            // ARRANGE: Set up two zero values and calculate expected sum
            int a = 0;
            int b = 0;
            int expected = 0; // 0 + 0 = 0

            // ACT: Call the addition method with zero values
            int result = _calculator.AddNumberTwo(a, b);

            // ASSERT: Verify the result matches our expected value
            Assert(result == expected, "AddNumberTwo should correctly handle zero values");

            // DUMP: Visualize the test data and results
            new
            {
                TestCase = "Addition with zero values",
                Input_a = a,
                Input_b = b,
                Expected = expected,
                Actual = result,
                IsCorrect = result == expected
            }.Dump();
        }

        /*
         * TEST SCENARIO 4: Division with positive numbers
         * 
         * PURPOSE: Verify that the calculator can correctly divide two positive integers
         * 
         * WHY THIS MATTERS:
         * - Division is a fundamental operation
         * - Tests the "happy path" for division with standard inputs
         * - Division has more edge cases than addition, so thorough testing is important
         */
        private void TestDivideTwoNumber_PositiveNumbers()
        {
            // ARRANGE: Set up two positive integers for division
            int a = 10;
            int b = 2;
            int expected = 5; // 10 ÷ 2 = 5

            // ACT: Call the division method with our test values
            int result = _calculator.DivededTwoNumber(a, b);

            // ASSERT: Verify the result matches our expected value
            Assert(result == expected, "DivededTwoNumber should correctly divide two positive numbers");

            // DUMP: Visualize the test data and results
            new
            {
                TestCase = "Division with positive numbers",
                Input_a = a,
                Input_b = b,
                Expected = expected,
                Actual = result,
                IsCorrect = result == expected
            }.Dump();
        }

        /*
         * TEST SCENARIO 5: Division with negative numbers
         * 
         * PURPOSE: Verify that the calculator correctly handles negative integers in division
         * 
         * WHY THIS MATTERS:
         * - Tests that the method works with negative values
         * - Ensures the sign is properly handled in division
         * - Division with negative numbers follows specific mathematical rules
         */
        private void TestDivideTwoNumber_NegativeNumbers()
        {
            // ARRANGE: Set up a negative dividend and positive divisor
            int a = -10;
            int b = 2;
            int expected = -5; // -10 ÷ 2 = -5

            // ACT: Call the division method with a negative value
            int result = _calculator.DivededTwoNumber(a, b);

            // ASSERT: Verify the result matches our expected value
            Assert(result == expected, "DivededTwoNumber should correctly handle negative numbers");

            // DUMP: Visualize the test data and results
            new
            {
                TestCase = "Division with negative numbers",
                Input_a = a,
                Input_b = b,
                Expected = expected,
                Actual = result,
                IsCorrect = result == expected
            }.Dump();
        }

        /*
         * TEST SCENARIO 6: Division by zero
         * 
         * PURPOSE: Verify that the calculator throws an exception when dividing by zero
         * 
         * WHY THIS MATTERS:
         * - Division by zero is mathematically undefined
         * - Tests error handling in the calculator
         * - Proper exception handling is crucial for robust applications
         * - This is a critical edge case that must be handled correctly
         */
        private void TestDivideTwoNumber_DivideByZero()
        {
            // ARRANGE: Set up a division by zero scenario
            int a = 10;
            int b = 0;

            try
            {
                // ACT: Attempt to divide by zero, which should throw an exception
                int result = _calculator.DivededTwoNumber(a, b);

                // If we get here, no exception was thrown - test fails
                Assert(false, "DivededTwoNumber should throw exception when dividing by zero");

                // DUMP: Show that the test failed because no exception occurred
                new
                {
                    TestCase = "Division by zero",
                    Input_a = a,
                    Input_b = b,
                    Expected = "DivideByZeroException",
                    Actual = "No exception thrown",
                    IsCorrect = false
                }.Dump();
            }
            catch (DivideByZeroException)
            {
                // This is the expected exception - test passes
                Assert(true, "DivededTwoNumber correctly throws exception when dividing by zero");

                // DUMP: Show that the test passed because the correct exception was thrown
                new
                {
                    TestCase = "Division by zero",
                    Input_a = a,
                    Input_b = b,
                    Expected = "DivideByZeroException",
                    Actual = "DivideByZeroException",
                    IsCorrect = true
                }.Dump();
            }
            catch (Exception ex)
            {
                // Wrong exception type - test fails
                Assert(false, $"DivededTwoNumber threw wrong exception type: {ex.GetType().Name}");

                // DUMP: Show that the test failed because the wrong exception was thrown
                new
                {
                    TestCase = "Division by zero",
                    Input_a = a,
                    Input_b = b,
                    Expected = "DivideByZeroException",
                    Actual = ex.GetType().Name,
                    IsCorrect = false
                }.Dump();
            }
        }

        /*
         * TEST SCENARIO 7: String handling - normal string
         * 
         * PURPOSE: Verify that the calculator correctly returns a normal string
         * 
         * WHY THIS MATTERS:
         * - Tests basic string handling functionality
         * - Ensures the method can handle typical string inputs
         * - String operations are common in many applications
         */
        private void TestTakeStringAndReturnIt_NormalString()
        {
            // ARRANGE: Set up a normal string input
            string input = "Hello World";
            string expected = "Hello World"; // Should return the same string

            // ACT: Call the string method with our test value
            string result = _calculator.TakeStrinAndReturnIt(input);

            // ASSERT: Verify the result matches our expected value
            Assert(result == expected, "TakeStrinAndReturnIt should return the same string");

            // DUMP: Visualize the test data and results
            new
            {
                TestCase = "String handling - normal string",
                Input = input,
                Expected = expected,
                Actual = result,
                IsCorrect = result == expected
            }.Dump();
        }

        /*
         * TEST SCENARIO 8: String handling - empty string
         * 
         * PURPOSE: Verify that the calculator correctly handles empty strings
         * 
         * WHY THIS MATTERS:
         * - Empty strings are a common edge case
         * - Tests that the method doesn't add unexpected characters
         * - Empty strings often cause bugs in string processing
         */
        private void TestTakeStringAndReturnIt_EmptyString()
        {
            // ARRANGE: Set up an empty string input
            string input = "";
            string expected = ""; // Should return empty string

            // ACT: Call the string method with an empty string
            string result = _calculator.TakeStrinAndReturnIt(input);

            // ASSERT: Verify the result matches our expected value
            Assert(result == expected, "TakeStrinAndReturnIt should handle empty strings");

            // DUMP: Visualize the test data and results
            new
            {
                TestCase = "String handling - empty string",
                Input = "(empty string)",
                Expected = "(empty string)",
                Actual = result == "" ? "(empty string)" : result,
                IsCorrect = result == expected
            }.Dump();
        }

        /*
         * TEST SCENARIO 9: String handling - null string
         * 
         * PURPOSE: Verify that the calculator correctly handles null strings
         * 
         * WHY THIS MATTERS:
         * - Null is a special case that often causes NullReferenceExceptions
         * - Tests that the method is null-safe
         * - Proper null handling is essential for robust code
         * - This is a critical edge case in string processing
         */
        private void TestTakeStringAndReturnIt_NullString()
        {
            // ARRANGE: Set up a null string input
            string input = null;
            string expected = null; // Should return null

            // ACT: Call the string method with a null value
            string result = _calculator.TakeStrinAndReturnIt(input);

            // ASSERT: Verify the result matches our expected value
            Assert(result == expected, "TakeStrinAndReturnIt should handle null strings");

            // DUMP: Visualize the test data and results
            new
            {
                TestCase = "String handling - null string",
                Input = "null",
                Expected = "null",
                Actual = result == null ? "null" : result,
                IsCorrect = result == expected
            }.Dump();
        }
    }
}
