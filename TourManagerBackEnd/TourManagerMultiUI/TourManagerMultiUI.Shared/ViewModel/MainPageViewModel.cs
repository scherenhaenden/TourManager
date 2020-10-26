using System;

namespace TourManagerMultiUI.Shared.ViewModel
{
    public class MainPageViewModel:ViewModelBase
    {
        public string Greeting => "Welcome to Avalonia!";
        private string _name2 = "hola";
        
        public void Next()
        {
            //Complete?.Invoke(this, EventArgs.Empty);
            _name2 = "clicked";
        }
        public void ClickCommand()
        {

        }
    }
}