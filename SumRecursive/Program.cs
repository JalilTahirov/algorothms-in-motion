// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var res = sum(new List<int>() { 2,3,4});

Console.WriteLine(res);


int sum(List<int> arr) 
{
    // base case is when array has only one element
    if (arr.Count == 1)
    {
        return arr[0];
    }
    var value = arr[arr.Count - 1];
    arr.RemoveAt(arr.Count - 1);
    return value + sum(arr);

}
