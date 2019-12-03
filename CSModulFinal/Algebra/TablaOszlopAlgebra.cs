using System;
using System.Collections.Generic;
using System.Text;
using d7p4n4Namespace.PreProcessed.Class;
using d7p4n4Namespace.Final.Class;

namespace d7p4n4Namespace.Algebra.Class
{
	public class TablaOszlopAlgebra : TablaOszlopPreProcessed
	{

		public String getAdattipus() {
        		return Adattipus;
        }


    		public void setAdattipus(String newValue) {
        		Adattipus = newValue;
        }
	
		public Boolean hasAdattipus(){
			if(this.getAdattipus() != null){

				return true;
			}
			else
			{
				return false;
			}
		}

    


	}
}
