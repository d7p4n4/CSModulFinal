using System;
using System.Collections.Generic;
using System.Text;
using d7p4n4Namespace.PreProcessed.Class;
using d7p4n4Namespace.Final.Class;

namespace d7p4n4Namespace.Algebra.Class
{
	public class TablaAlgebra : TablaPreProcessed
	{
        public List<TablaOszlop> getTablaOszlopLista()
        {
            return TablaOszlopLista;
        }

        public void setTablaOszlopLista(List<TablaOszlop> newValue)
        {
            TablaOszlopLista = newValue;
        }

        public Boolean hasTablaOszlopLista()
        {
            int i = this.getTablaOszlopLista().Count;

            if (i > 0)
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
