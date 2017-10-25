using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LippertJozsefModulzaro
{
    public class Language : BaseModel
    {
        string _name;
        string _area;
        int _difficulty;

        public string Name { get { return _name; } set { _name = value; OnPropertyChange(); } }
        public string Area { get { return _area; } set { _area = value; OnPropertyChange(); } }
        public int Difficulty { get { return _difficulty; } set { _difficulty = value; OnPropertyChange(); } }

       
    }
}
