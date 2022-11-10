using AutoFixture;
using AutoFixture.AutoMoq;
using AutoFixture.NUnit3;

namespace AutoFixtureMocking.Tests
{
    internal class AutoMoqDataAttribute : AutoDataAttribute
    {
        public AutoMoqDataAttribute()
            : base(() => {

                var fixture = new Fixture();
                fixture.Customize(new AutoMoqCustomization { ConfigureMembers = true, GenerateDelegates = true });
                return fixture;

            })
        {}
    }
}
