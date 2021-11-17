using System.Text;

namespace UTExamples
{
    public class CountryProcessor
    {
        public string GetSectionNames(CountrySyncResponse country)
        {
            var sb = new StringBuilder();

            var contentTypes = country.Sections.Select(b => b.ContentType);
            foreach (var contentType in contentTypes)
            {
                if (sb.Length > 0)
                    sb.AppendFormat(", ");

                sb.Append($"{contentType}");
            }

            return sb.ToString();
        }

        public string GetBlocksNames(CountrySyncResponse country)
        {
            var sb = new StringBuilder();

            var blocksNames = country.Sections.SelectMany(s => s.ContentBlocks).Select(b => b.Name);
            foreach (var blockName in blocksNames)
            {
                if (sb.Length > 0)
                    sb.AppendFormat(", ");

                sb.Append($"{blockName}");
            }

            return sb.ToString();
        }
    }
}
