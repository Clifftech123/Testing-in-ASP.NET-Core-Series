using AspNetCore_Testing_Part4_UnitTesting_XUnit;
using FluentAssertions;

namespace TestProjectCore
{
    public class UnitTest1
    {

        // First test case 
        [Fact]
        public void DefaultConstructor_ShouldInitializeWithDefaultValues()
        {
            // Arrange  and act 
            var testObject = new TestObjectDateListICollection();

            // Assert 
            testObject.Name.Should().Be("Default");
            testObject.CreatedDate.Date.Should().BeCloseTo(DateTime.Now.Date, TimeSpan.FromSeconds(1));
            testObject.StringList.Should().NotBeNull().And.BeEmpty();
            testObject.Properties.Should().NotBeNull().And.BeEmpty();

        }


        //

        [Fact]

        public void ParameterizedConstructor_ShouldSetProvidedValues()
        {
            // Arrange 
            string expectedName = "Test Object";
            DateTime expectedCreatedDate = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc);

            // Act 
            var testObject = new TestObjectDateListICollection(expectedName, expectedCreatedDate);

            // Assert 

            testObject.Name.Should().Be(expectedName);
            testObject.CreatedDate.Should().Be(expectedCreatedDate);
            testObject.StringList.Should().NotBeNull().And.BeEmpty();
            testObject.Properties.Should().NotBeNull().And.BeEmpty();

        }



        [Fact]
        public void AddToStringList_ShouldAddItemToList()
        {
            // Arrange 
            var testObejct = new TestObjectDateListICollection();
            string itemToAdd = "Test string";
            string itemToAdd2 = "Test string";
            string itemToAdd3 = "Test string";
            string itemToAdd4 = "Test string";
            // Act
            testObejct.AddToStringList(itemToAdd);
            testObejct.AddToStringList(itemToAdd2);
            testObejct.AddToStringList(itemToAdd3);
            testObejct.AddToStringList(itemToAdd4);


            // Assert 
            testObejct.StringList.Should().Contain(itemToAdd);
            testObejct.StringList.Should().Contain(itemToAdd2);
            testObejct.StringList.Should().Contain(itemToAdd3); testObejct.StringList.Should().Contain(itemToAdd4);
            testObejct.StringList.Count.Should().Be(4);

        }


        [Fact]
        public void AddToNumberCollection_ShouldAddNumberToCollection()
        {
            //Arrange 
            var testObject = new TestObjectDateListICollection();
            int numberToAdd = 42;
            int numberToAdd2 = 43;
            int numberToAdd3 = 44;
            int numberToAdd4 = 45;
            int numberToAdd5 = 50;

            // Act 
            testObject.AddToNumberCollection(numberToAdd);
            testObject.AddToNumberCollection(numberToAdd2);
            testObject.AddToNumberCollection(numberToAdd3);
            testObject.AddToNumberCollection(numberToAdd4);



            // Assert 
            testObject.NumberCollection.Should().Contain(numberToAdd);
            testObject.NumberCollection.Should().Contain(numberToAdd2);
            testObject.NumberCollection.Should().Contain(numberToAdd3);
            testObject.NumberCollection.Should().Contain(numberToAdd4);
            testObject.NumberCollection.Should().NotContain(numberToAdd5);
            testObject.NumberCollection.Count.Should().Be(4);

        }




        [Fact]
        public void AddProperty_ShouldAddNewPropertyToCollection()
        {

        }




        [Fact]
        public void AddProperty_ShouldUpdateExistingProperty()
        {

        }



        [Fact]
        public void IsCreatedToday_ShouldReturnTrueForTodaysDate()
        {

        }



        [Fact]
        public void DaysSinceCreation_ShouldReturnCorrectNumberOfDays()
        {

        }


        [Fact]
        public void GetTotalItemCount_ShouldReturnSumOfAllCollectionCounts()
        {

        }

        [Fact]
        public void ClearAllCollections_ShouldEmptyAllCollections()
        {

        }


        [Fact]
        public void CreatedDate_ShouldSetAndGetCorrectly()
        {

        }
    }
}
