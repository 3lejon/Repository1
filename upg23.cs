Console.Write("enter a number");
if(TryParse(Console.ReadLine(), out int result));
{
    Console.WriteLine("sucsess" + result);
}

else
{
    Console.WriteLine("oh no something went wrong");
}

static bool TryParse(string input, out int result);
{
    result = 0;
    try
    {
        result = Convert.ToInt32(input);

    }
    catch(Exception)
    {
        return false;
    }


}