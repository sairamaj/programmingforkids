using Markdig;

namespace Web.Shared.Model
{
	public class Resource
    {
        public int Order { get; set; }
        public string Title { get; set; }
        public string Info { get; set; }

        public string InfoAsMarkdown
        {
            get
            {
                if (string.IsNullOrWhiteSpace(this.Info))
                {
                    return string.Empty;
                }
                return Markdown.ToHtml(this.Info);
            }
        }

    }
}
