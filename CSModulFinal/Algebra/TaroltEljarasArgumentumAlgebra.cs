using System;
using System.Collections.Generic;
using System.Text;
using d7p4n4Namespace.PreProcessed.Class;
using d7p4n4Namespace.Final.Class;

namespace d7p4n4Namespace.Algebra.Class
{
	public class TaroltEljarasArgumentumAlgebra : TaroltEljarasArgumentumPreProcessed
	{

		public String getAdattipus() {
        		return Adattipus;
        }

		public String getHumanNev() {
        		return HumanNev;
        }

		public String getBelsoNev() {
        		return BelsoNev;
        }

		public String getIranya() {
        		return Iranya;
        }

		public String getOpcionalitas() {
        		return Opcionalitas;
        }


    		public void setAdattipus(String newValue) {
        		Adattipus = newValue;
        }

    		public void setHumanNev(String newValue) {
        		HumanNev = newValue;
        }

    		public void setBelsoNev(String newValue) {
        		BelsoNev = newValue;
        }

    		public void setIranya(String newValue) {
        		Iranya = newValue;
        }

    		public void setOpcionalitas(String newValue) {
        		Opcionalitas = newValue;
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

		public Boolean hasHumanNev(){
			if(this.getHumanNev() != null){

				return true;
			}
			else
			{
				return false;
			}
		}

		public Boolean hasBelsoNev(){
			if(this.getBelsoNev() != null){

				return true;
			}
			else
			{
				return false;
			}
		}

		public Boolean hasIranya(){
			if(this.getIranya() != null){

				return true;
			}
			else
			{
				return false;
			}
		}

		public Boolean hasOpcionalitas(){
			if(this.getOpcionalitas() != null){

				return true;
			}
			else
			{
				return false;
			}
		}

    


	}
}
