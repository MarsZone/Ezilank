package utility;
import java.net.URL;
import java.util.Iterator;

import org.dom4j.Attribute;
import org.dom4j.Document;
import org.dom4j.DocumentException;
import org.dom4j.Element;
import org.dom4j.io.SAXReader;

public class XmlReader {

	public XmlReader()
	{
		
	}
	
	public Document parse() throws DocumentException {
        SAXReader reader = new SAXReader();
        Document document = reader.read("beanConfig.xml");
        return document;
    }
	
	public void bar(Document document) throws DocumentException {

        Element root = document.getRootElement();

        // iterate through child elements of root
        for ( Iterator i = root.elementIterator(); i.hasNext(); ) {
            Element element = (Element) i.next();
            // do something
        }

        // iterate through child elements of root with element name "foo"
        for ( Iterator i = root.elementIterator( "foo" ); i.hasNext(); ) {
            Element foo = (Element) i.next();
            // do something
        }

        // iterate through attributes of root 
        for ( Iterator i = root.attributeIterator(); i.hasNext(); ) {
            Attribute attribute = (Attribute) i.next();
            // do something
        }
     }
}
/*XmlReader xr=new XmlReader();
try {
	xr.parse();
} catch (DocumentException e) {
	// TODO Auto-generated catch block
	e.printStackTrace();
}*/