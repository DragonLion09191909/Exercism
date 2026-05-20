using System.Text;

 public static class Identifier
 {
     public static string Clean(string identifier)
     {
         if (string.IsNullOrEmpty(identifier)) return identifier;

         StringBuilder sb = new StringBuilder();
         bool convertToUpper = false;

         for (int i = 0; i < identifier.Length; i++)
         {
             char ch = identifier[i];

             if (char.IsWhiteSpace(ch)) sb.Append('_');

             else if (char.IsControl(ch)) sb.Append("CTRL");

             else if (ch == '-') convertToUpper = true;


             else if (ch >= 'α' && ch <= 'ω') continue;

             else if (char.IsLetter(ch))
             {
                 if (convertToUpper)
                 {
                     sb.Append(char.ToUpper(ch));
                     convertToUpper = false;
                 }
                 else
                 {
                     sb.Append(ch);
                 }
             }

         }

         return sb.ToString();
     }
 }