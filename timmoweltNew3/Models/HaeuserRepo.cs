using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace timmoweltNew3.Models
{
    public class HaeuserRepo
    {
        private List<Haeuser> _localList = new List<Haeuser>()
        {
            //Darmstadt 300 euro
            new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="darmstadt", Mietpreis="   bis 300 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung1.jpg"  },
             new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="darmstadt", Mietpreis="   bis 300 €", Wohnflaeche="   ab 60 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung2.jpg"  },
              new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="darmstadt", Mietpreis="   bis 300 €", Wohnflaeche="   ab 80 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung3.jpg"  },
               new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="darmstadt", Mietpreis="   bis 300 €", Wohnflaeche="   ab 100 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung1.jpg"  },
                new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="darmstadt", Mietpreis="   bis 300 €", Wohnflaeche="   ab 120 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung2.jpg"  },
                 new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="darmstadt", Mietpreis="   bis 300 €", Wohnflaeche="   ab 140 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung3.jpg"  },


            new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="darmstadt", Mietpreis="   bis 300 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung1.jpg"  },
             new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="darmstadt", Mietpreis="   bis 300 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 4 Zimmer", Bilder="/Images/wohnung2.jpg"  },
              new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="darmstadt", Mietpreis="   bis 300 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 5 Zimmer", Bilder="/Images/wohnung3.jpg"  },
               new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="darmstadt", Mietpreis="   bis 300 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 6 Zimmer", Bilder="/Images/wohnung1.jpg"  },
                new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="darmstadt", Mietpreis="   bis 300 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 7 Zimmer", Bilder="/Images/wohnung2.jpg"  },
                 new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="darmstadt", Mietpreis="   bis 300 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 8 Zimmer", Bilder="/Images/wohnung3.jpg"  },


            new Haeuser(){ Wohnungmieten="Haus mieten", Ort="darmstadt", Mietpreis="   bis 300 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung1.jpg"  },
             new Haeuser(){ Wohnungmieten="Haus mieten", Ort="darmstadt", Mietpreis="   bis 300 €", Wohnflaeche="   ab 60 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung2.jpg"  },
              new Haeuser(){ Wohnungmieten="Haus mieten", Ort="darmstadt", Mietpreis="   bis 300 €", Wohnflaeche="   ab 80 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung3.jpg"  },
               new Haeuser(){ Wohnungmieten="Haus mieten", Ort="darmstadt", Mietpreis="   bis 300 €", Wohnflaeche="   ab 100 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung1.jpg"  },
                new Haeuser(){ Wohnungmieten="Haus mieten", Ort="darmstadt", Mietpreis="   bis 300 €", Wohnflaeche="   ab 120 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung2.jpg"  },
                 new Haeuser(){ Wohnungmieten="Haus mieten", Ort="darmstadt", Mietpreis="   bis 300 €", Wohnflaeche="   ab 140 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung3.jpg"  },

            new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="darmstadt", Mietpreis="   bis 300 €", Wohnflaeche="   ab 60 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung1.jpg"  },
             new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="darmstadt", Mietpreis="   bis 300 €", Wohnflaeche="   ab 60 qm²", Zimmer="   ab 4 Zimmer", Bilder="/Images/wohnung2.jpg"  },
              new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="darmstadt", Mietpreis="   bis 300 €", Wohnflaeche="   ab 60 qm²", Zimmer="   ab 5 Zimmer", Bilder="/Images/wohnung3.jpg"  },
               new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="darmstadt", Mietpreis="   bis 300 €", Wohnflaeche="   ab 60 qm²", Zimmer="   ab 6 Zimmer", Bilder="/Images/wohnung1.jpg"  },
                new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="darmstadt", Mietpreis="   bis 300 €", Wohnflaeche="   ab 60 qm²", Zimmer="   ab 7 Zimmer", Bilder="/Images/wohnung2.jpg"  },
                 new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="darmstadt", Mietpreis="   bis 300 €", Wohnflaeche="   ab 60 qm²", Zimmer="   ab 8 Zimmer", Bilder="/Images/wohnung3.jpg"  },


            new Haeuser(){ Wohnungmieten="Haus mieten", Ort="darmstadt", Mietpreis="   bis 300 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 4 Zimmer", Bilder="/Images/wohnung1.jpg"  },
             new Haeuser(){ Wohnungmieten="Haus mieten", Ort="darmstadt", Mietpreis="   bis 300 €", Wohnflaeche="   ab 60 qm²", Zimmer="   ab 4 Zimmer", Bilder="/Images/wohnung2.jpg"  },
              new Haeuser(){ Wohnungmieten="Haus mieten", Ort="darmstadt", Mietpreis="   bis 300 €", Wohnflaeche="   ab 80 qm²", Zimmer="   ab 4 Zimmer", Bilder="/Images/wohnung3.jpg"  },
               new Haeuser(){ Wohnungmieten="Haus mieten", Ort="darmstadt", Mietpreis="   bis 300 €", Wohnflaeche="   ab 100 qm²", Zimmer="   ab 4 Zimmer", Bilder="/Images/wohnung1.jpg"  },
                new Haeuser(){ Wohnungmieten="Haus mieten", Ort="darmstadt", Mietpreis="   bis 300 €", Wohnflaeche="   ab 120 qm²", Zimmer="   ab 4 Zimmer", Bilder="/Images/wohnung2.jpg"  },
                 new Haeuser(){ Wohnungmieten="Haus mieten", Ort="darmstadt", Mietpreis="   bis 300 €", Wohnflaeche="   ab 140 qm²", Zimmer="   ab 4 Zimmer", Bilder="/Images/wohnung3.jpg"  },


            new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="darmstadt", Mietpreis="   bis 300 €", Wohnflaeche="   ab 80 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung1.jpg"  },
             new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="darmstadt", Mietpreis="   bis 300 €", Wohnflaeche="   ab 80 qm²", Zimmer="   ab 4 Zimmer", Bilder="/Images/wohnung2.jpg"  },
              new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="darmstadt", Mietpreis="   bis 300 €", Wohnflaeche="   ab 80 qm²", Zimmer="   ab 5 Zimmer", Bilder="/Images/wohnung3.jpg"  },
               new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="darmstadt", Mietpreis="   bis 300 €", Wohnflaeche="   ab 80 qm²", Zimmer="   ab 6 Zimmer", Bilder="/Images/wohnung1.jpg"  },
                new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="darmstadt", Mietpreis="   bis 300 €", Wohnflaeche="   ab 80 qm²", Zimmer="   ab 7 Zimmer", Bilder="/Images/wohnung2.jpg"  },
                 new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="darmstadt", Mietpreis="   bis 300 €", Wohnflaeche="   ab 80 qm²", Zimmer="   ab 8 Zimmer", Bilder="/Images/wohnung3.jpg"  },


            new Haeuser(){ Wohnungmieten="Haus mieten", Ort="darmstadt", Mietpreis="   bis 300 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 5 Zimmer", Bilder="/Images/wohnung1.jpg"  },
             new Haeuser(){ Wohnungmieten="Haus mieten", Ort="darmstadt", Mietpreis="   bis 300 €", Wohnflaeche="   ab 60 qm²", Zimmer="   ab 5 Zimmer", Bilder="/Images/wohnung2.jpg"  },
              new Haeuser(){ Wohnungmieten="Haus mieten", Ort="darmstadt", Mietpreis="   bis 300 €", Wohnflaeche="   ab 80 qm²", Zimmer="   ab 5 Zimmer", Bilder="/Images/wohnung3.jpg"  },
               new Haeuser(){ Wohnungmieten="Haus mieten", Ort="darmstadt", Mietpreis="   bis 300 €", Wohnflaeche="   ab 100 qm²", Zimmer="   ab 5 Zimmer", Bilder="/Images/wohnung1.jpg"  },
                new Haeuser(){ Wohnungmieten="Haus mieten", Ort="darmstadt", Mietpreis="   bis 300 €", Wohnflaeche="   ab 120 qm²", Zimmer="   ab 5 Zimmer", Bilder="/Images/wohnung2.jpg"  },
                 new Haeuser(){ Wohnungmieten="Haus mieten", Ort="darmstadt", Mietpreis="   bis 300 €", Wohnflaeche="   ab 140 qm²", Zimmer="   ab 5 Zimmer", Bilder="/Images/wohnung3.jpg"  },



            new Haeuser(){ Wohnungmieten="Haus mieten", Ort="darmstadt", Mietpreis="   bis 300 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung1.jpg"  },
             new Haeuser(){ Wohnungmieten="Haus mieten", Ort="darmstadt", Mietpreis="   bis 300 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 4 Zimmer", Bilder="/Images/wohnung1.jpg"  },
              new Haeuser(){ Wohnungmieten="Haus mieten", Ort="darmstadt", Mietpreis="   bis 300 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 5 Zimmer", Bilder="/Images/wohnung1.jpg"  },
               new Haeuser(){ Wohnungmieten="Haus mieten", Ort="darmstadt", Mietpreis="   bis 300 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 6 Zimmer", Bilder="/Images/wohnung1.jpg"  },
                new Haeuser(){ Wohnungmieten="Haus mieten", Ort="darmstadt", Mietpreis="   bis 300 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 7 Zimmer", Bilder="/Images/wohnung1.jpg"  },
                 new Haeuser(){ Wohnungmieten="Haus mieten", Ort="darmstadt", Mietpreis="   bis 300 €", Wohnflaeche=   "ab 40 qm²", Zimmer="   ab 8 Zimmer", Bilder="/Images/wohnung1.jpg"  },


                    //Darmstadt 400 euro
            new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="darmstadt", Mietpreis="   bis 400 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung1.jpg"  },
             new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="darmstadt", Mietpreis="   bis 400 €", Wohnflaeche="   ab 60 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung1.jpg"  },
              new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="darmstadt", Mietpreis="   bis 400 €", Wohnflaeche="   ab 80 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung1.jpg"  },
               new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="darmstadt", Mietpreis="   bis 400 €", Wohnflaeche="   ab 100 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung1.jpg"  },
                new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="darmstadt", Mietpreis="   bis 400 €", Wohnflaeche="   ab 120 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung1.jpg"  },
                 new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="darmstadt", Mietpreis="   bis 400 €", Wohnflaeche="   ab 140 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung1.jpg"  },


            new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="darmstadt", Mietpreis="   bis 400 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung1.jpg"  },
             new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="darmstadt", Mietpreis="   bis 400 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 4 Zimmer", Bilder="/Images/wohnung1.jpg"  },
              new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="darmstadt", Mietpreis="   bis 400 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 5 Zimmer", Bilder="/Images/wohnung1.jpg"  },
               new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="darmstadt", Mietpreis="   bis 400 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 6 Zimmer", Bilder="/Images/wohnung1.jpg"  },
                new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="darmstadt", Mietpreis="   bis 400 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 7 Zimmer", Bilder="/Images/wohnung1.jpg"  },
                 new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="darmstadt", Mietpreis="   bis 400 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 8 Zimmer", Bilder="/Images/wohnung1.jpg"  },


            new Haeuser(){ Wohnungmieten="Haus mieten", Ort="darmstadt", Mietpreis="   bis 400 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung1.jpg"  },
             new Haeuser(){ Wohnungmieten="Haus mieten", Ort="darmstadt", Mietpreis="   bis 400 €", Wohnflaeche="   ab 60 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung1.jpg"  },
              new Haeuser(){ Wohnungmieten="Haus mieten", Ort="darmstadt", Mietpreis="   bis 400 €", Wohnflaeche="   ab 80 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung1.jpg"  },
               new Haeuser(){ Wohnungmieten="Haus mieten", Ort="darmstadt", Mietpreis="   bis 400 €", Wohnflaeche="   ab 100 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung1.jpg"  },
                new Haeuser(){ Wohnungmieten="Haus mieten", Ort="darmstadt", Mietpreis="   bis 400 €", Wohnflaeche="   ab 120 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung1.jpg"  },
                 new Haeuser(){ Wohnungmieten="Haus mieten", Ort="darmstadt", Mietpreis="   bis 400 €", Wohnflaeche="   ab 140 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung1.jpg"  },


            new Haeuser(){ Wohnungmieten="Haus mieten", Ort="darmstadt", Mietpreis="   bis 400 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung1.jpg"  },
             new Haeuser(){ Wohnungmieten="Haus mieten", Ort="darmstadt", Mietpreis="   bis 400 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 4 Zimmer", Bilder="/Images/wohnung1.jpg"  },
              new Haeuser(){ Wohnungmieten="Haus mieten", Ort="darmstadt", Mietpreis="   bis 400 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 5 Zimmer", Bilder="/Images/wohnung1.jpg"  },
               new Haeuser(){ Wohnungmieten="Haus mieten", Ort="darmstadt", Mietpreis="   bis 400 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 6 Zimmer", Bilder="/Images/wohnung1.jpg"  },
                new Haeuser(){ Wohnungmieten="Haus mieten", Ort="darmstadt", Mietpreis="   bis 400 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 7 Zimmer", Bilder="/Images/wohnung1.jpg"  },
                 new Haeuser(){ Wohnungmieten="Haus mieten", Ort="darmstadt", Mietpreis="   bis 400 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 8 Zimmer", Bilder="/Images/wohnung1.jpg"  },


            //Darmstadt 500 euro
            new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="darmstadt", Mietpreis="   bis 500 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung1.jpg"  },
             new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="darmstadt", Mietpreis="   bis 500 €", Wohnflaeche="   ab 60 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung1.jpg"  },
              new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="darmstadt", Mietpreis="   bis 500 €", Wohnflaeche="   ab 80 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung1.jpg"  },
               new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="darmstadt", Mietpreis="   bis 500 €", Wohnflaeche="   ab 100 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung1.jpg"  },
                new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="darmstadt", Mietpreis="   bis 500 €", Wohnflaeche="   ab 120 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung1.jpg"  },
                 new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="darmstadt", Mietpreis="   bis 500 €", Wohnflaeche="   ab 140 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung1.jpg"  },


            new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="darmstadt", Mietpreis="   bis 500 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung1.jpg"  },
             new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="darmstadt", Mietpreis="   bis 500 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 4 Zimmer", Bilder="/Images/wohnung1.jpg"  },
              new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="darmstadt", Mietpreis="   bis 500 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 5 Zimmer", Bilder="/Images/wohnung1.jpg"  },
               new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="darmstadt", Mietpreis="   bis 500 €", Wohnflaeche="   ab 40 qm²", Zimmer="  ab 6 Zimmer", Bilder="/Images/wohnung1.jpg"  },
                new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="darmstadt", Mietpreis="   bis 500 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 7 Zimmer", Bilder="/Images/wohnung1.jpg"  },
                 new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="darmstadt", Mietpreis="   bis 500 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 8 Zimmer", Bilder="/Images/immo2.png"  },

            new Haeuser(){ Wohnungmieten="Haus mieten", Ort="darmstadt", Mietpreis="   bis 500 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung1.jpg"  },
             new Haeuser(){ Wohnungmieten="Haus mieten", Ort="darmstadt", Mietpreis="   bis 500 €", Wohnflaeche="   ab 60 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung1.jpg"  },
              new Haeuser(){ Wohnungmieten="Haus mieten", Ort="darmstadt", Mietpreis="   bis 500 €", Wohnflaeche="   ab 80 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung1.jpg"  },
               new Haeuser(){ Wohnungmieten="Haus mieten", Ort="darmstadt", Mietpreis="   bis 500 €", Wohnflaeche="   ab 100 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung1.jpg"  },
                new Haeuser(){ Wohnungmieten="Haus mieten", Ort="darmstadt", Mietpreis="   bis 500 €", Wohnflaeche="   ab 120 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung1.jpg"  },
                 new Haeuser(){ Wohnungmieten="Haus mieten", Ort="darmstadt", Mietpreis="   bis 500 €", Wohnflaeche="   ab 140 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung1.jpg"  },


            new Haeuser(){ Wohnungmieten="Haus mieten", Ort="darmstadt", Mietpreis="   bis 500 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung1.jpg"  },
             new Haeuser(){ Wohnungmieten="Haus mieten", Ort="darmstadt", Mietpreis="   bis 500 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 4 Zimmer", Bilder="/Images/wohnung1.jpg"  },
              new Haeuser(){ Wohnungmieten="Haus mieten", Ort="darmstadt", Mietpreis="   bis 500 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 5 Zimmer", Bilder="/Images/wohnung1.jpg"  },
               new Haeuser(){ Wohnungmieten="Haus mieten", Ort="darmstadt", Mietpreis="   bis 500 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 6 Zimmer", Bilder="/Images/wohnung1.jpg"  },
                new Haeuser(){ Wohnungmieten="Haus mieten", Ort="darmstadt", Mietpreis="   bis 500 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 7 Zimmer", Bilder="/Images/wohnung1.jpg"  },
                 new Haeuser(){ Wohnungmieten="Haus mieten", Ort="darmstadt", Mietpreis="   bis 500 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 8 Zimmer", Bilder="/Images/wohnung1.jpg"  },


                            //Darmstadt 600 euro
            new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="darmstadt", Mietpreis="   bis 600 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung1.jpg"  },
             new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="darmstadt", Mietpreis="   bis 600 €", Wohnflaeche="   ab 60 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung1.jpg"  },
              new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="darmstadt", Mietpreis="   bis 600 €", Wohnflaeche="   ab 80 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung1.jpg"  },
               new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="darmstadt", Mietpreis="   bis 600 €", Wohnflaeche="   ab 100 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung1.jpg"  },
                new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="darmstadt", Mietpreis="   bis 600 €", Wohnflaeche="   ab 120 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung1.jpg"  },
                 new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="darmstadt", Mietpreis="   bis 600 €", Wohnflaeche="   ab 140 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung1.jpg"  },


            new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="darmstadt", Mietpreis="   bis 600 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung1.jpg"  },
             new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="darmstadt", Mietpreis="   bis 600 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 4 Zimmer", Bilder="/Images/wohnung1.jpg"  },
              new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="darmstadt", Mietpreis="   bis 600 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 5 Zimmer", Bilder="/Images/wohnung1.jpg"  },
               new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="darmstadt", Mietpreis="   bis 600 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 6 Zimmer", Bilder="/Images/wohnung1.jpg"  },
                new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="darmstadt", Mietpreis="   bis 600 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 7 Zimmer", Bilder="/Images/wohnung1.jpg"  },
                 new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="darmstadt", Mietpreis="   bis 600 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 8 Zimmer", Bilder="/Images/wohnung1.jpg"  },


            new Haeuser(){ Wohnungmieten="Haus mieten", Ort="darmstadt", Mietpreis="   bis 600 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung1.jpg"  },
             new Haeuser(){ Wohnungmieten="Haus mieten", Ort="darmstadt", Mietpreis="   bis 600 €", Wohnflaeche="   ab 60 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung1.jpg"  },
              new Haeuser(){ Wohnungmieten="Haus mieten", Ort="darmstadt", Mietpreis="   bis 600 €", Wohnflaeche="   ab 80 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung1.jpg"  },
               new Haeuser(){ Wohnungmieten="Haus mieten", Ort="darmstadt", Mietpreis="   bis 600 €", Wohnflaeche="   ab 100 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung1.jpg"  },
                new Haeuser(){ Wohnungmieten="Haus mieten", Ort="darmstadt", Mietpreis="   bis 600 €", Wohnflaeche="   ab 120 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung1.jpg"  },
                 new Haeuser(){ Wohnungmieten="Haus mieten", Ort="darmstadt", Mietpreis="   bis 600 €", Wohnflaeche="   ab 140 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung1.jpg"  },


            new Haeuser(){ Wohnungmieten="Haus mieten", Ort="darmstadt", Mietpreis="   bis 600 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung1.jpg"  },
             new Haeuser(){ Wohnungmieten="Haus mieten", Ort="darmstadt", Mietpreis="   bis 600 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 4 Zimmer", Bilder="/Images/wohnung1.jpg"  },
              new Haeuser(){ Wohnungmieten="Haus mieten", Ort="darmstadt", Mietpreis="   bis 600 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 5 Zimmer", Bilder="/Images/wohnung1.jpg"  },
               new Haeuser(){ Wohnungmieten="Haus mieten", Ort="darmstadt", Mietpreis="   bis 600 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 6 Zimmer", Bilder="/Images/wohnung1.jpg"  },
                new Haeuser(){ Wohnungmieten="Haus mieten", Ort="darmstadt", Mietpreis="   bis 600 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 7 Zimmer", Bilder="/Images/wohnung1.jpg"  },
                 new Haeuser(){ Wohnungmieten="Haus mieten", Ort="darmstadt", Mietpreis="   bis 600 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 8 Zimmer", Bilder="/Images/wohnung1.jpg"  },


            //Darmstadt 700 euro
            new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="darmstadt", Mietpreis="   bis 700 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung1.jpg"  },
             new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="darmstadt", Mietpreis="   bis 700 €", Wohnflaeche="   ab 60 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung1.jpg"  },
              new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="darmstadt", Mietpreis="   bis 700 €", Wohnflaeche="   ab 80 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung1.jpg"  },
               new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="darmstadt", Mietpreis="   bis 700 €", Wohnflaeche="   ab 100 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung1.jpg"  },
                new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="darmstadt", Mietpreis="   bis 700 €", Wohnflaeche="   ab 120 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung1.jpg"  },
                 new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="darmstadt", Mietpreis="   bis 700 €", Wohnflaeche="   ab 140 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung1.jpgg"  },


            new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="darmstadt", Mietpreis="   bis 700 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung1.jpg"  },
             new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="darmstadt", Mietpreis="   bis 700 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 4 Zimmer", Bilder="/Images/wohnung1.jpg"  },
              new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="darmstadt", Mietpreis="   bis 700 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 5 Zimmer", Bilder="/Images/wohnung1.jpg"  },
               new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="darmstadt", Mietpreis="   bis 700 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 6 Zimmer", Bilder="/Images/wohnung1.jpg"  },
                new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="darmstadt", Mietpreis="   bis 700 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 7 Zimmer", Bilder="/Images/wohnung1.jpg"  },
                 new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="darmstadt", Mietpreis="   bis 700 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 8 Zimmer", Bilder="/Images/wohnung1.jpg"  },


            new Haeuser(){ Wohnungmieten="Haus mieten", Ort="darmstadt", Mietpreis="   bis 700 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung1.jpg"  },
             new Haeuser(){ Wohnungmieten="Haus mieten", Ort="darmstadt", Mietpreis="   bis 700 €", Wohnflaeche="   ab 60 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/iwohnung1.jpg"  },
              new Haeuser(){ Wohnungmieten="Haus mieten", Ort="darmstadt", Mietpreis="   bis 700 €", Wohnflaeche="   ab 80 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung1.jpg"  },
               new Haeuser(){ Wohnungmieten="Haus mieten", Ort="darmstadt", Mietpreis="   bis 700 €", Wohnflaeche="   ab 100 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung1.jpg"  },
                new Haeuser(){ Wohnungmieten="Haus mieten", Ort="darmstadt", Mietpreis="   bis 700 €", Wohnflaeche="   ab 120 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung1.jpg"  },
                 new Haeuser(){ Wohnungmieten="Haus mieten", Ort="darmstadt", Mietpreis="   bis 700 €", Wohnflaeche="   ab 140 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung1.jpg"  },


            new Haeuser(){ Wohnungmieten="Haus mieten", Ort="darmstadt", Mietpreis="   bis 700 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung1.jpg"  },
             new Haeuser(){ Wohnungmieten="Haus mieten", Ort="darmstadt", Mietpreis="   bis 700 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 4 Zimmer", Bilder="/Images/wohnung1.jpg"  },
              new Haeuser(){ Wohnungmieten="Haus mieten", Ort="darmstadt", Mietpreis="   bis 700 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 5 Zimmer", Bilder="/Images/wohnung1.jpg"  },
               new Haeuser(){ Wohnungmieten="Haus mieten", Ort="darmstadt", Mietpreis="   bis 700 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 6 Zimmer", Bilder="/Images/wohnung1.jpg"  },
                new Haeuser(){ Wohnungmieten="Haus mieten", Ort="darmstadt", Mietpreis="   bis 700 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 7 Zimmer", Bilder="/Images/wohnung1.jpg"  },
                 new Haeuser(){ Wohnungmieten="Haus mieten", Ort="darmstadt", Mietpreis="   bis 700 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 8 Zimmer", Bilder="/Images/wohnung1.jpg"  },


            //Darmstadt 800 euro
            new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="darmstadt", Mietpreis="   bis 800 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung1.jpg"  },
             new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="darmstadt", Mietpreis="   bis 800 €", Wohnflaeche="   ab 60 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung1.jpg"  },
              new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="darmstadt", Mietpreis="   bis 800 €", Wohnflaeche="   ab 80 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung1.jpg"  },
               new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="darmstadt", Mietpreis="   bis 800 €", Wohnflaeche="   ab 100 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung1.jpg"  },
                new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="darmstadt", Mietpreis="   bis 800 €", Wohnflaeche="   ab 120 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung1.jpg"  },
                 new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="darmstadt", Mietpreis="   bis 800 €", Wohnflaeche="   ab 140 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung1.jpg"  },


            new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="darmstadt", Mietpreis="   bis 800 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung1.jpg"  },
             new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="darmstadt", Mietpreis="   bis 800 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 4 Zimmer", Bilder="/Images/wohnung1.jpg"  },
              new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="darmstadt", Mietpreis="   bis 800 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 5 Zimmer", Bilder="/Images/wohnung1.jpg"  },
               new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="darmstadt", Mietpreis="   bis 800 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 6 Zimmer", Bilder="/Images/wohnung1.jpg"  },
                new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="darmstadt", Mietpreis="   bis 800 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 7 Zimmer", Bilder="/Images/wohnung1.jpg"  },
                 new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="darmstadt", Mietpreis="   bis 800 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 8 Zimmer", Bilder="/Images/wohnung1.jpg"  },


            new Haeuser(){ Wohnungmieten="Haus mieten", Ort="darmstadt", Mietpreis="   bis 800 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung1.jpg"  },
             new Haeuser(){ Wohnungmieten="Haus mieten", Ort="darmstadt", Mietpreis="   bis 800 €", Wohnflaeche="   ab 60 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung1.jpg"  },
              new Haeuser(){ Wohnungmieten="Haus mieten", Ort="darmstadt", Mietpreis="   bis 800 €", Wohnflaeche="   ab 80 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung1.jpg"  },
               new Haeuser(){ Wohnungmieten="Haus mieten", Ort="darmstadt", Mietpreis="   bis 800 €", Wohnflaeche="   ab 100 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung1.jpg"  },
                new Haeuser(){ Wohnungmieten="Haus mieten", Ort="darmstadt", Mietpreis="   bis 800 €", Wohnflaeche="   ab 120 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung1.jpg"  },
                 new Haeuser(){ Wohnungmieten="Haus mieten", Ort="darmstadt", Mietpreis="   bis 800 €", Wohnflaeche="   ab 140 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung1.jpg"  },


            new Haeuser(){ Wohnungmieten="Haus mieten", Ort="darmstadt", Mietpreis="   bis 800 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung1.jpg"  },
             new Haeuser(){ Wohnungmieten="Haus mieten", Ort="darmstadt", Mietpreis="   bis 800 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 4 Zimmer", Bilder="/Images/wohnung1.jpg"  },
              new Haeuser(){ Wohnungmieten="Haus mieten", Ort="darmstadt", Mietpreis="   bis 800 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 5 Zimmer", Bilder="/Images/wohnung1.jpg"  },
               new Haeuser(){ Wohnungmieten="Haus mieten", Ort="darmstadt", Mietpreis="   bis 800 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 6 Zimmer", Bilder="/Images/wohnung1.jpg"  },
                new Haeuser(){ Wohnungmieten="Haus mieten", Ort="darmstadt", Mietpreis="   bis 800 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 7 Zimmer", Bilder="/Images/wohnung1.jpg"  },
                 new Haeuser(){ Wohnungmieten="Haus mieten", Ort="darmstadt", Mietpreis="   bis 800 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 8 Zimmer", Bilder="/Images/iwohnung1.jpg"  },





                 //Frankfurt 300 euro
            new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="frankfurt", Mietpreis="   bis 300 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung1.jpg"  },
             new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="frankfurt", Mietpreis="   bis 300 €", Wohnflaeche="   ab 60 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung2.jpg"  },
              new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="frankfurt", Mietpreis="   bis 300 €", Wohnflaeche="   ab 80 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung3.jpg"  },
               new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="frankfurt", Mietpreis="   bis 300 €", Wohnflaeche="   ab 100 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung1.jpg"  },
                new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="frankfurt", Mietpreis="   bis 300 €", Wohnflaeche="   ab 120 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung2.jpg"  },
                 new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="darmstadt", Mietpreis="   bis 300 €", Wohnflaeche="   ab 140 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung3.jpg"  },


            new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="frankfurt", Mietpreis="   bis 300 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung1.jpg"  },
             new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="frankfurt", Mietpreis="   bis 300 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 4 Zimmer", Bilder="/Images/wohnung2.jpg"  },
              new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="frankfurt", Mietpreis="   bis 300 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 5 Zimmer", Bilder="/Images/wohnung3.jpg"  },
               new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="frankfurt", Mietpreis="   bis 300 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 6 Zimmer", Bilder="/Images/wohnung1.jpg"  },
                new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="frankfurt", Mietpreis="   bis 300 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 7 Zimmer", Bilder="/Images/wohnung2.jpg"  },
                 new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="frankfurt", Mietpreis="   bis 300 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 8 Zimmer", Bilder="/Images/wohnung3.jpg"  },


            new Haeuser(){ Wohnungmieten="Haus mieten", Ort="frankfurt", Mietpreis="   bis 300 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung1.jpg"  },
             new Haeuser(){ Wohnungmieten="Haus mieten", Ort="frankfurt", Mietpreis="   bis 300 €", Wohnflaeche="   ab 60 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung2.jpg"  },
              new Haeuser(){ Wohnungmieten="Haus mieten", Ort="frankfurt", Mietpreis="   bis 300 €", Wohnflaeche="   ab 80 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung3.jpg"  },
               new Haeuser(){ Wohnungmieten="Haus mieten", Ort="frankfurt", Mietpreis="   bis 300 €", Wohnflaeche="   ab 100 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung1.jpg"  },
                new Haeuser(){ Wohnungmieten="Haus mieten", Ort="frankfurt", Mietpreis="   bis 300 €", Wohnflaeche="   ab 120 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung2.jpg"  },
                 new Haeuser(){ Wohnungmieten="Haus mieten", Ort="frankfurt", Mietpreis="   bis 300 €", Wohnflaeche="   ab 140 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung3.jpg"  },


            new Haeuser(){ Wohnungmieten="Haus mieten", Ort="frankfurt", Mietpreis="   bis 300 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung1.jpg"  },
             new Haeuser(){ Wohnungmieten="Haus mieten", Ort="frankfurt", Mietpreis="   bis 300 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 4 Zimmer", Bilder="/Images/wohnung1.jpg"  },
              new Haeuser(){ Wohnungmieten="Haus mieten", Ort="frankfurt", Mietpreis="   bis 300 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 5 Zimmer", Bilder="/Images/wohnung2.jpg"  },
               new Haeuser(){ Wohnungmieten="Haus mieten", Ort="frankfurt", Mietpreis="   bis 300 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 6 Zimmer", Bilder="/Images/wohnung3.jpg"  },
                new Haeuser(){ Wohnungmieten="Haus mieten", Ort="frankfurt", Mietpreis="   bis 300 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 7 Zimmer", Bilder="/Images/wohnung3.jpg"  },
                 new Haeuser(){ Wohnungmieten="Haus mieten", Ort="frankfurt", Mietpreis="   bis 300 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 8 Zimmer", Bilder="/Images/wohnung2.jpg"  },


                    //Frankfurt 400 euro
            new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="frankfurt", Mietpreis="   bis 400 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung2.jpg"  },
             new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="frankfurt", Mietpreis="   bis 400 €", Wohnflaeche="   ab 60 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung2.jpg"  },
              new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="frankfurt", Mietpreis="   bis 400 €", Wohnflaeche="   ab 80 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung1.jpg"  },
               new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="frankfurt", Mietpreis="   bis 400 €", Wohnflaeche="   ab 100 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung3.jpg"  },
                new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="frankfurt", Mietpreis="   bis 400 €", Wohnflaeche="   ab 120 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung2.jpg"  },
                 new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="frankfurt", Mietpreis="   bis 400 €", Wohnflaeche="   ab 140 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung1.jpg"  },


            new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="frankfurt", Mietpreis="   bis 400 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung1.jpg"  },
             new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="frankfurt", Mietpreis="   bis 400 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 4 Zimmer", Bilder="/Images/wohnung2.jpg"  },
              new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="frankfurt", Mietpreis="   bis 400 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 5 Zimmer", Bilder="/Images/wohnung2.jpg"  },
               new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="frankfurt", Mietpreis="   bis 400 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 6 Zimmer", Bilder="/Images/wohnung2.jpg"  },
                new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="frankfurt", Mietpreis="   bis 400 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 7 Zimmer", Bilder="/Images/wohnung3.jpg"  },
                 new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="frankfurt", Mietpreis=   "bis 400 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 8 Zimmer", Bilder="/Images/wohnung1.jpg"  },


            new Haeuser(){ Wohnungmieten="Haus mieten", Ort="frankfurt", Mietpreis="   bis 400 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung3.jpg"  },
             new Haeuser(){ Wohnungmieten="Haus mieten", Ort="frankfurt", Mietpreis="   bis 400 €", Wohnflaeche="   ab 60 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung3.jpg"  },
              new Haeuser(){ Wohnungmieten="Haus mieten", Ort="frankfurt", Mietpreis="   bis 400 €", Wohnflaeche="   ab 80 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung3.jpg"  },
               new Haeuser(){ Wohnungmieten="Haus mieten", Ort="frankfurt", Mietpreis="   bis 400 €", Wohnflaeche="   ab 100 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung2.jpg"  },
                new Haeuser(){ Wohnungmieten="Haus mieten", Ort="frankfurt", Mietpreis="   bis 400 €", Wohnflaeche="   ab 120 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung1.jpg"  },
                 new Haeuser(){ Wohnungmieten="Haus mieten", Ort="frankfurt", Mietpreis="   bis 400 €", Wohnflaeche="   ab 140 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung1.jpg"  },


            new Haeuser(){ Wohnungmieten="Haus mieten", Ort="frankfurt", Mietpreis="   bis 400 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung1.jpg"  },
             new Haeuser(){ Wohnungmieten="Haus mieten", Ort="frankfurt", Mietpreis="   bis 400 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 4 Zimmer", Bilder="/Images/wohnung2.jpg"  },
              new Haeuser(){ Wohnungmieten="Haus mieten", Ort="frankfurt", Mietpreis="   bis 400 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 5 Zimmer", Bilder="/Images/wohnung3.jpg"  },
               new Haeuser(){ Wohnungmieten="Haus mieten", Ort="frankfurt", Mietpreis="   bis 400 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 6 Zimmer", Bilder="/Images/wohnung1.jpg"  },
                new Haeuser(){ Wohnungmieten="Haus mieten", Ort="frankfurt", Mietpreis="   bis 400 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 7 Zimmer", Bilder="/Images/wohnung2.jpg"  },
                 new Haeuser(){ Wohnungmieten="Haus mieten", Ort="frankfurt", Mietpreis="   bis 400 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 8 Zimmer", Bilder="/Images/wohnung1.jpg"  },


            //Frankfurt 500 euro
            new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="frankfurt", Mietpreis="   bis 500 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung1.jpg"  },
             new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="frankfurt", Mietpreis="   bis 500 €", Wohnflaeche="   ab 60 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung2.jpg"  },
              new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="frankfurt", Mietpreis="   bis 500 €", Wohnflaeche="   ab 80 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung3.jpg"  },
               new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="frankfurt", Mietpreis="   bis 500 €", Wohnflaeche="   ab 100 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung1.jpg"  },
                new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="frankfurt", Mietpreis="   bis 500 €", Wohnflaeche="   ab 120 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung2.jpg"  },
                 new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="frankfurt", Mietpreis="   bis 500 €", Wohnflaeche="   ab 140 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung3.jpg"  },


            new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="frankfurt", Mietpreis="   bis 500 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung1.jpg"  },
             new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="frankfurt", Mietpreis="   bis 500 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 4 Zimmer", Bilder="/Images/wohnung2.jpg"  },
              new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="frankfurt", Mietpreis="   bis 500 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 5 Zimmer", Bilder="/Images/wohnung3.jpg"  },
               new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="frankfurt", Mietpreis="   bis 500 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 6 Zimmer", Bilder="/Images/wohnung3.jpg"  },
                new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="frankfurt", Mietpreis="   bis 500 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 7 Zimmer", Bilder="/Images/wohnung2.jpg"  },
                 new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="frankfurt", Mietpreis="   bis 500 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 8 Zimmer", Bilder="/Images/wohnung3.jpg"  },

            new Haeuser(){ Wohnungmieten="Haus mieten", Ort="frankfurt", Mietpreis="   bis 500 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung1.jpg"  },
             new Haeuser(){ Wohnungmieten="Haus mieten", Ort="frankfurt", Mietpreis="   bis 500 €", Wohnflaeche="   ab 60 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung1.jpg"  },
              new Haeuser(){ Wohnungmieten="Haus mieten", Ort="frankfurt", Mietpreis="   bis 500 €", Wohnflaeche="   ab 80 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung2.jpg"  },
               new Haeuser(){ Wohnungmieten="Haus mieten", Ort="frankfurt", Mietpreis="   bis 500 €", Wohnflaeche="   ab 100 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung3.jpg"  },
                new Haeuser(){ Wohnungmieten="Haus mieten", Ort="frankfurt", Mietpreis="   bis 500 €", Wohnflaeche="   ab 120 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung1.jpg"  },
                 new Haeuser(){ Wohnungmieten="Haus mieten", Ort="frankfurt", Mietpreis="   bis 500 €", Wohnflaeche="   ab 140 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung2.jpg"  },


            new Haeuser(){ Wohnungmieten="Haus mieten", Ort="frankfurt", Mietpreis="   bis 500 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung1.jpg"  },
             new Haeuser(){ Wohnungmieten="Haus mieten", Ort="frankfurt", Mietpreis="   bis 500 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 4 Zimmer", Bilder="/Images/wohnung2.jpg"  },
              new Haeuser(){ Wohnungmieten="Haus mieten", Ort="frankfurt", Mietpreis="   bis 500 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 5 Zimmer", Bilder="/Images/wohnung3.jpg"  },
               new Haeuser(){ Wohnungmieten="Haus mieten", Ort="frankfurt", Mietpreis="   bis 500 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 6 Zimmer", Bilder="/Images/wohnung1.jpg"  },
                new Haeuser(){ Wohnungmieten="Haus mieten", Ort="frankfurt", Mietpreis="   bis 500 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 7 Zimmer", Bilder="/Images/wohnung2.jpg"  },
                 new Haeuser(){ Wohnungmieten="Haus mieten", Ort="frankfurt", Mietpreis="   bis 500 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 8 Zimmer", Bilder="/Images/wohnung3.jpg"  },


                            //Frankfurt 600 euro
            new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="frankfurt", Mietpreis="   bis 600 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung1.jpg"  },
             new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="frankfurt", Mietpreis="   bis 600 €", Wohnflaeche="   ab 60 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung2.jpg"  },
              new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="frankfurt", Mietpreis="   bis 600 €", Wohnflaeche="   ab 80 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung3.jpg"  },
               new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="frankfurt", Mietpreis="   bis 600 €", Wohnflaeche="   ab 100 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung1.jpg"  },
                new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="frankfurt", Mietpreis="   bis 600 €", Wohnflaeche="   ab 120 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung1.jpg"  },
                 new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="frankfurt", Mietpreis="   bis 600 €", Wohnflaeche="   ab 140 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung2.jpg"  },


            new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="frankfurt", Mietpreis="   bis 600 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung1.jpg"  },
             new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="frankfurt", Mietpreis="   bis 600 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 4 Zimmer", Bilder="/Images/wohnung2.jpg"  },
              new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="frankfurt", Mietpreis="   bis 600 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 5 Zimmer", Bilder="/Images/wohnung3.jpg"  },
               new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="frankfurt", Mietpreis="   bis 600 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 6 Zimmer", Bilder="/Images/wohnung3.jpg"  },
                new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="frankfurt", Mietpreis="   bis 600 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 7 Zimmer", Bilder="/Images/wohnung2.jpg"  },
                 new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="frankfurt", Mietpreis="   bis 600 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 8 Zimmer", Bilder="/Images/wohnung1.jpg"  },


            new Haeuser(){ Wohnungmieten="Haus mieten", Ort="frankfurt", Mietpreis="   bis 600 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung1.jpg"  },
             new Haeuser(){ Wohnungmieten="Haus mieten", Ort="frankfurt", Mietpreis="   bis 600 €", Wohnflaeche="   ab 60 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung2.jpg"  },
              new Haeuser(){ Wohnungmieten="Haus mieten", Ort="frankfurt", Mietpreis="   bis 600 €", Wohnflaeche="   ab 80 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung1.jpg"  },
               new Haeuser(){ Wohnungmieten="Haus mieten", Ort="frankfurt", Mietpreis="   bis 600 €", Wohnflaeche="   ab 100 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung1.jpg"  },
                new Haeuser(){ Wohnungmieten="Haus mieten", Ort="frankfurt", Mietpreis="   bis 600 €", Wohnflaeche="   ab 120 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung2.jpg"  },
                 new Haeuser(){ Wohnungmieten="Haus mieten", Ort="frankfurt", Mietpreis="   bis 600 €", Wohnflaeche="   ab 140 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung3.jpg"  },


            new Haeuser(){ Wohnungmieten="Haus mieten", Ort="frankfurt", Mietpreis="   bis 600 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung1.jpg"  },
             new Haeuser(){ Wohnungmieten="Haus mieten", Ort="frankfurt", Mietpreis="   bis 600 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 4 Zimmer", Bilder="/Images/wohnung2.jpg"  },
              new Haeuser(){ Wohnungmieten="Haus mieten", Ort="frankfurt", Mietpreis="   bis 600 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 5 Zimmer", Bilder="/Images/wohnung3.jpg"  },
               new Haeuser(){ Wohnungmieten="Haus mieten", Ort="frankfurt", Mietpreis="   bis 600 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 6 Zimmer", Bilder="/Images/wohnung1.jpg"  },
                new Haeuser(){ Wohnungmieten="Haus mieten", Ort="frankfurt", Mietpreis="   bis 600 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 7 Zimmer", Bilder="/Images/wohnung2.jpg"  },
                 new Haeuser(){ Wohnungmieten="Haus mieten", Ort="frankfurt", Mietpreis="   bis 600 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 8 Zimmer", Bilder="/Images/wohnung3.jpg"  },


            //Frankfurt 700 euro
            new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="frankfurt", Mietpreis="   bis 700 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung1.jpg"  },
             new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="frankfurt", Mietpreis="   bis 700 €", Wohnflaeche="   ab 60 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung2.jpg"  },
              new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="frankfurt", Mietpreis="   bis 700 €", Wohnflaeche="   ab 80 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung3.jpg"  },
               new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="frankfurt", Mietpreis="   bis 700 €", Wohnflaeche="   ab 100 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung1.jpg"  },
                new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="frankfurt", Mietpreis="   bis 700 €", Wohnflaeche="   ab 120 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung2.jpg"  },
                 new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="frankfurt", Mietpreis="   bis 700 €", Wohnflaeche="   ab 140 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung3.jpgg"  },


            new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="frankfurt", Mietpreis="   bis 700 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung1.jpg"  },
             new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="frankfurt", Mietpreis="   bis 700 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 4 Zimmer", Bilder="/Images/wohnung2.jpg"  },
              new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="frankfurt", Mietpreis="   bis 700 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 5 Zimmer", Bilder="/Images/wohnung3.jpg"  },
               new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="frankfurt", Mietpreis="   bis 700 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 6 Zimmer", Bilder="/Images/wohnung1.jpg"  },
                new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="frankfurt", Mietpreis="   bis 700 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 7 Zimmer", Bilder="/Images/wohnung2.jpg"  },
                 new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="frankfurt", Mietpreis="   bis 700 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 8 Zimmer", Bilder="/Images/wohnung3.jpg"  },


            new Haeuser(){ Wohnungmieten="Haus mieten", Ort="frankfurt", Mietpreis="   bis 700 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung1.jpg"  },
             new Haeuser(){ Wohnungmieten="Haus mieten", Ort="frankfurt", Mietpreis="   bis 700 €", Wohnflaeche="   ab 60 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/iwohnung2.jpg"  },
              new Haeuser(){ Wohnungmieten="Haus mieten", Ort="frankfurt", Mietpreis="   bis 700 €", Wohnflaeche="   ab 80 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung3.jpg"  },
               new Haeuser(){ Wohnungmieten="Haus mieten", Ort="frankfurt", Mietpreis="   bis 700 €", Wohnflaeche="   ab 100 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung1.jpg"  },
                new Haeuser(){ Wohnungmieten="Haus mieten", Ort="frankfurt", Mietpreis="   bis 700 €", Wohnflaeche="   ab 120 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung2.jpg"  },
                 new Haeuser(){ Wohnungmieten="Haus mieten", Ort="frankfurt", Mietpreis="   bis 700 €", Wohnflaeche="   ab 140 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung3.jpg"  },


            new Haeuser(){ Wohnungmieten="Haus mieten", Ort="frankfurt", Mietpreis="   bis 700 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung1.jpg"  },
             new Haeuser(){ Wohnungmieten="Haus mieten", Ort="frankfurt", Mietpreis="   bis 700 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 4 Zimmer", Bilder="/Images/wohnung1.jpg"  },
              new Haeuser(){ Wohnungmieten="Haus mieten", Ort="frankfurt", Mietpreis="   bis 700 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 5 Zimmer", Bilder="/Images/wohnung2.jpg"  },
               new Haeuser(){ Wohnungmieten="Haus mieten", Ort="frankfurt", Mietpreis="   bis 700 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 6 Zimmer", Bilder="/Images/wohnung2.jpg"  },
                new Haeuser(){ Wohnungmieten="Haus mieten", Ort="frankfurt", Mietpreis="   bis 700 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 7 Zimmer", Bilder="/Images/wohnung3.jpg"  },
                 new Haeuser(){ Wohnungmieten="Haus mieten", Ort="frankfurt", Mietpreis="   bis 700 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 8 Zimmer", Bilder="/Images/wohnung1.jpg"  },


            //Frankfurt 800 euro
            new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="frankfurt", Mietpreis="   bis 800 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung2.jpg"  },
             new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="frankfurt", Mietpreis="   bis 800 €", Wohnflaeche="   ab 60 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung1.jpg"  },
              new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="frankfurt", Mietpreis="   bis 800 €", Wohnflaeche="   ab 80 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung1.jpg"  },
               new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="frankfurt", Mietpreis="   bis 800 €", Wohnflaeche="   ab 100 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung2.jpg"  },
                new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="frankfurt", Mietpreis="   bis 800 €", Wohnflaeche="   ab 120 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung1.jpg"  },
                 new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="frankfurt", Mietpreis="   bis 800 €", Wohnflaeche="   ab 140 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung3.jpg"  },


            new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="frankfurt", Mietpreis="   bis 800 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung1.jpg"  },
             new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="frankfurt", Mietpreis="   bis 800 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 4 Zimmer", Bilder="/Images/wohnung2.jpg"  },
              new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="frankfurt", Mietpreis="   bis 800 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 5 Zimmer", Bilder="/Images/wohnung3.jpg"  },
               new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="frankfurt", Mietpreis="   bis 800 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 6 Zimmer", Bilder="/Images/wohnung1.jpg"  },
                new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="frankfurt", Mietpreis="   bis 800 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 7 Zimmer", Bilder="/Images/wohnung2.jpg"  },
                 new Haeuser(){ Wohnungmieten="Wohnung mieten", Ort="frankfurt", Mietpreis="   bis 800 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 8 Zimmer", Bilder="/Images/wohnung3.jpg"  },


            new Haeuser(){ Wohnungmieten="Haus mieten", Ort="frankfurt", Mietpreis="   bis 800 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung1.jpg"  },
             new Haeuser(){ Wohnungmieten="Haus mieten", Ort="frankfurt", Mietpreis="   bis 800 €", Wohnflaeche="   ab 60 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung2.jpg"  },
              new Haeuser(){ Wohnungmieten="Haus mieten", Ort="frankfurt", Mietpreis="   bis 800 €", Wohnflaeche="   ab 80 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung3.jpg"  },
               new Haeuser(){ Wohnungmieten="Haus mieten", Ort="frankfurt", Mietpreis="   bis 800 €", Wohnflaeche="   ab 100 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung1.jpg"  },
                new Haeuser(){ Wohnungmieten="Haus mieten", Ort="frankfurt", Mietpreis="   bis 800 €", Wohnflaeche="   ab 120 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung2.jpg"  },
                 new Haeuser(){ Wohnungmieten="Haus mieten", Ort="frankfurt", Mietpreis="   bis 800 €", Wohnflaeche="   ab 140 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung3.jpg"  },


            new Haeuser(){ Wohnungmieten="Haus mieten", Ort="frankfurt", Mietpreis="   bis 800 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 3 Zimmer", Bilder="/Images/wohnung1.jpg"  },
             new Haeuser(){ Wohnungmieten="Haus mieten", Ort="frankfurt", Mietpreis="   bis 800 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 4 Zimmer", Bilder="/Images/wohnung2.jpg"  },
              new Haeuser(){ Wohnungmieten="Haus mieten", Ort="frankfurt", Mietpreis="   bis 800 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 5 Zimmer", Bilder="/Images/wohnung1.jpg"  },
               new Haeuser(){ Wohnungmieten="Haus mieten", Ort="frankfurt", Mietpreis="   bis 800 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 6 Zimmer", Bilder="/Images/wohnung3.jpg"  },
                new Haeuser(){ Wohnungmieten="Haus mieten", Ort="frankfurt", Mietpreis="   bis 800 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 7 Zimmer", Bilder="/Images/wohnung1.jpg"  },
                 new Haeuser(){ Wohnungmieten="Haus mieten", Ort="frankfurt", Mietpreis="   bis 800 €", Wohnflaeche="   ab 40 qm²", Zimmer="   ab 8 Zimmer", Bilder="/Images/iwohnung3.jpg"  },


        };

        public List<Haeuser> LocalList
        {
            get
            {
                return _localList;
            }

            set
            {

            }
        }



        //public List<Haeuser> getLocalList() {


        //    return _localList;
        //}



    }
}