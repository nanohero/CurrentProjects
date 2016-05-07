using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSU_Mod_Edit
{
    class CodesManager
    {
        public string[] maleClothes {get;set;}
        string[] maleCodes;
        public string[] femaleClothes { get; set; }
        public string[] femaleCodes;
        public string[] maleParts {get;set;}
        public string[] malePartsCodes { get; set; }
        public string[] femaleParts {get;set;}
       public string[] femalePartCodes { get; set; }
        public string[] aotiColors {get;set;}
        public string[] aotiColorCodes;
        public string[] aotiFemale {get;set;}
       public string[] aotiFemaleCodes { get; set; }
        public BindingSource theBindingSource{get;set;}
        public CodesManager()
        {
            maleClothes = new string[37];
            maleCodes = new string[37];
            femaleClothes = new string[40];
            femaleCodes = new string[40];
            maleParts = new string[29];
            malePartsCodes = new string[29];
            femaleParts = new string[36];
            femalePartCodes = new string[36];
            aotiColors = new string[35];
            aotiColorCodes = new string[35];
            aotiFemale = new string[39];
            aotiFemaleCodes = new string[39];
             theBindingSource = new BindingSource();
        }
        public CodesManager(string[] maleClo, string[] maleCo, string[] femaleClo, string[] femaleCo, string[] malePar, string[] maleParCo, string[] femalePa, string[] femalePaCo, string[] aotiCol, string[] aotiColCo, string[] aotiFe, string[] aotiFeCo)
        {
            maleClothes = maleClo;
            maleCodes = maleCo;
            femaleClothes = femaleClo;
            femaleCodes = femaleCo;
            maleParts = malePar;
            malePartsCodes = maleParCo;
            femaleParts = femalePaCo;
            femalePartCodes = femalePaCo;
            aotiColors = aotiCol;
            aotiColorCodes = aotiColCo;
            aotiFemale = aotiFe;
            aotiFemaleCodes = aotiFeCo;
        }
        public void AddClothes(string fileName, string[] clothesArray)
        {
            string line;
            int i = 0;
            try
            {
                System.IO.StreamReader file = new System.IO.StreamReader(fileName);
                while ((line = file.ReadLine()) != null)
                {
                    clothesArray[i] = line;
                    i++;
                }
                file.Close();
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            theBindingSource.DataSource = clothesArray;

        }
      
    }
}
