namespace R3BinderTools.Helpers
{
    using System.Reflection;
    using System.Runtime.InteropServices;

    public static class MutEx
    {
        public static string GetGUID()
        {
            string result;
            try
            {
                Assembly assembly = typeof(Program).Assembly;
                var attribute = (GuidAttribute)assembly.GetCustomAttributes(typeof(GuidAttribute), true)[0];
                result = attribute.Value;
            }
            catch { result = "FHQD4313-33DE-489D-9721-6AFF69841DEA"; }
            return result?.ToUpper();
        }
    }
}