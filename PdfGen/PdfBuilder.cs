using System;
using System.Linq;

using iText.IO.Font.Constants;
using iText.Kernel.Font;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;

namespace PdfGen
{
	public sealed class PdfBuilder : IDisposable
	{
		public PdfBuilder(
				string filename = "unnamed.pdf",
				DocumentType documentType = DocumentType.Blank
			)
		{
			PdfFont font = PdfFontFactory.CreateFont(StandardFonts.TIMES_ROMAN);
			this.style = new Style();
			this.style.SetFont(font);

			this.writer = new PdfWriter(filename);

			this.pdf = new PdfDocument(this.writer);
			this.pdf.AddNewPage();

			this.doc = new Document(this.pdf);

			this.documentType = documentType;
		}

		public PdfBuilder SetFilename(string filename)
		{
			this.writer.Dispose();
			this.writer = new PdfWriter(filename);
			return this;
		}

		public PdfBuilder AddParagraph(params string[] text) =>
			Add(this.currentParagraph = new Paragraph(string.Join(Environment.NewLine, text)));

		public PdfBuilder AddText(string text)
		{
			if (this.currentParagraph is null)
				return AddParagraph(text);
			else
				this.currentParagraph.Add(new Text(text));
			return this;
		}

		public PdfBuilder AddTable(params string[] cells)
		{
			Table table = new Table(UnitValue.CreatePercentArray(8)).UseAllAvailableWidth();

			foreach (var i in cells)
				table.AddCell(i);

			this.doc.Add(table);

			return this;
		}

		public PdfBuilder AddList(
				ListNumberingType numberingType = ListNumberingType.Decimal,
				params string[] points
			) => Add(
				Enumerable
					.Repeat(new List((iText.Layout.Properties.ListNumberingType)numberingType), 1)
					.Select(i => points.Select(j => i.Add(j)).LastOrDefault())
					.FirstOrDefault()
			);

		public void Dispose()
		{
			if (this.isDisposed)
				return;

			this.isDisposed = true;

			this.currentParagraph = null;

			this.doc.Close();
			this.pdf.Close();
			this.writer.Close();
		}

		private PdfBuilder Add<T>(BlockElement<T> element)
			where T : IElement
		{
			this.doc.Add(element.AddStyle(this.style) as IBlockElement);
			return this;
		}

		private Paragraph currentParagraph;

		private PdfWriter writer;

		private readonly Document doc;
		private readonly Style style;
		private readonly PdfDocument pdf;
		private readonly DocumentType documentType;
		private bool isDisposed = false;
	}
}
