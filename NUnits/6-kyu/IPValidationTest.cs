using CodeWars._6_kyu;

namespace NUnits;

public class IPValidationTests
{

    [Test]
    public void IPIsEmptyTest()
    {
        Assert.That(IPValidation.IsValidIp(""), Is.EqualTo(false));
    }

    [Test]
    public void IPIsntFourOctetsFormatTest()
    {
        Assert.AreEqual(false, IPValidation.IsValidIp("12.34.56"));
    }
    
    [Test]
    public void ValidIPsTest()
    {
        Assert.AreEqual(true, IPValidation.IsValidIp("0.0.0.0"));
        Assert.AreEqual(true, IPValidation.IsValidIp("12.255.56.1"));
        Assert.AreEqual(true, IPValidation.IsValidIp("137.255.156.100"));
        Assert.AreEqual(true, IPValidation.IsValidIp("99.116.11.181"));
    }
    
    [Test]
    public void IPIsntInNumberFormatTest()
    {
        Assert.AreEqual(false, IPValidation.IsValidIp("abc.def.ghi.jkl"));
    }

    [Test]
    public void InvalidIPsTest()
    {
         Assert.AreEqual(false, IPValidation.IsValidIp("123.456.789.0"));
         Assert.AreEqual(false, IPValidation.IsValidIp("12.34.56.00"));
         Assert.AreEqual(false, IPValidation.IsValidIp("12.34.56.7.8"));
         Assert.AreEqual(false, IPValidation.IsValidIp("12.34.256.78"));
         Assert.AreEqual(false, IPValidation.IsValidIp("1234.34.56"));
         Assert.AreEqual(false, IPValidation.IsValidIp("pr12.34.56.78"));
         Assert.AreEqual(false, IPValidation.IsValidIp("12.34.56.78sf"));
         Assert.AreEqual(false, IPValidation.IsValidIp("12.34.56 .1"));
         Assert.AreEqual(false, IPValidation.IsValidIp("12.34.56.-1"));
         Assert.AreEqual(false, IPValidation.IsValidIp("123.045.067.089"));
     }
}