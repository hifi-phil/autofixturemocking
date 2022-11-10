using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Moq;
using AutoFixture;
using AutoFixture.NUnit3;

namespace AutoFixtureMocking.Tests
{
    public class WithAutoMoq
    {

        [Test, AutoMoqData]
        public void Should_do_something(
            string name,
            [Frozen] Dependency dependency, 
            ServiceUnderTest svc)
        {
            svc.AddValueToDependency(name);
            Assert.AreEqual(name, dependency.Name);
        }

    }
}
