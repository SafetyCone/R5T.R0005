using System;


namespace R5T.R0005
{
    public class ButtonSizes : IButtonSizes
    {
        #region Infrastructure

        public static IButtonSizes Instance { get; } = new ButtonSizes();


        private ButtonSizes()
        {
        }

        #endregion
    }
}
