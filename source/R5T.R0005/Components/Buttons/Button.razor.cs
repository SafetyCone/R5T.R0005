using System;

using Microsoft.AspNetCore.Components;

using R5T.R0005.Components;
using R5T.T0154;
using R5T.T0157;


namespace R5T.R0005.Buttons
{
    /// <summary>
    /// Put class documentation here (leaving the dummy documentation in the Razor file so that this documentation will appear for the component in client Razor files).
    /// </summary>
    [RazorComponentMarker]
    public partial class Button : IRazorComponentMarker,
        IHasColorCssSociety,
        IHasSizeCssSociety
    {
        [Parameter]
        public CssSociety ColorCssSociety { get; set; }

        [Parameter]
        public CssSociety SizeCssSociety { get; set; }

        private string CssClass =>
            TailwindCssSocieties.Instance.Button_Common
            + " " + this.SizeCssSociety
            + " " + this.ColorCssSociety
            ;
    }
}
