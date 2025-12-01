namespace P20251201_SMB
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

            string jelszo = "Qwertz1234";
            int jelszohossz=jelszo.Length;
        }

        [Test]
        public void Test1()
        {
           StringAssert.Contains("@","pelda@gmail.com");
           


        }
        [Test]
        public void Test2()
        {
            StringAssert.Contains("1234", "pelda@gmail.com");
        }
        [Test]
        public void Test3()
        {
            StringAssert.EndsWith(".com", "pelda@gmail.hu");
        }
        [Test]
        public void Test4()
        {
            StringAssert.StartsWith("+36", "+36301213453");
        }
        [Test]
        public void Test5()
        {
            string jelszo = "Qwertz1234";
            int jelszohossz = jelszo.Length;

            Assert.Equals(jelszohossz,10);
        }
    }
}