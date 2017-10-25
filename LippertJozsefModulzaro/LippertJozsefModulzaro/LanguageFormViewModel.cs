using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LippertJozsefModulzaro
{
    class LanguageFormViewModel:BaseModel
    {
        public Language Language { get; set; }
        public bool IsNew { get; set; }

        Language language;
        public LanguageFormViewModel(Language Language)
        {
            this.Language = Language;
            if (!IsNew)
                Save();
        }

        public bool LanguageValidate()
        {
            return !string.IsNullOrEmpty(Language.Name) && Language.Name.Length > 0 && !string.IsNullOrEmpty(Language.Area) && 
                Language.Area.Length > 0 &&  (Language.Difficulty >0 && Language.Difficulty <= 100);
        }

        public void Save()
        {
            if (!IsNew)
                language = new Language { Name = Language.Name, Area = Language.Area, Difficulty = Language.Difficulty };
        }

        public void OriginalValue()
        {
            Language.Name = language.Name;
            Language.Area = language.Area;
            Language.Difficulty = language.Difficulty;
        }
    }
}
