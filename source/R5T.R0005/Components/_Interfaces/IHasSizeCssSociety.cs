using System;

using Microsoft.AspNetCore.Components;

using R5T.T0157;


namespace R5T.R0005.Components
{
    public interface IHasSizeCssSociety
    {
        /// <summary>
        /// The classes determining sizes values for the element.
        /// </summary>
        [Parameter]
        CssSociety SizeCssSociety { get; set; }
    }
}
