public class Robot
{
    private static Random rd = new Random();
    private static HashSet<string> usedNames = new HashSet<string>();

    private string name;

    public string Name
    {
        get
        {
            if (name == null)
            {
                string newName;

                do
                {
                    string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                    char first = chars[rd.Next(chars.Length)];
                    char second = chars[rd.Next(chars.Length)];
                    int number = rd.Next(0, 1000);

                    newName = $"{first}{second}{number:D3}";
                }
                while (!usedNames.Add(newName)); // trùng thì lặp

                name = newName;
            }

            return name;
        }
    }

    public void Reset()
    {
        name = null;
    }
}
