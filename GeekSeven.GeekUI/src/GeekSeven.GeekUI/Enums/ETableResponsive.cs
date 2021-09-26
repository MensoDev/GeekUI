namespace GeekSeven.GeekUI
{
    public enum ETableResponsive
    {
        TableResponsiveSmall,
        TableResponsiveMedium,
        TableResponsiveLarge,
        TableResponsiveExtraLarge,
        TableResponsiveAuto,
        None
    }

    public static class ETableResponsiveExtension
    {
        public static string ToStringResponsiveTable(this ETableResponsive responsive)
        {
            switch (responsive)
            {
                case ETableResponsive.TableResponsiveSmall: return "table-responsive-sm";
                case ETableResponsive.TableResponsiveMedium: return "table-responsive-md";
                case ETableResponsive.TableResponsiveLarge: return "table-responsive-lg";
                case ETableResponsive.TableResponsiveExtraLarge: return "table-responsive-xl";
                case ETableResponsive.TableResponsiveAuto: return "table-responsive";
                default: return "";
            }
        }
    }
}
