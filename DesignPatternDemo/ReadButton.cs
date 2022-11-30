using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDemo
{
    using System.ComponentModel;
    public class ReadButton
    {
        private readonly string buttonName;
        private string buttonText;
        private Mediator mediator;
        
        public ReadButton(string buttonName, Mediator mediator)
        {
            this.buttonName = buttonName;
            this.mediator = mediator;
        }

        public event PropertyChangedEventHandler PropertyChanged = (sender, e) => { };

        public string ButtonName { get { return buttonName; } }

        public string ButtonText 
        { 
            get { return buttonText; } 
            set 
            {
                if (buttonName != value)
                {
                    buttonText = value;
                    PropertyChanged(this, new PropertyChangedEventArgs("Text changed"));
                }
            }
        }

        public void Push()
        {
            mediator.notify(this, "Push");
        }
    }
}
