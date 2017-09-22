using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace jQuerySignaturePad.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }


        public string SaveImage(string strImage)
        {
            Response.Clear();
            Response.ContentType = "application/octet-stream";
            Response.ContentType = "application/x-download";
            Response.AddHeader("Content-Disposition", "attachment; filename=" + strImage);
            Response.WriteFile(Server.MapPath(strImage));
            Response.End();

            //byte bitmap = Convert.ToByte(strImage);
            //using (Image image = Image.FromStream(new MemoryStream(bitmap)))
            //{
            //    image.Save("output.jpg", ImageFormat.Jpeg);  // Or Png
            //}
            //string toFileName = "MySign.bmp";
            //WebClient myWebClient = new WebClient();
            //try
            //{
            //    myWebClient.DownloadFile(strImage, toFileName);
            //}
            //catch (WebException ex)
            //{
               
            //} 
            return "";
        }


    }
}
