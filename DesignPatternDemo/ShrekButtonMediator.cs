using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDemo
{
    public class ShrekButtonMediator : Mediator
    {
        private FileAccessor shrek2Script;
        private Dictionary<string, ShrekButton> buttons;

        public ShrekButtonMediator()
        {
            this.shrek2Script = FileAccessor.GetInstance();
            buttons = new Dictionary<string, ShrekButton>();
        }

        public void notify(object sender, string e)
        {
            if(sender is ShrekButton)
            {
                ShrekButton button = (ShrekButton)sender;
                if (!buttons.ContainsKey(button.ButtonName))
                {
                    buttons[button.ButtonName] = button;
                }
                buttons[button.ButtonName].ButtonText = shrek2Script.GetLineFromFile();
            }
        }
    }
}
