namespace PdfGen
{
	class Test
	{
		static void Main()
		{
			using (var pdf = new PdfBuilder())
				pdf
					.AddParagraph("AAAAAAAAAA", "b\tb")
					.AddList(ListNumberingType.Decimal, "bbbb", "cc")
				 ;
		}
	}
}
