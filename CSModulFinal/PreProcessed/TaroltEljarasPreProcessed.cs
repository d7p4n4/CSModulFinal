
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CSGUIDLib;
using d7p4n4Namespace.Final.Class;

namespace d7p4n4Namespace.PreProcessed.Class
{
	            [GUID("")]
	public class TaroltEljarasPreProcessed : RAMetaObjektum

	{
    		public List<Muvelet> MuveletLista { get; set; }
    		public List<TaroltEljarasArgumentum> ArgumentumLista { get; set; }
    		public string GUID { get; set; }
		
		public TaroltEljarasPreProcessed()
		{
			GUID = "";
		}
	}
}