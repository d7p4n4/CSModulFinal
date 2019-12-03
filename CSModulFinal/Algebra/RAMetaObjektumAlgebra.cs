using System;
using System.Collections.Generic;
using System.Text;
using d7p4n4Namespace.PreProcessed.Class;
using d7p4n4Namespace.Final.Class;

namespace d7p4n4Namespace.Algebra.Class
{
	public class RAMetaObjektumAlgebra : RAMetaObjektumPreProcessed
	{

		public String getNev() {
        		return Nev;
        }

		public String getMegnevezes() {
        		return Megnevezes;
        }

		public String getKod() {
        		return Kod;
        }

		public String getLeiras() {
        		return Leiras;
        }

        public int getId()
        {
            return id;
        }

        public String getSerialization()
        {
            return serialization;
        }


    		public void setNev(String newValue) {
        		Nev = newValue;
        }

    		public void setMegnevezes(String newValue) {
        		Megnevezes = newValue;
        }

    		public void setKod(String newValue) {
        		Kod = newValue;
        }

    		public void setLeiras(String newValue) {
        		Leiras = newValue;
        }

        public void setId(int newValue)
        {
            id = newValue;
        }

        public void setSerialization(String newValue)
        {
            serialization = newValue;
        }

        public Boolean hasNev(){
			if(this.getNev() != null){

				return true;
			}
			else
			{
				return false;
			}
		}

		public Boolean hasMegnevezes(){
			if(this.getMegnevezes() != null){

				return true;
			}
			else
			{
				return false;
			}
		}

		public Boolean hasKod(){
			if(this.getKod() != null){

				return true;
			}
			else
			{
				return false;
			}
		}

		public Boolean hasLeiras(){
			if(this.getLeiras() != null){

				return true;
			}
			else
			{
				return false;
			}
		}

        public Boolean hasId()
        {
            if (this.getId() != null)
            {

                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean hasSerialization()
        {
            if (this.getSerialization() != null)
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
