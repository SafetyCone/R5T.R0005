using System;


namespace R5T.R0005
{
    public class ButtonColors : IButtonColors
    {
        #region Infrastructure

        public static IButtonColors Instance { get; } = new ButtonColors();


        private ButtonColors()
        {
        }

        #endregion
    }
}
