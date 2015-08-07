﻿using System;
using MethodBoundaryAspect.Fody.UnitTests.TestAssembly.Aspects;

namespace MethodBoundaryAspect.Fody.UnitTests.TestAssembly
{
    public class TryCatchMethods
    {
        [SetExceptionValueAspect]
        public void InstanceMethodCallWithTryCatch()
        {
            try
            {
                throw new InvalidOperationException("InstanceMethodCallWithTryCatch");
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void InstanceMethodCallWithTryCatchNotWeaved()
        {
            try
            {
                throw new InvalidOperationException("InstanceMethodCall");
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}