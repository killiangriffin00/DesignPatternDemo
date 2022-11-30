using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDemo
{
    public class ShrekFileMediator : Mediator
    {
        private FileAccessor shrek2Script;
        private Dictionary<string, ReadButton> buttons;

        public ShrekFileMediator()
        {
            this.shrek2Script = FileAccessor.GetInstance();
            buttons = new Dictionary<string, ReadButton>();
        }

        public void notify(object sender, string e)
        {
            if(sender is ReadButton)
            {
                ReadButton button = (ReadButton)sender;
                if (!buttons.ContainsKey(button.ButtonName))
                {
                    buttons[button.ButtonName] = button;
                }
                buttons[button.ButtonName].ButtonText = shrek2Script.GetLineFromFile();
            }
        }
    }
}
