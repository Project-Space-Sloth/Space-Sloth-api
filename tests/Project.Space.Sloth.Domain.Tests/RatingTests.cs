using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project.Space.Sloth.Domain;
using Project.Space.Sloth.Domain.Catalog;


namespace Project.Space.Sloth.Domain.Tests;

[TestClass]
public class RatingTests
{
    [TestMethod]
    public void Can_Create_New_Rating() {
        //arrange
        var rating = new Rating(1, "Mike", "Great fit!");

        //Act (empty)

        // Assert
        Assert.AreEqual(1, rating.Stars);
        Assert.AreEqual("Mike", rating.UserName);
        Assert.AreEqual("Great fit!", rating.Review);
    }

    [TestMethod]
    [ExpectedException(typeof(System.ArgumentException))]
    public void Cannot_Create_Rating_With_Invalid_Stars(){
        //arrange
        var rating = new Rating(0, "Mike", "Great fit!");
    }
}