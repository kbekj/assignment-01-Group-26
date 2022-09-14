namespace Assignment1.Tests;

public class IteratorsTests
{

[Fact]
public void iterator_Tests(){

//Arrange
int[] list={1, 2, 3, 4};
int[] list2={6,7};

//Act
var superList= new List<IEnumerable<int>>();
superList.Add(list);
superList.Add(list2);
var flat=Iterators.Flatten(items:superList);

//Assert
Assert.Equal(new[]  {1,2,3,4,6,7}, flat);

}

[Fact]
public void filter_Test(){
int[] evenlist={2,4,3};

Predicate<int> even = Even;
    bool Even(int i) => i % 2 == 0;

var isEven=Iterators.Filter(evenlist, Even);

Assert.Equal( new List<int>{2,4} , isEven);
}



}