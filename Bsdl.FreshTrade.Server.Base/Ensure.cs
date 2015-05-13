using System;

namespace Bsdl.FreshTrade.Server.Basic
{
    /// <summary>
    /// Helper class for ensuring common statements. 
    /// </summary>
    public static class Ensure
    {
        public static void NotNull<T>(T argument, string argumentName) where T : class
        {
            if (argument == null)
                throw new ArgumentNullException(argumentName);
        }

        public static void HasValue<T>(T? argument, string argumentName) where T : struct
        {
            if (!argument.HasValue)
                throw new ArgumentNullException(argumentName);
        }

        public static void NotNullOrEmpty(string argument, string argumentName)
        {
            if (string.IsNullOrEmpty(argument))
                throw new ArgumentNullException(argument, argumentName);
        }

        public static void NotNullOrWhiteSpace(string argument, string argumentName)
        {
            if (string.IsNullOrWhiteSpace(argument))
                throw new ArgumentNullException(argument, argumentName);
        }

        public static void Positive(int number, string argumentName)
        {
            if (number <= 0)
                throw new ArgumentOutOfRangeException(argumentName, argumentName + " should be positive.");
        }

        public static void Positive(long number, string argumentName)
        {
            if (number <= 0)
                throw new ArgumentOutOfRangeException(argumentName, argumentName + " should be positive.");
        }

        public static void Positive(decimal number, string argumentName)
        {
            if (number <= 0)
                throw new ArgumentOutOfRangeException(argumentName, argumentName + " should be positive.");
        }

        public static void Range(decimal number, string argumentName, decimal lowerInclusive, decimal upperInclusive)
        {
            if (number < lowerInclusive || number > upperInclusive)
                throw new ArgumentOutOfRangeException(argumentName, number, 
                            string.Format("{0} should be in the following range: {1}-{2}.", argumentName, lowerInclusive, upperInclusive));
        }

        public static void Negative(long number, string argumentName)
        {
            if (number >= 0)
                throw new ArgumentOutOfRangeException(argumentName, argumentName + " should be negative.");
        }

        public static void Negative(int number, string argumentName)
        {
            if (number >= 0)
                throw new ArgumentOutOfRangeException(argumentName, argumentName + " should be negative.");
        }

        public static void Negative(decimal number, string argumentName)
        {
            if (number > 0)
                throw new ArgumentOutOfRangeException(argumentName, string.Concat(argumentName, " should be negative."));
        }

        public static void Nonnegative(long number, string argumentName)
        {
            if (number < 0)
                throw new ArgumentOutOfRangeException(argumentName, argumentName + " should be non negative.");
        }

        public static void Nonnegative(int number, string argumentName)
        {
            if (number < 0)
                throw new ArgumentOutOfRangeException(argumentName, argumentName + " should be non negative.");
        }

        public static void Nonnegative(decimal number, string argumentName)
        {
            if (number < 0)
                throw new ArgumentOutOfRangeException(argumentName, string.Concat(argumentName, " should be non negative."));
        }

        public static void NullOrNonnegative(int? number, string argumentName)
        {
            if (number < 0)
                throw new ArgumentOutOfRangeException(argumentName, argumentName + " should be null or not nonnegative.");
        }

        public static void NullOrNonnegative(long? number, string argumentName)
        {
            if (number < 0)
                throw new ArgumentOutOfRangeException(argumentName, argumentName + " should be null not nonnegative.");
        }

        public static void NullOrNonnegative(decimal? number, string argumentName)
        {
            if (number < 0)
                throw new ArgumentOutOfRangeException(argumentName, argumentName + " should be null not nonnegative.");
        }

        public static void NotEmptyGuid(Guid guid, string argumentName)
        {
            if (Guid.Empty == guid)
                throw new ArgumentException(argumentName, argumentName + " shoud be non-empty GUID.");
        }

        public static void Equal(int expected, int actual, string argumentName)
        {
            if (expected != actual)
                throw new ArgumentException(string.Format("{0} expected value: {1}, actual value: {2}",
                                                          argumentName,
                                                          expected,
                                                          actual));
        }

        public static void Equal(long expected, long actual, string argumentName)
        {
            if (expected != actual)
                throw new ArgumentException(string.Format("{0} expected value: {1}, actual value: {2}",
                                                          argumentName,
                                                          expected,
                                                          actual));
        }

        public static void Equal(bool expected, bool actual, string argumentName)
        {
            if (expected != actual)
                throw new ArgumentException(string.Format("{0} expected value: {1}, actual value: {2}",
                                                          argumentName,
                                                          expected,
                                                          actual));
        }
    }
}