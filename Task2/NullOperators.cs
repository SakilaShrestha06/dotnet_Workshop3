namespace Task2;

class NullOperations
{
public void PerformNullChecks()
{
    string username = null;
    string msg1 = (username == null) ? "Username is not available" : username;
    Console.WriteLine(msg1);
    Console.WriteLine(username ?? "Username is not available");
    username ??= "GuestUser";
    Console.WriteLine($"Updated username: {username}");


}
}