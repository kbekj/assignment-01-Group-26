namespace Assignment1;

using System.Text.RegularExpressions;

public static class RegExpr
{
    public static IEnumerable<string> SplitLine(IEnumerable<string> lines){
        foreach(string line in lines){
            var splitLine = Regex.Split(line, @"\s+");
            foreach(string word in splitLine){
                yield return word;
            }
        }
    }

    public static IEnumerable<(int width, int height)> Resolution(string resolutions){
        string match1 ="";
        string match2 ="";
        int i = 0;
        foreach(Match match in Regex.Matches(resolutions, @"[0-9]+")){
            var matchvalue = match.ToString();
            if (i%2==0){
                match1 = matchvalue;
            }else{
                match2 = matchvalue;
                yield return (Int32.Parse(match1), Int32.Parse(match2));
            }
            i++;
        }
    }    

    public static IEnumerable<string> InnerText(string html, string tag){

        foreach(Match match in Regex.Matches(html, @"([A-Za-z ]+)</"+ tag +@">")){
            string innerText = match.Groups[1].ToString();
            yield return innerText; 
        }
    }
}