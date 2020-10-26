using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;


namespace TourManagerMultiUI.Shared.ViewModel
{
    public class ViewModelBase
    {
        private string _name2 = "hola";

        public string Name2
        {
            get { return _name2; }
            set
            {
                _name2 = value;
            }
        }

        public void MyAction()
        {

        }
    }
}
