using System;

using Microsoft.AspNetCore.Components;

using R5T.T0157;


namespace R5T.R0005.Components
{
    public interface IHasColorCssSociety
    {
        /// <summary>
        /// The classes determining color values for the element.
        /// </summary>
        [Parameter]
        CssSociety ColorCssSociety { get; set; }
    }
}
