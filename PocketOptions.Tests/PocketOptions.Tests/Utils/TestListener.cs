using NUnit.Framework.Interfaces;
using OpenQA.Selenium;

namespace PocketOptions.Tests.Utils
{
    public class TestListener : ITestListener
    {
        public void SendMessage(TestMessage message)
        {

        }

        public void TestFinished(ITestResult result)
        {

        }

        public void TestOutput(TestOutput output)
        {

        }

        public void TestStarted(ITest test)
        {

        }

    }
}