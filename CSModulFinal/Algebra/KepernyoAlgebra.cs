using System;
using System.Collections.Generic;
using System.Text;
using d7p4n4Namespace.PreProcessed.Class;
using d7p4n4Namespace.Final.Class;

namespace d7p4n4Namespace.Algebra.Class
{
	public class KepernyoAlgebra : KepernyoPreProcessed
	{

		public List<Kepernyo> getKepernyoLista() {
        		return KepernyoLista;
        }

		public List<TaroltEljaras> getTaroltEljarasLista() {
        		return TaroltEljarasLista;
        }

		public List<Muvelet> getMuveletLista() {
        		return MuveletLista;
        }


    		public void setKepernyoLista(List<Kepernyo> newValue) {
        		KepernyoLista = newValue;
        }

    		public void setTaroltEljarasLista(List<TaroltEljaras> newValue) {
        		TaroltEljarasLista = newValue;
        }

    		public void setMuveletLista(List<Muvelet> newValue) {
        		MuveletLista = newValue;
        }
	
    

    		public int countKepernyoLista()
        	{
        	        int i = this.getKepernyoLista().Count;

            		return i;
        	}


    		public int countTaroltEljarasLista()
        	{
        	        int i = this.getTaroltEljarasLista().Count;

            		return i;
        	}


    		public int countMuveletLista()
        	{
        	        int i = this.getMuveletLista().Count;

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

    		public Boolean hasTaroltEljarasListaMember()
        	{
        	        int i = this.getTaroltEljarasLista().Count;

			if(i > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
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

	}
}
