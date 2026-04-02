using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using Jay.LearningHelperForStudents.Interfaces;
using Jay.LearningHelperForStudents.Data;
using Jay.LearningHelperForStudents.Utilities;

namespace Jay.LearningHelperForStudents.Tests
{
    public class DisplayWordsListWithJoinTests
    {
        [Fact]
        public void ImplementsInterface()
        {
            IDisplayWordsListWithJoin display = new Lh();
            Assert.NotNull(display);
        }

        [Fact]
        public void DisplayWordsList_Returns_Correct_String_With_Default_Join()
        {
            IDisplayWordsListWithJoin display = new Lh();
            var words = new List<string> { "Hello", "World" };
            var result = display.DisplayWordsList(words);
            Assert.Equal("Hello World", result);
        }

        [Fact]
        public void DisplayWordsList_Returns_Correct_String_With_Custom_Join()
        {
            IDisplayWordsListWithJoin display = new Lh();
            var words = new List<string> { "Hello", "World" };
            var result = display.DisplayWordsList(words, ", ");
            Assert.Equal("Hello, World", result);
        }

        [Fact]
        public void DisplayWordsList_Returns_Correct_String_With_Empty_Join()
        {
            IDisplayWordsListWithJoin display = new Lh();
            var words = new List<string> { "Hello", "World" };
            var result = display.DisplayWordsList(words, "");
            Assert.Equal("HelloWorld", result);
        }

        [Fact]
        public void DisplayWordsList_Throws_Exception_When_Words_Is_Null()
        {
            IDisplayWordsListWithJoin display = new Lh();
            Assert.Throws<ArgumentNullException>(() => display.DisplayWordsList(null!));
        }
    }
}