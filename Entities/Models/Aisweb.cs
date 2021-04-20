using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Entities.Models
{

	public class Aisweb
	{

		[XmlElement(ElementName = "id")]
		public long Id { get; set; }

		[XmlElement(ElementName = "cod")]
		public string Cod { get; set; }

		[XmlElement(ElementName = "status")]
		public string Status { get; set; }

		[XmlElement(ElementName = "cat")]
		public string Cat { get; set; }

		[XmlElement(ElementName = "dist")]
		public string Dist { get; set; }

		[XmlElement(ElementName = "tp")]
		public string Tp { get; set; }

		[XmlElement(ElementName = "dt")]
		public DateTime Dt { get; set; }

		[XmlElement(ElementName = "n")]
		public string N { get; set; }

		[XmlElement(ElementName = "number")]
		public int Number { get; set; }

		[XmlElement(ElementName = "ref")]
		public string Ref { get; set; }

		[XmlElement(ElementName = "ref_id")]
		public string RefId { get; set; }

		[XmlElement(ElementName = "ref_s")]
		public string RefS { get; set; }

		[XmlElement(ElementName = "loc")]
		public string Loc { get; set; }

		[XmlElement(ElementName = "b")]
		public int B { get; set; }

		[XmlElement(ElementName = "c")]
		public int C { get; set; }

		[XmlElement(ElementName = "d")]
		public string D { get; set; }

		[XmlElement(ElementName = "e")]
		public string E { get; set; }

		[XmlElement(ElementName = "f")]
		public string F { get; set; }

		[XmlElement(ElementName = "g")]
		public string G { get; set; }

		[XmlElement(ElementName = "nof")]
		public string Nof { get; set; }

		[XmlElement(ElementName = "s")]
		public string S { get; set; }

		[XmlElement(ElementName = "geo")]
		public string Geo { get; set; }

		[XmlElement(ElementName = "geo_url")]
		public string GeoUrl { get; set; }

		[XmlElement(ElementName = "aero")]
		public string Aero { get; set; }

		[XmlElement(ElementName = "cidade")]
		public string Cidade { get; set; }

		[XmlElement(ElementName = "uf")]
		public string Uf { get; set; }

		[XmlElement(ElementName = "origem")]
		public string Origem { get; set; }

		[XmlElement(ElementName = "fir")]
		public string Fir { get; set; }

		[XmlElement(ElementName = "year")]
		public int Year { get; set; }

		[XmlElement(ElementName = "traffic")]
		public string Traffic { get; set; }

		[XmlElement(ElementName = "lower")]
		public int Lower { get; set; }

		[XmlElement(ElementName = "upper")]
		public int Upper { get; set; }

		[XmlElement(ElementName = "state")]
		public string State { get; set; }

		[XmlElement(ElementName = "seqnumber")]
		public int Seqnumber { get; set; }

		[XmlElement(ElementName = "purpose")]
		public string Purpose { get; set; }

		[XmlElement(ElementName = "scope")]
		public string Scope { get; set; }

		[XmlText]
		public string Text { get; set; }
	}

}
