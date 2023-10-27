using System.ComponentModel.DataAnnotations;

namespace QRGenerador.Models
{
	public class QRAtributo
	{
		public int ID{ get; set; }
		public string URL{ get; set; }
		public byte[] Imagen { get; set; }
	}
}
