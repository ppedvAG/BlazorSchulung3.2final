using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorSchulung3._2final.Data
{
    public class Zaehler
    {
        public int MyProperty { get; set; }
        public event EventHandler OnChanged;
       public void Inc()
        {
            MyProperty++;
            OnChanged.Invoke(this, EventArgs.Empty);

        }


    }
}
