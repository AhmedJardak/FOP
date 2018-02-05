using System.Xml;
using System.Xml.XPath;
using System.Xml.Xsl;
using org.apache.fop.tools;
using org.apache.fop.apps;
using org.xml.sax;
using java.io;

namespace FOP
{
  
  public static class Util
    {
        public static void GenerateXmlFromXslt(string xsltFilePath,string xmlfilePath,string resultFilePath)
        {
            var myXslTrans = new XslCompiledTransform();
            myXslTrans.Load(xsltFilePath);
            myXslTrans.Transform(xmlfilePath, resultFilePath);
        }
        public static void GeneratePdf(string foFile, string pdfFile)
        {
            OutputStream os = new BufferedOutputStream(new FileOutputStream(new java.io.File(pdfFile)));

            try
            {
                FopFactory fopFactory = FopFactory.newInstance(new java.net.URI("."));
                Fop fop = fopFactory.newFop("application/pdf", os);
                javax.xml.transform.TransformerFactory factory = javax.xml.transform.TransformerFactory.newInstance();
                javax.xml.transform.Transformer transformer = factory.newTransformer();
                javax.xml.transform.Source source = new javax.xml.transform.stream.StreamSource(new java.io.File(foFile));
                javax.xml.transform.Result result = new javax.xml.transform.sax.SAXResult(fop.getDefaultHandler());
                transformer.transform(source, result);
            }

            finally
            {
                os.close();
            }
        }
    }
}
