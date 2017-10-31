using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObject.Interfaces
{
    public interface IMainPage
    {
        void AddNewTask();
        String GetLastTitle();
        String GetLastDescription();
        String GetLastColor();
    }
}
