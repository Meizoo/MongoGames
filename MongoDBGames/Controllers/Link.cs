namespace MongoDBGames.Controllers
{
	public class Link
    {
        public Link(string href, string rel, string method)
        {
            this.Href = href;
            this.Rel = rel;
            this.Method = method;
        }

        public string Href { get; private set; }
        public string Rel { get; private set; }
        public string Method { get; private set; }
    }
}
