using _3.LiskovSubstitutionPrinciple.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3.LiskovSubstitutionPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            Export obj;
            if (1 == 1)//PDF
            {
                obj = new ExportToPdf(); // Export to pdf can be substituted
            }
            else
            {
                obj = new ExportToExcel();
            }

                obj.Convert(@"c:\demo.txt");
            
        }
    }
}
