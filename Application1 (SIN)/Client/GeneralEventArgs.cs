using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    public enum GeneralEvents
    {
        ChangeCategory,
        UpdateUser
    }
    public class GeneralEventArgs : EventArgs
    {
        private readonly GeneralEvents genEvent;

        public GeneralEvents GenEvent
        {
            get { return genEvent; }
        }

        private readonly object data;

        public object Data
        {
            get { return data; }
        }


        public GeneralEventArgs(GeneralEvents genEvent, object data)
        {
            this.genEvent = genEvent;
            this.data = data;
        }
    }
}
