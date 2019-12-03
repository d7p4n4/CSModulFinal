using System;
using System.Collections.Generic;
using System.Text;
using d7p4n4Namespace.PreProcessed.Class;
using d7p4n4Namespace.Final.Class;

namespace d7p4n4Namespace.Algebra.Class
{
	public class TaroltEljarasAlgebra : TaroltEljarasPreProcessed
	{

		public List<Muvelet> getMuveletLista() {
        		return MuveletLista;
        }

		public List<TaroltEljarasArgumentum> getArgumentumLista() {
        		return ArgumentumLista;
        }


    		public void setMuveletLista(List<Muvelet> newValue) {
        		MuveletLista = newValue;
        }

    		public void setArgumentumLista(List<TaroltEljarasArgumentum> newValue) {
        		ArgumentumLista = newValue;
        }
	
    

    		public int countMuveletLista()
        	{
        	        int i = this.getMuveletLista().Count;

            		return i;
        	}


    		public int countArgumentumLista()
        	{
        	        int i = this.getArgumentumLista().Count;

            		return i;
        	}



    		public Boolean hasMuveletListaMember()
        	{
        	        int i = this.getMuveletLista().Count;

			if(i > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
        	}

    		public Boolean hasArgumentumListaMember()
        	{
        	        int i = this.getArgumentumLista().Count;

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
