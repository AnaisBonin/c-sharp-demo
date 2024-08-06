using CSharpMac;

namespace CSharpMacTests;

[TestClass]
public class UserServiceTest
{
    [TestMethod]
    public void TestWhen18()
    {
        // GIVEN
        UserService target = new();

        // WHEN
        string result = target.DefineUserStatus(18);

        // THEN
        Assert.AreEqual("majeur", result);
    }

    [TestMethod]
    public void TestWhenMineur()
    {
        // GIVEN
        UserService target = new();

        // WHEN
        string result = target.DefineUserStatus(12);

        // THEN
        Assert.AreEqual("mineur", result);
    }

    [TestMethod]
    public void TestWhenMajeur()
    {
        // GIVEN
        UserService target = new();

        // WHEN
        string result = target.DefineUserStatus(24);

        // THEN
        Assert.AreEqual("majeur", result);
    }
}
