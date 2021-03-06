﻿using System;
using System.Collections.Generic;
using Xunit;

namespace MGR.CommandLineParser.UnitTests.Extensions
{
    public partial class TypeExtensionsTests
    {
        public class IsDictionaryType
        {
            [Fact]
            public void ListIntTest()
            {
                // Arrange
                Type testedType = typeof (List<int>);
                bool expected = false;

                // Act
                bool actual = testedType.IsDictionaryType();

                // Assert
                Assert.Equal(expected, actual);
            }

            [Fact]
            public void ICollectionIntTest()
            {
                // Arrange
                Type testedType = typeof (ICollection<int>);
                bool expected = false;

                // Act
                bool actual = testedType.IsDictionaryType();

                // Assert
                Assert.Equal(expected, actual);
            }

            [Fact]
            public void TupleInt()
            {
                // Arrange
                Type testedType = typeof (Tuple<int>);
                bool expected = false;

                // Act
                bool actual = testedType.IsDictionaryType();

                // Assert
                Assert.Equal(expected, actual);
            }

            [Fact]
            public void DictionaryStringInt()
            {
                // Arrange
                Type testedType = typeof (Dictionary<string, int>);
                bool expected = true;

                // Act
                bool actual = testedType.IsDictionaryType();

                // Assert
                Assert.Equal(expected, actual);
            }

            [Fact]
            public void IDictionaryStringInt()
            {
                // Arrange
                Type testedType = typeof (IDictionary<string, int>);
                bool expected = true;

                // Act
                bool actual = testedType.IsDictionaryType();

                // Assert
                Assert.Equal(expected, actual);
            }

            [Fact]
            public void NullTypeException()
            {
                // Arrange
                Type testedType = null;
                string expectedExceptionMessage = @"type";

                // Act
                var actualException = Assert.Throws<ArgumentNullException>(() => testedType.IsDictionaryType());

                // Assert
                Assert.Equal(expectedExceptionMessage, actualException.ParamName);
            }
        }
    }
}