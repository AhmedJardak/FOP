<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet xmlns:fo="http://www.w3.org/1999/XSL/Format"
    xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0">
    <xsl:output indent="yes"/>
    <xsl:template match="/">
    
        <fo:root xmlns:fo="http://www.w3.org/1999/XSL/Format">
            
     
            <fo:layout-master-set>
                <fo:simple-page-master master-name="A4"
                    page-height="4cm"
                    page-width="4cm"
                    margin-top="0mm"
                    margin-bottom="0mm"
                    margin-left="0mm"
                    margin-right="0mm">
                    <fo:region-body margin-top="0mm" margin-bottom="0mm"  />
                </fo:simple-page-master>
            </fo:layout-master-set>
            
            <fo:page-sequence master-reference="A4">
                <fo:flow flow-name="xsl-region-body">
                    <fo:block>
                        <xsl:value-of select="/label/name"/>
                    </fo:block>
                    <fo:block>
                        <xsl:value-of select="/label/prescription"/>
                    </fo:block>
                    <fo:block>
                        <xsl:value-of select="/label/date"/>
                    </fo:block>
                    <fo:block>
                        <xsl:value-of select="/label/time"/>
                    </fo:block>
                </fo:flow>
                
            </fo:page-sequence>
        </fo:root>
</xsl:template>
   
</xsl:stylesheet>
