namespace ClashRoyal.Models
{
    public class Language
    {
        public string Play { get;  }
        public string Settings { get;  }


        public string ConfigLanguage { get;  }
        public string ConfigMap { get;  }
        public string ConfigBack { get;  }


        public Language(string chose)
        {
            if (chose == "UA")
            {
                Play = "Грати";
                Settings = "Налаштування";

                ConfigLanguage = "Вибір мови";
                ConfigMap = "Вибір карти";
                ConfigBack = "До головного меню";
            }
            else if(chose == "EN")
            {
                Play = "Play";
                Settings = "Settings";

                ConfigLanguage = "Language Settings";
                ConfigMap = "Choose of Map";
                ConfigBack = "Back to Main Menu";
            }
        } 
    }

}
