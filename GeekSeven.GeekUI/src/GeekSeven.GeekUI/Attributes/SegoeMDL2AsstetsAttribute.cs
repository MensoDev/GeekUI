using System;

namespace GeekSeven.GeekUI.Attributes
{


    [AttributeUsage(AttributeTargets.All)]
    public class SegoeMDL2AsstetsAttribute : Attribute
    {

        public string Icon { get; private set; }

        public SegoeMDL2AsstetsAttribute(string textIcon)
        {
            try
            {
                int intIcon = Convert.ToInt32(textIcon);
                Icon = char.ConvertFromUtf32(intIcon);
            }
            catch (Exception ex)
            {
                Icon = ex.Message;
            }
        }

        public SegoeMDL2AsstetsAttribute(int intIcon)
        {
            try
            {
                Icon = char.ConvertFromUtf32(intIcon);
            }
            catch (Exception ex)
            {
                Icon = ex.Message;
            }
        }

        public SegoeMDL2AsstetsAttribute(ESegoeMDL2Assets assets)
        {
            try
            {
                int intIcon = Convert.ToInt32(assets);
                Icon = char.ConvertFromUtf32(intIcon);
            }
            catch (Exception ex)
            {
                Icon = ex.Message;
            }
        }

    }
}
