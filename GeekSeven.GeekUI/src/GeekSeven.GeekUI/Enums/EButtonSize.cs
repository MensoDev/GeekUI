namespace GeekSeven.GeekUI
{
    public enum EButtonSize
    {
        Default,
        Small,
        Large        
    }

    public static class EButtonSizeExtensions 
    {
        public static string GetButtonSize(this EButtonSize size){
            
            switch (size)
            {
                case EButtonSize.Default : return "";
                case EButtonSize.Large : return "btn-lg";
                case EButtonSize.Small : return "btn-sm";
                default: return "";
            }
        }

    }
}