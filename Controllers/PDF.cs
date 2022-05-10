using Microsoft.AspNetCore.Mvc;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;

namespace ImagineDreams.Controllers
{

    [Route("service/[controller]")]
    [ApiController]
    public class PDF : Controller
    {
        [HttpPost]
        public void GenerarPdf()
        {
            // PdfReader reader = new PdfReader("C:\\Users\\Willintong.Dev\\Desktop\\form.pdf");
            // Console.WriteLine(reader);
            string templatePDF = @"  <table style=""border-color: red; border: 1px; border-radius: 5px;"">
        <tr>
          <th>ID</th>
          <th>Name</th>
          <th>Description</th>
        </tr>
        <tr>
            <td>01</td>
            <td>Testing name</td>
            <td>Testing description</td>
        </tr>
    </table>";
            using (FileStream stream = new FileStream("C:\\Users\\Willintong.Dev\\Desktop\\test.pdf", FileMode.Create))
            {
                Document pdfDoc = new Document(PageSize.LETTER, 3, 3, 5, 5);
                PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
                pdfDoc.Add(new Phrase(""));
                using(StringReader sr = new StringReader(templatePDF))
                {
                    XMLWorkerHelper.GetInstance().ParseXHtml(writer,pdfDoc,sr);
                }
                pdfDoc.Close();
                stream.Close();
            }
        }
    }
}