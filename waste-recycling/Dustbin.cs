using System;
using System.Collections.Generic;
using System.Text;

namespace WasteRecycling
{
    public class Dustbin
    {
        
        public PaperGarbage[] PaperContent = new PaperGarbage[1000];
        public int paperindex = 0;

        public PlasticGarbage[] PlasticContent = new PlasticGarbage[1000];
        public int plasticindex = 0;

        public Garbage[] HouseWasteContent = new Garbage[1000];
        public int housewasteindex = 0;


        public string Color { get; set; }

        public Dustbin(string Color)
        {
            this.Color = Color;
        }

        public void DisplayContents()
        {
            Console.WriteLine("{0} Dustbin!",this.Color);
            Console.WriteLine("House waste content: {0} item(s)",housewasteindex);
            if (housewasteindex > 0)
            {
                foreach(Garbage house in HouseWasteContent)
                {
                    Console.WriteLine(house.Name);
                }
            }

            Console.WriteLine("Paper content: {0} item(s)",paperindex);
            if (paperindex>0)
            {
                foreach(PaperGarbage paper in PaperContent)
                {
                    Console.WriteLine(paper.Name);
                }
            }

            Console.WriteLine("Plastic content: {0} item(s)",plasticindex);
            if (plasticindex > 0)
            {
                foreach(PlasticGarbage plastic in PlasticContent )
                {
                    Console.WriteLine(plastic.Name);
                }
            }

        }

        public void ThrowOutGarbage(Garbage garbage)
        {

            DustbinContentException exeption = new DustbinContentException();

            if (garbage is PlasticGarbage && ((PlasticGarbage)garbage).Cleaned)
            {
                PlasticContent[plasticindex] = (PlasticGarbage)garbage;
                plasticindex++;
            }
            else if (garbage is PlasticGarbage && !((PlasticGarbage)garbage).Cleaned)
            {
                throw new DustbinContentException();
            }
            else if (garbage is PaperGarbage && ((PaperGarbage)garbage).Squeezed)
            {
                PaperContent[paperindex] = (PaperGarbage)garbage;
                paperindex++;
            }
            else if (garbage is PaperGarbage && !((PaperGarbage)garbage).Squeezed)
            {
                throw new DustbinContentException();
            }
            else if(!(garbage is PaperGarbage) && !(garbage is PlasticGarbage))
            {
                HouseWasteContent[housewasteindex] = (Garbage)garbage;
                housewasteindex++;
            }
            else
            {
                throw new DustbinContentException();
            }
        }

        public void EmptyContents()
        {
            Array.Clear(PlasticContent, 0, 1000 );
            Array.Clear(PaperContent, 0, 1000);
            Array.Clear(HouseWasteContent, 0, 1000);
        }


    }
}
