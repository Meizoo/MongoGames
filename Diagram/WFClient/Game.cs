using System.Collections.Generic;

namespace WFClient
{
    public class Game
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Developer { get; set; }

        public string Publisher { get; set; }

        public List<string> Platforms { get; set; }
    }
}