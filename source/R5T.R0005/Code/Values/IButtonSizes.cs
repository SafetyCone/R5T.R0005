using System;

using R5T.T0131;
using R5T.T0157;


namespace R5T.R0005
{
    [ValuesMarker]
    public partial interface IButtonSizes : IValuesMarker
    {
        public CssSociety Button_Size_XS => new("rounded px-2.5 py-1.5 text-xs");
        public CssSociety Button_Size_SM => new("rounded-md px-3 py-2 text-sm leading-4");
        public CssSociety Button_Size_Base => new("rounded-md px-4 py-2 text-sm");
        public CssSociety Button_Size_LG => new("rounded-md px-4 py-2 text-base");
        public CssSociety Button_Size_XL => new("rounded-md px-6 py-3 text-base");
    }
}
