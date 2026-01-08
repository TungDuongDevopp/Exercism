public static class ResistorColorDuo
{
    public static int Value(string[] colors)
    {
        List< string> colorsList= colors.ToList();
        if(colorsList.Count>2){
        for(int i=2;i<colorsList.Count;i++){
            colorsList.RemoveAt(i);
        }
        }
        string[] color={"black","brown","red","orange","yellow","green","blue","violet","grey","white"};
       string code="";
        foreach(var s in colorsList){
            if(color.Contains(s)){
                code+=Array.IndexOf(color,s);
            }
        }
        return Convert.ToInt32(code);
    }
}
