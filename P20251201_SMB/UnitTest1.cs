namespace P20251201_SMB
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            /*Console.WriteLine("E-mail: ");
           string jelszo=Convert.ToString(Console.ReadLine());*/

        }

        [Test]
        public void Test1()
        {
           StringAssert.Contains("@","pelda@gmail.com");

        }
    }
}