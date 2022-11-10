using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Moq;

namespace AutoFixtureMocking.Tests
{
    public class WithoutAutoMoq
    {
        private string name;

        private Mock<ServiceUnderTest> _svc;
        private Mock<Dependency> _dependency;

        [OneTimeSetUp]
        public void Startup()
        {
            _dependency = new Mock<Dependency>();
            _svc = new Mock<ServiceUnderTest>( MockBehavior.Loose, _dependency.Object);
        }

        [Test]
        public void Should_do_something()
        {
            name = "Test";
            _svc.Object.AddValueToDependency(name);

            Assert.AreEqual(name, _dependency.Object.Name);
        }

    }

    public class ServiceUnderTest
    {
        private readonly Dependency _dependency;

        public ServiceUnderTest(Dependency dependency) 
        {
            _dependency = dependency;
        }

        public void AddValueToDependency(string name)
        {
            _dependency.Name = name;
        }

    }

    public class Dependency
    {
        public string Name { get; set; }
    }
}
