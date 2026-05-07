public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
      return (phoneNumber.StartsWith("212"), phoneNumber.Substring(4, 3).All(c => c == '5'), phoneNumber[^4..]);
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)
    {
        return phoneNumberInfo.IsFake == true ? true : false;
    }
}
