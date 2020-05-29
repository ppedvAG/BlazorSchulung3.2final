using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace BlazorSchulung3._2final.Data
{
    public class HeadData
    {
     
        private string description;

        private string _title;
                public string Title
        {
            get { return _title; }
            set { _title = value;
                
                OnChange?.Invoke(this, EventArgs.Empty);

            }
        }

        public string Description { get => description; set => description = value; }
        public event EventHandler OnChange;


    }
}
