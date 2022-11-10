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
    public class WithAutoMoq2
    {

        [Test, AutoMoqData]
        [InlineAutoData("test")]
        [InlineAutoData("test2")]
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
