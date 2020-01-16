using System;
using System.Collections.Generic;
using System.Text;


namespace WasteRecycling
{
    public class PaperGarbage : Garbage
    {
        
        public bool _Squeezed;

        public bool Squeezed { get; set; }

        public PaperGarbage(string Name, bool squeezed) : base(Name)
        {
            
            this._Squeezed = squeezed;
        }

        public void Squeeze()
        {
            if (this._Squeezed == false)
            {
                this._Squeezed = true;
            }
        }
                
           
        
    }
}
