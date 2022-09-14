namespace Assignment1;

public class Iterators
{
    public static IEnumerable<T> Flatten<T>(IEnumerable<IEnumerable<T>> items) => items.SelectMany(x=>x).ToList(); 

    
    //List<int> flatList =Enumerable.SelectMany(T=>T).ToList();
    //Console.WriteLine(String.Join(",", flatList));

    
    public static IEnumerable<T> Filter<T>(IEnumerable<T> items, Predicate<T> predicate){
       
    foreach(T i in items){
        if(predicate(i)){
            yield return i;

        }
    }
}
}


