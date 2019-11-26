using System;
using System.IO;
using System.Reflection;
using System.Text;
using GildedRose.Console;
using Xunit;

namespace GildedRose.Tests
{
    public class GildedRoseBaselineTests
    {
        [Fact(Skip = "Outdated")]
        public void Should_Always_Align_To_Baseline()
        {
            string result;
            string expect;

            using (var writer = new StringWriter())
            {
                System.Console.SetOut(writer);
                Program.Main();
                result = writer.ToString();
            }

            using (var reader = new StreamReader("../../baseline.txt", Encoding.UTF8))
            {
                expect = reader.ReadToEnd();
            }

            Assert.Equal(expect, result);
        }
    }
}