using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using Jay.LearningHelperForStudents.Interfaces;
using Jay.LearningHelperForStudents.Data;
using Jay.LearningHelperForStudents.Utilities;

namespace Jay.LearningHelperForStudents.Tests
{
    public class RandomRepeatedWordsGeneratorTests
    {
        [Fact]
        public void ImplementsInterface()
        {
            IRandomRepeatedWordsGenerator gen = new Lh();
            Assert.NotNull(gen);
        }

        [Fact]
        public void Generate_Returns_Correct_Count_When_MinEqualsMax()
        {
            var rng = new Random(42);
            IRandomRepeatedWordsGenerator gen = new Lh();

            int n = 3;
            int repeat = 2;
            var result = gen.GenerateRandomRepeatedWords(SourceWords.List, n, repeat, repeat, rng, allowSelectionDuplicates: false, shuffleResult: true);

            Assert.Equal(n * repeat, result.Count);
            // All returned items should be from source
            Assert.All(result, item => Assert.Contains(item, SourceWords.List));
        }

        [Fact]
        public void Generate_AllowsSelectionDuplicates_When_True()
        {
            var rng = new Random(123);
            IRandomRepeatedWordsGenerator gen = new Lh();

            int n = 50;
            var result = gen.GenerateRandomRepeatedWords(SourceWords.List, n, 1, 1, rng, allowSelectionDuplicates: true, shuffleResult: false);

            // When min=max=1, result count should equal n
            Assert.Equal(n, result.Count);
            Assert.All(result, item => Assert.Contains(item, SourceWords.List));
        }

        [Fact]
        public void Generate_ShuffleResult_False_Produces_ContiguousBlocks()
        {
            var rng = new Random(7);
            IRandomRepeatedWordsGenerator gen = new Lh();

            int n = 10;
            int min = 1;
            int max = 4;
            // Use a source with unique words so that when sampling without replacement
            // each distinct word appears at most once in the selection � this ensures
            // contiguous blocks in the output when shuffleResult is false.
            var uniqueSource = SourceWords.List.Distinct().ToList();
            var result = gen.GenerateRandomRepeatedWords(uniqueSource, n, min, max, rng, allowSelectionDuplicates: false, shuffleResult: false);

            // For each distinct word, its occurrences must be in a single contiguous block
            var positions = new Dictionary<string, List<int>>();
            for (int i = 0; i < result.Count; i++)
            {
                var w = result[i];
                if (!positions.ContainsKey(w)) positions[w] = new List<int>();
                positions[w].Add(i);
            }

            foreach (var kvp in positions)
            {
                var indices = kvp.Value.OrderBy(x => x).ToList();
                int minIndex = indices.First();
                int maxIndex = indices.Last();
                Assert.Equal(indices.Count, maxIndex - minIndex + 1);
            }
        }

        [Fact]
        public void Generate_Throws_On_Invalid_Arguments()
        {
            IRandomRepeatedWordsGenerator gen = new Lh();

            // empty source
            Assert.Throws<ArgumentException>(() => gen.GenerateRandomRepeatedWords(new List<string>(), 1, 1, 1));

            // n <= 0
            Assert.Throws<ArgumentException>(() => gen.GenerateRandomRepeatedWords(SourceWords.List, 0, 1, 1));

            // minRepeat < 1
            Assert.Throws<ArgumentException>(() => gen.GenerateRandomRepeatedWords(SourceWords.List, 1, 0, 1));

            // maxRepeat < minRepeat
            Assert.Throws<ArgumentException>(() => gen.GenerateRandomRepeatedWords(SourceWords.List, 1, 3, 2));

            // n > source.Count when duplicates not allowed
            Assert.Throws<ArgumentException>(() => gen.GenerateRandomRepeatedWords(new List<string> { "a", "b" }, 3, 1, 1, null, allowSelectionDuplicates: false));
        }

        [Fact]
        public void Repeats_Are_Within_Specified_Range()
        {
            var rng = new Random(999);
            IRandomRepeatedWordsGenerator gen = new Lh();

            int n = 20;
            int min = 2;
            int max = 5;
            var result = gen.GenerateRandomRepeatedWords(SourceWords.List, n, min, max, rng, allowSelectionDuplicates: true, shuffleResult: true);

            // We cannot directly map which selection produced repeats, but we can assert that global counts are within expectations
            Assert.InRange(result.Count, n * min, n * max);

            // Additionally check that each distinct word count is > 0 and reasonable
            var groups = result.GroupBy(x => x).Select(g => g.Count()).ToList();
            Assert.All(groups, c => Assert.InRange(c, 1, n * max));
        }
    }
}