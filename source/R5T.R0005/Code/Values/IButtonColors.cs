using System;

using R5T.T0131;
using R5T.T0157;


namespace R5T.R0005
{
    [ValuesMarker]
    public partial interface IButtonColors : IValuesMarker
    {
        public CssSociety Disabled_Default => new("disabled:opacity-75 disabled:bg-slate-50 disabled:text-slate-500 disabled:border-slate-200");

        public CssSociety Button_Color_Primary_Default => new($"border-transparent text-white bg-indigo-600 enabled:hover:bg-indigo-700 focus:ring-indigo-500 {this.Disabled_Default}");
        public CssSociety Button_Color_Secondary_Default => new($"border-transparent text-indigo-700 bg-indigo-100 enabled:hover:bg-indigo-200 focus:ring-indigo-500 {this.Disabled_Default}");
        public CssSociety Button_Color_White_Default => new($"border-gray-300 text-gray-700 bg-white enabled:hover:bg-gray-50 focus:ring-indigo-500 {this.Disabled_Default}");
    }
}
