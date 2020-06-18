using System.Collections.Generic;

namespace PdfGen
{
    public class Game
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Developer { get; set; }

        public string Publisher { get; set; }

        public List<string> Platforms { get; set; }
    }

    class Test
	{
        static void Main()
        {
            var item = new Game
            {
                Id = "Ajdi",
                Name = "Nejm",
                Developer = "Deweloper",
                Publisher = "Pabliszer",
                Platforms = new List<string>
                {
                    "Łindołs", "Mak"
                }
            };

            using (var pdf = new PdfBuilder("test.pdf"))
                pdf.AddParagraph(
                    string.Concat("Id: ", item.Id),
                    string.Concat("Nazwa: ", item.Name),
                    string.Concat("Deweloper: ", item.Developer),
                    string.Concat("Wydawca: ", item.Publisher),
                    string.Concat("Wspierane platformy: ", string.Join(", ", item.Platforms))
                );
        }
    }
}
