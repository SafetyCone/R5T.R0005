using System;

using R5T.T0131;
using R5T.T0157;


namespace R5T.R0005
{
    [ValuesMarker]
    public partial interface ITailwindCssSocieties : IValuesMarker
    {
        public CssSociety Button_Common =>
            new("inline-flex items-center border font-medium shadow-sm focus:outline-none focus:ring-2 focus:ring-offset-2");

        public CssSociety Button_Size_XS => ButtonSizes.Instance.Button_Size_XS;
        public CssSociety Button_Size_SM => ButtonSizes.Instance.Button_Size_SM;
        public CssSociety Button_Size_Base => ButtonSizes.Instance.Button_Size_Base;
        public CssSociety Button_Size_LG => ButtonSizes.Instance.Button_Size_LG;
        public CssSociety Button_Size_XL => ButtonSizes.Instance.Button_Size_XL;

        public CssSociety Button_Color_Primary_Default => ButtonColors.Instance.Button_Color_Primary_Default;


        public CssSociety Checkbox_Disabled => new("disabled:opacity-75 disabled:text-slate-500 disabled:border-slate-200");

        public CssSociety Checkbox => new($"h-4 w-4 rounded border-gray-300 text-indigo-600 focus:ring-indigo-500 {this.Checkbox_Disabled}");
    }
}
