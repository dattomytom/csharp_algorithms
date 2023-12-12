using BubbleSortAlgorithms;

namespace BubbleSortAlgorthm
{
    public class BubbleSortAlgorithmsTests
    {
        BubbleSortMethods _bubbleSortMethodsTest;

        [Fact]
        public void SortArray_GivenUnsortedArray_ReturnSortedArray()
        {
            //Arrange
            var array = new int[] { 73, 57, 49, 99, 133, 20, 1 };
            var expected = new int[] { 1, 20, 49, 57, 73, 99, 133 };
            _bubbleSortMethodsTest = new BubbleSortMethods();
            _bubbleSortMethodsTest.NumArray = array;


            //Act
            var sortedArray = _bubbleSortMethodsTest.SortArray();

            //Assert
            Assert.Equal(expected, sortedArray);
        }
        [Fact]
        public void SortOptimizedArray_GivenUnsortedArray_ReturnSortedArray()
        {
            //Arrange
            var array = new int[] { 73, 57, 49, 99, 133, 20, 1 };
            var expected = new int[] { 1, 20, 49, 57, 73, 99, 133 };
            _bubbleSortMethodsTest = new BubbleSortMethods();
            _bubbleSortMethodsTest.NumArray = array;


            //Act
            var sortedArray = _bubbleSortMethodsTest.SortOptimizedArray();

            //Assert
            Assert.Equal(expected, sortedArray);
        }
        [Fact]
        public void SortArray_GivenUnsortedArray_ReturnCheckInstanceType()
        {
            //Arrange
            _bubbleSortMethodsTest = new BubbleSortMethods();
            _bubbleSortMethodsTest.NumArray = BubbleSortMethods.GenerateRandomNumber(300);

            //Act
            var sortedArray = _bubbleSortMethodsTest.SortArray();

            //Assert
            Assert.IsType<int[]>(sortedArray);

        }
    }
}