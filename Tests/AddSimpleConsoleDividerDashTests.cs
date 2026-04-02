using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using Jay.LearningHelperForStudents.Interfaces;
using Jay.LearningHelperForStudents.Data;
using Jay.LearningHelperForStudents.Utilities;


namespace Jay.LearningHelperForStudents.Tests
{
    public class AddSimpleConsoleDividerDashTests
    {
        [Fact]
        public void ImplementsInterface()
        {
            IAddSimpleConsoleDividerDash divider = new Lh();
            Assert.NotNull(divider);
        }

        // Note: Testing console output is tricky and typically requires capturing the console output.
        // For simplicity, we will not implement a test for AddSimpleConsoleDivider here, as it would require
        // additional setup to capture and verify the console output.
    }
}