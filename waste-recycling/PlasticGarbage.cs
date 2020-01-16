using System;
using System.Collections.Generic;
using System.Text;


namespace WasteRecycling
{
    public class PlasticGarbage : Garbage
    {
        
        

        public bool Cleaned { get; set; }

        public PlasticGarbage(string Name, bool Cleaned) : base(Name)
        {
            this.Cleaned = Cleaned;
            
        }

        public void Clean()
        {
            if (this.Cleaned == false)
            {
                this.Cleaned = true;
            }
        }

    }
}
