using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Xunit;
using Jay.LearningHelperForStudents.Interfaces;
using Jay.LearningHelperForStudents;
using Jay.LearningHelperForStudents.Utilities;

namespace Jay.LearningHelperForStudents.Tests
{
    public class DisplayListOfStringsTests
    {

        [Fact]
        public void DisplayListOfStringsNow_Throws_OnNull()
        {
            var sut = new Lh();
            Assert.Throws<ArgumentNullException>(() => sut.DisplayListOfStringsNow(null!));
        }

        [Fact]
        public void DisplayListOfStringsNow_WritesItems_WithoutPrefix()
        {
            var sut = new Lh();
            var items = new List<string> { "one", "two" };

            var sw = new StringWriter();
            var original = Console.Out;
            try
            {
                Console.SetOut(sw);
                sut.DisplayListOfStringsNow(items);
            }
            finally
            {
                Console.SetOut(original);
            }

            var output = sw.ToString().Replace("\r\n", "\n");
            var lines = output.Split('\n', StringSplitOptions.RemoveEmptyEntries);

            Assert.Equal(items.Count, lines.Length);
            Assert.Equal("one", lines[0]);
            Assert.Equal("two", lines[1]);
        }

        [Fact]
        public void DisplayListOfStringsNow_WritesPrefixThenItems()
        {
            var sut = new Lh();
            var items = new List<string> { "a" };

            var sw = new StringWriter();
            var original = Console.Out;
            try
            {
                Console.SetOut(sw);
                sut.DisplayListOfStringsNow(items, "PREFIX");
            }
            finally
            {
                Console.SetOut(original);
            }

            var output = sw.ToString().Replace("\r\n", "\n");
            var lines = output.Split('\n', StringSplitOptions.RemoveEmptyEntries)
                .Select(l => l.Trim())
                .Where(l => !string.IsNullOrEmpty(l))
                .ToList();

            Assert.Contains("PREFIX", lines);
            Assert.Contains("a", lines);
            Assert.True(lines.IndexOf("PREFIX") < lines.IndexOf("a"));
        }

        [Fact]
        public void DisplayListOfStringsNow_WritesPrefixEvenIfListEmpty()
        {
            var sut = new Lh();
            var items = new List<string>();

            var sw = new StringWriter();
            var original = Console.Out;
            try
            {
                Console.SetOut(sw);
                sut.DisplayListOfStringsNow(items, "HEADER");
            }
            finally
            {
                Console.SetOut(original);
            }

            var output = sw.ToString().Replace("\r\n", "\n").Trim();
            Assert.Equal("HEADER", output);
        }
    }
}