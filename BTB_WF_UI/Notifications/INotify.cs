using BTB_Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTB_WF_UI
{
    interface INotify
    {
        void Notify(List<Cart> listofitems,string recipient,int ordernum);
    }
}
