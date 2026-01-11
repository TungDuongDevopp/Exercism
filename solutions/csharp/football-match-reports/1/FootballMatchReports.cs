using System.Reflection;
public static class PlayAnalyzer
{
    public static string AnalyzeOnField(int shirtNum) =>
    shirtNum switch
    {
        1 => "goalie",
        2 => "left back",
        3 or 4 => "center back",
        5 => "right back",
        6 or 7 or 8 => "midfielder",
        9 => "left wing",
        10 => "striker",
        11 => "right wing",
        _ => "UNKNOWN"
    };

  
public static string AnalyzeOffField(object report)
{
    switch (report)
    {
        case int number:
            return $"There are {number} supporters at the match.";

        case string sentence:
            return sentence;

        case Injury injury:
                // Lấy field private đầu tiên (chính là số áo)
                var field = typeof(Injury)
                    .GetFields(BindingFlags.Instance | BindingFlags.NonPublic)[0];

                int playerNumber = (int)field.GetValue(injury)!;

                return $"Oh no! Player {playerNumber} is injured. Medics are on the field.";


        case Foul:
            return "The referee deemed a foul.";

        case Incident:
            return "An incident happened.";
                case Manager manager:
                return manager.Club is null
                    ? manager.Name
                    : $"{manager.Name} ({manager.Club})";
            
        default:
            return "";
    }
}

}




