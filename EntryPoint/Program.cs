using System;
using FOP;

namespace EntryPoint
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            GenerateFonts();
            GenerateNameExample();
            GenerateEtiquetteExample();
            Console.Read();
        }

        private static void GenerateEtiquetteExample()
        {
            Util.GenerateXmlFromXslt("etiquette.xsl", "etiquette.xml", "etiquette.fo.xml");
            Util.GeneratePdf("etiquette.fo.xml", "etiquette.fo.pdf");
            Console.WriteLine("etiquette.fo.pdf is generated . Look at bin directory");
        }

        private static void GenerateNameExample()
        {
            Util.GenerateXmlFromXslt("NameFo.xsl", "Name.xml", "Name.fo.xml");
            Util.GeneratePdf("Name.fo.xml", "Name.fo.pdf");
            Console.WriteLine("Name.fo.pdf is generated . Look at bin directory");
        }

        private static void GenerateFonts()
        {
            Util.GeneratePdf("fonts.fo.xml", "fonts.fo.pdf");
            Console.WriteLine("fonts.fo.pdf is generated . Look at bin directory");
        }
    }
}