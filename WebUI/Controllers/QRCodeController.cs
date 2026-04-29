using Microsoft.AspNetCore.Mvc;
using QRCoder;

namespace WebUI.Controllers
{
    public class QRCodeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string value)
        {
            QRCodeGenerator generator = new QRCodeGenerator();
            QRCodeData qrCodeData = generator.CreateQrCode(value, QRCodeGenerator.ECCLevel.Q);
            PngByteQRCode qrCode = new PngByteQRCode(qrCodeData);
            byte[] qrCodeBytes = qrCode.GetGraphic(10);
            ViewBag.QrCodeImage = "data:image/png;base64," + Convert.ToBase64String(qrCodeBytes);
            return View();
        }
    }
}
