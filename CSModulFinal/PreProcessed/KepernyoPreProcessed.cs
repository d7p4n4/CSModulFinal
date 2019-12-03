
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using d7p4n4Namespace.Final.Class;
using CSGUIDLib;

namespace d7p4n4Namespace.PreProcessed.Class
{
	            [GUID("")]
	public class KepernyoPreProcessed : RAMetaObjektum

	{
    		public List<Kepernyo> KepernyoLista { get; set; }
    		public List<TaroltEljaras> TaroltEljarasLista { get; set; }
    		public List<Muvelet> MuveletLista { get; set; }
		
		public KepernyoPreProcessed()
		{
		}
	}
}