using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FOP;

namespace EntryPoint
{
    public static class  Program
    {
        static void Main(string[] args)
        {
            Util.GeneratePdf("fonts.fo.xml", "fonts.fo.pdf");
            Util.GenerateXmlFromXslt("NameFo.xsl","Name.xml","Name.fo.xml");
            Util.GeneratePdf("Name.fo.xml", "Name.fo.pdf");
            Console.Read();
        }
    }
}
