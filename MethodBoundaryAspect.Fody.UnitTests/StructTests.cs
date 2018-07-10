﻿using FluentAssertions;
using MethodBoundaryAspect.Fody.UnitTests.TestAssembly;
using Xunit;

namespace MethodBoundaryAspect.Fody.UnitTests
{
    public class StructTests : MethodBoundaryAspectTestBase
    {
        [Fact]
        public void IfStructIsWoven_ThenInstanceMethodShouldBeWoven()
        {
            // Arrange
            const string testMethodName = "InstanceMethodCall_ReferenceType";
            var testClassType = typeof(Struct);

            // Act
            WeaveAssemblyMethodAndLoad(testClassType, testMethodName);
            var result = AssemblyLoader.InvokeMethod(testClassType.TypeInfo(), testMethodName, "arg");

            // Assert
            result.Should().Be("arg");
        }

        [Fact]
        public void IfStructIsWoven_ThenStaticMethodShouldBeWoven()
        {
            // Arrange
            const string testMethodName = "StaticMethodCall_ReferenceType";
            var testClassType = typeof(Struct);

            // Act
            WeaveAssemblyMethodAndLoad(testClassType, testMethodName);
            var result = AssemblyLoader.InvokeMethod(testClassType.TypeInfo(), testMethodName, "arg");

            // Assert
            result.Should().Be("arg");
        }
    }
}
