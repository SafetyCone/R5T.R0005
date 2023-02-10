using System;


namespace R5T.R0005
{
    public class TailwindCssSocieties : ITailwindCssSocieties
    {
        #region Infrastructure

        public static ITailwindCssSocieties Instance { get; } = new TailwindCssSocieties();


        private TailwindCssSocieties()
        {
        }

        #endregion
    }
}
