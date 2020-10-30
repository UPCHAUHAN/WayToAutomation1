using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WayToAutomation.Configuration;

namespace WayToAutomation
{
    
    public class UnitTest2
    {
        public UnitTest2()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
       
        public void TestMethod1()
        {
            
            Console.WriteLine("Browser: {0}", AppConfigReader.getBrowser);
            Console.WriteLine("Username: {0}", AppConfigReader.userName);
            Console.WriteLine("Password: {0}", AppConfigReader.getpasswor);
        }
    }
}
