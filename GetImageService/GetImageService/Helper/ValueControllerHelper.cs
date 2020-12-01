using System;
using System.IO;
using System.Web;
using System.Web.Configuration;

namespace GetImageService.Helper
{
    public class ValueControllerHelper
    {
        public bool SaveBase64(string FileName, string Base64ImageString)
        {
            try
            {
                var imageLocationt=WebConfigurationManager.AppSettings["ImageLocation"];
                var fileType = WebConfigurationManager.AppSettings["FileType"];
                string folder = System.Web.Hosting.HostingEnvironment.MapPath("~/") + imageLocationt;
                if (!Directory.Exists(imageLocationt))
                {
                    Directory.CreateDirectory(imageLocationt);
                }

                string filePath = imageLocationt + "/" + FileName + "." + fileType;
                File.WriteAllBytes(filePath, Convert.FromBase64String(Base64ImageString));
                return true;
            }
            catch (Exception ex)
            {
                string error = ex.ToString();
                return false;
            }

        }

        public bool SaveDataFromName(string FileName)
        {
            return true;
        }
    }
}
