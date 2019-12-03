using System;
using System.Collections.Generic;
using System.Text;
using d7p4n4Namespace.PreProcessed.Class;
using d7p4n4Namespace.Final.Class;

namespace d7p4n4Namespace.Algebra.Class
{
	public class ModulAlgebra : ModulPreProcessed
	{

		public List<Kepernyo> getKepernyoLista() {
        		return KepernyoLista;
        }


    		public void setKepernyoLista(List<Kepernyo> newValue) {
        		KepernyoLista = newValue;
        }
	
    

    		public int countKepernyoLista()
        	{
        	        int i = this.getKepernyoLista().Count;

            		return i;
        	}



    		public Boolean hasKepernyoListaMember()
        	{
        	        int i = this.getKepernyoLista().Count;

			if(i > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
        	}

	}
}
