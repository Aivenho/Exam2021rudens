using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Element.Tests

{
    [TestFixture()]
    public class ElementTests
    {
        IWebDriver driver;

        [Test()]
        [TestCase("gh-ac", ExpectedResult = false, TestName = "Element gh-ac exists")]
        [TestCase("gh-btn", ExpectedResult = false, TestName = "Element gh-btn exists")]
        [TestCase("neatrodams", ExpectedResult = false, TestName = "Element neatrodams doesn't exist")]

        public bool Check(string p)
        {

         driver.FindElement(By.Id(p))


        }



 

    }   
}

