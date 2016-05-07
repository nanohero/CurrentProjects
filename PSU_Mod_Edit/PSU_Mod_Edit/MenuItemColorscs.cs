using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSU_Mod_Edit
{
    class MenuItemColorscs : ProfessionalColorTable
    {
       
      public System.Drawing.Color col { get; set; }
        
        public MenuItemColorscs(System.Drawing.Color col)
        {
            col = System.Drawing.Color.Purple;
        }

        public MenuItemColorscs()
        {
            // TODO: Complete member initialization
            col = System.Drawing.SystemColors.Control;
         
        }
        public override System.Drawing.Color MenuItemSelected
        {
            get
            {
                return col;
               
                
            }
        }

    }
}
