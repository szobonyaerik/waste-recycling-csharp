using System;
using System.Collections.Generic;
using System.Text;


namespace WasteRecycling
{
    public class PaperGarbage : Garbage
    {
        
        

        public bool Squeezed { get; set; }

        public PaperGarbage(string Name, bool squeezed) : base(Name)
        {
            
            this.Squeezed = squeezed;
        }

        public void Squeeze()
        {
            if (this.Squeezed == false)
            {
                this.Squeezed = true;
            }
        }
                
           
        
    }
}
