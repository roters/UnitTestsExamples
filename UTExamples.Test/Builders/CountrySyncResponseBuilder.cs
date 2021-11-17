using System;

namespace UTExamples.Test.Builders
{
    public class CountrySyncResponseBuilder
    {
        private CountrySyncResponse _countrySyncResponse = new CountrySyncResponse();

        public CountrySyncResponseBuilder WithTitle(string title)
        {
            _countrySyncResponse.Title = title;
            return this;
        }

        //public CountrySyncResponseBuilder WithSection(string contentType)
        //{
        //    var section = new SectionSyncResponseBuilder().WithContentType(contentType).Build();
        //    _countrySyncResponse.Sections = new[] { section };

        //    return this;
        //}

        public CountrySyncResponseBuilder WithSection(Func<SectionSyncResponseBuilder> sectionBuilder)
        {
            var section = sectionBuilder().Build();
            _countrySyncResponse.Sections = new[] { section };

            return this;
        }

        public CountrySyncResponse Build()
        {
            return _countrySyncResponse;
        }
    }
}
