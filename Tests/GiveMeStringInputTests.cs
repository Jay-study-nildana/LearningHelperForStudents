using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using Jay.LearningHelperForStudents.Interfaces;
using Jay.LearningHelperForStudents.Data;
using Jay.LearningHelperForStudents.Utilities;

namespace Jay.LearningHelperForStudents.Tests
{
    public class GiveMeStringInputTests
    {
        [Fact]
        public void ImplementsInterface()
        {
            IGiveMeStringInput input = new Lh();
            Assert.NotNull(input);
        }

        // Note: Testing console input is tricky and typically requires mocking the console input.
        // For simplicity, we will not implement a test for GetStringInput here, as it would require
        // additional setup to simulate user input.
    }
}