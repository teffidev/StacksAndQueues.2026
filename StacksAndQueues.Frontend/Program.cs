using StacksAndQueues.Backend;

try
{
    var stack = new StackUsingArray<int>(5);
}
catch (Exception ex)
{
    Console.WriteLine($"An error occurred: {ex.Message}");
}