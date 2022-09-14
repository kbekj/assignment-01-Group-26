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

    public static IEnumerable<(int width, int height)> Resolution(IEnumerable<string> resolutions){
        foreach(string line in resolutions){
            foreach(Match match in Regex.Matches(line, @"(?<width>[0-9]+)x(?<height>[0-9]+)")){ 
            yield return (Int32.Parse(match.Groups.GetValueOrDefault("width").ToString()), Int32.Parse(match.Groups.GetValueOrDefault("height").ToString()));
            }
        }
    }    

    public static IEnumerable<string> InnerText(string html, string tag){
        foreach(Match match in Regex.Matches(html, @"<(" + tag + @").*?>.+?</\1>")){
            string innerText = Regex.Replace(match.ToString(), @"<.+?>", "");
            yield return innerText; 
        }
    }

    public static IEnumerable<(Uri, string)> Urls(string html){
        foreach(Match match in Regex.Matches(html, @"href=.([a-z:./A-Z_()]+). ?title=.([a-zA-Z ()]+).")){
            var groups = match.Groups;
            yield return (new Uri(groups[1].ToString()), groups[2].ToString());
        }
    }
}