using GeekSeven.GeekUI.Attributes;

namespace GeekSeven.GeekUI.Extensions
{
    public static class EnumExtensions
    {
        public static string ToIcon(this ESegoeMDL2Assets assets)
        {
            var attributes = (SegoeMDL2AsstetsAttribute[])assets.GetType().GetField(assets.ToString()).GetCustomAttributes(typeof(SegoeMDL2AsstetsAttribute), false);
            return attributes.Length > 0 ? attributes[0].Icon : string.Empty;
        }
    }
}
