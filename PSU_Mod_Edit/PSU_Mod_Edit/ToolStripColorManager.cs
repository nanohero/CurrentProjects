using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSU_Mod_Edit
{
   
    class ToolStripColorManager: ToolStripProfessionalRenderer {

        System.Drawing.Color clor2;
        MenuItemColorscs menu;
        
        public ToolStripColorManager(): base(new MenuItemColorscs()) {}

        public ToolStripColorManager(MenuItemColorscs mic)
        {
            menu = mic;
        }
        }
    

    }


