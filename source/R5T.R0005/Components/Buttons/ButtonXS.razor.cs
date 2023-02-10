using System;

using Microsoft.AspNetCore.Components;

using R5T.R0005.Components;
using R5T.T0154;
using R5T.T0157;


namespace R5T.R0005.Buttons
{
    /// <summary>
    /// An extra-small button.
    /// </summary>
    [RazorComponentMarker]
    public partial class ButtonXS : IRazorComponentMarker,
        IHasColorCssSociety
    {
        [Parameter]
        public CssSociety ColorCssSociety { get; set; } = ButtonColors.Instance.Button_Color_Primary_Default;
    }
}
