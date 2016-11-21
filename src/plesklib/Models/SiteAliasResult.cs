﻿using System.Xml.Serialization;
namespace plesklib.Models
{
    [XmlRoot("packet")]
    public class SiteAliasPacketResult
    {
        [XmlElement("site-alias")]
        public SiteAliasResult siteAlias { get; set; }
    }

    public class SiteAliasResult 
    {
        [XmlElement("create")]
        public SiteAliasCreateResult create { get; set; }
    }

    public class SiteAliasCreateResult
    {
        [XmlElement("result")]
        public ResponseResult result { get; set; }
    }
}