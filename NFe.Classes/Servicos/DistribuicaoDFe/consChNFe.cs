using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace NFe.Classes.Servicos.DistribuicaoDFe
{
    /// <summary>
    /// A09 - Grupo para consultar um DF-e a partir de um NSU específico
    /// </summary>
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public class consChNFe
    {
        public string chNFe { get; set; }
    }
}
