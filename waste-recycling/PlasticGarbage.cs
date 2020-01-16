using System;
using System.Collections.Generic;
using System.Text;


namespace WasteRecycling
{
    public class PlasticGarbage : Garbage
    {
        public string _Name;
        public bool _Cleaned;

        public bool Cleaned { get; set; }

        public PlasticGarbage(string Name, bool Cleaned) : base(Name)
        {
            this._Cleaned = Cleaned;
        }

        public void Clean()
        {
            if (this._Cleaned == false)
            {
                this._Cleaned = true;
            }
        }

    }
}
