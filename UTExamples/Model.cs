namespace UTExamples
{
    public class CountrySyncResponse
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Country { get; set; }
        public string Ingress { get; set; }
        public DateTime PublishedDate { get; set; }
        public DateTime LastSavedDate { get; set; }
        public SectionSyncResponse[] Sections { get; set; }
    }

    public class SectionSyncResponse
    {
        public string ContentType { get; set; }
        public BlockSyncResponse[] ContentBlocks { get; set; }
    }

    public class BlockSyncResponse
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Text { get; set; }
        public bool Expanded { get; set; }
        public bool Visible { get; set; }
        public DateTime LastSavedDate { get; set; }
    }
}
