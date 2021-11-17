namespace UTExamples.Test.Builders
{
    public class SectionSyncResponseBuilder
    {
        private SectionSyncResponse _countrySyncResponse = new SectionSyncResponse();

        public SectionSyncResponseBuilder WithContentType(string contentType)
        {
            _countrySyncResponse.ContentType = contentType;
            return this;
        }

        public SectionSyncResponse Build()
        {
            return _countrySyncResponse;
        }
    }
}
