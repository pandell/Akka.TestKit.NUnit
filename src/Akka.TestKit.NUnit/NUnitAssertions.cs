//-----------------------------------------------------------------------
// <copyright file="NUnitAssertions.cs" company="Akka.NET Project">
//     Copyright (C) 2009-2016 Typesafe Inc. <http://www.typesafe.com>
//     Copyright (C) 2013-2016 Akka.NET project <https://github.com/akkadotnet/akka.net>
// </copyright>
//-----------------------------------------------------------------------

using System;
using NUnit.Framework;

namespace Akka.TestKit.NUnit
{
    /// <summary>
    /// Assertions for NUnit
    /// </summary>
    public class NUnitAssertions  : ITestKitAssertions
    {
        
        public void Fail(string format = "", params object[] args)
        {
            Assert.Fail(string.Format(format, args));
        }

        public void AssertTrue(bool condition, string format = "", params object[] args)
        {
            Assert.That(condition, Is.True, string.Format(format, args));
        }

        public void AssertFalse(bool condition, string format = "", params object[] args)
        {
            Assert.That(condition, Is.False, string.Format(format, args));
        }

        public void AssertEqual<T>(T expected, T actual, string format = "", params object[] args)
        {
            Assert.That(actual, Is.EqualTo(expected), string.Format(format, args));
        }

        public void AssertEqual<T>(T expected, T actual, Func<T, T, bool> comparer, string format = "", params object[] args)
        {
            Assert.That(actual, Is.EqualTo(expected).Using<T>(comparer), string.Format(format, args));
        }
    }
}
