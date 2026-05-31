static class Badge
{
     public static string Print(int? id, string name, string? department)
     {
          string result;
 return result = id != null ? $"[{id}] - {name ?? "Noname"} - {department?.ToUpper() ?? "OWNER"}" : $"{name ?? "Noname"} - {department?.ToUpper() ?? "OWNER"}";
     }

}