using StacksAndQueues.Backend;

try
{
    var stack = new StackUsingArray<string>(5);
    stack.Push("Perro");
    stack.Push("Gato");
    stack.Push("Pajaro");
    stack.Push("Pez");
    stack.Push("Conejo");
    Console.WriteLine(stack.Pop());
}
catch (Exception ex)
{
    Console.WriteLine($"An error occurred: {ex.Message}");
}