using AutoFixture;
using AutoFixture.Xunit2;
using Shouldly;
using UTExamples.Test.Builders;
using Xunit;

namespace UTExamples.Test
{
    public class CountryProcessorTest
    {
        [Fact]
        public void GetBlocksNames_PassingCorrectObject_ReturnsConcatenatedBlockNames()
        {
            //Arrange
            var fixture = new Fixture();
            var countryResponse = fixture.Create<CountrySyncResponse>();

            var sut = new CountryProcessor();
            var result = sut.GetBlocksNames(countryResponse);

            result.ShouldNotBeEmpty();
        }

        [Theory]
        [AutoData]
        public void GetBlocksNames_PassingCorrectObject_ReturnsConcatenatedBlockNames_AutoData(CountryProcessor sut, CountrySyncResponse countrySyncResponse)
        {
            var result = sut.GetBlocksNames(countrySyncResponse);

            result.ShouldNotBeEmpty();
        }

        [Fact]
        public void GetSectionContentTypes_PassingCorrectObject_ReturnsConcatenatedSectionNames_Builder()
        {
            var expected = "SectionName";

            var countrySyncResponse =
                new CountrySyncResponseBuilder()
                    .WithTitle("Test")
                    .WithSection(() => new SectionSyncResponseBuilder().WithContentType(expected))
                    .Build();

            var sut = new CountryProcessor();
            var result = sut.GetSectionNames(countrySyncResponse);

            result.ShouldNotBeEmpty();
            result.ShouldBe(expected);
        }
    }
}
