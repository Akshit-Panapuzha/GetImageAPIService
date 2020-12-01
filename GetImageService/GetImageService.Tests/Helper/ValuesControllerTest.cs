using Microsoft.VisualStudio.TestTools.UnitTesting;
using GetImageService.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetImageService.Helper.Tests
{
    [TestClass()]
    public class ValuesControllerTest
    {
        [TestMethod()]
        public void SaveBase64Test()
        {
            ValueControllerHelper vhelp = new ValueControllerHelper();
            string fName = "Test";
            string sImage = "xsfcsdadswfdvdvdfggdfdfssdawbfbfhtrt";
            bool result = vhelp.SaveBase64(fName, sImage);
            if(!result)
            Assert.Fail();
        }
    }
}