using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;


namespace LippertJozsefModulzaro
{
    class MainViewModel:BaseModel
    {
        public ObservableCollection<Language> LanguageList { get; set; }
        public Language SelectLanguage { get; set; }
        public MainViewModel()
        {
            LanguageList = new ObservableCollection<Language>();
            //var ctx = new Context();
           
        } 
    }
}
