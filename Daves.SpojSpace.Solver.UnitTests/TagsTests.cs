﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace Daves.SpojSpace.Solver.UnitTests
{
    [TestClass]
    public class TagsTests
    {
        [TestMethod]
        public void Tags()
        {
            // Splitting like this because a newline is two chars on windows: http://stackoverflow.com/q/13437468/1676558.
            string[] tags = Solver.Solutions.Tags.Split(default(char[]), StringSplitOptions.RemoveEmptyEntries);
            string[] orderedTags = Solver.Solutions.Tags.Split(default(char[]), StringSplitOptions.RemoveEmptyEntries)
                .OrderBy(t => t)
                .ToArray();
            CollectionAssert.AreEqual(tags, orderedTags,
                $"The tag need to be in alphabetical order: ${string.Join(Environment.NewLine, orderedTags)}");
        }
    }
}