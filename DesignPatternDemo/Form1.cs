namespace DesignPatternDemo
{
    using System.ComponentModel;
    public partial class Form1 : Form
    {
        public Dictionary<Button, ShrekButton> buttons;
        public ShrekButtonMediator mediator;

        public Form1()
        {
            InitializeComponent();
            buttons = new Dictionary<Button, ShrekButton>();
            mediator = new ShrekButtonMediator();
            buttons[this.button1] = new ShrekButton(this.button1.Name, mediator);
            buttons[this.button2] = new ShrekButton(this.button2.Name, mediator);
            buttons[this.button3] = new ShrekButton(this.button3.Name, mediator);
            buttons[this.button4] = new ShrekButton(this.button4.Name, mediator);
            foreach (ShrekButton button in buttons.Values)
            {
                button.PropertyChanged += ButtonChangedEventHandler;
            }
        }

        private void ButtonChangedEventHandler(object sender, PropertyChangedEventArgs e)
        {
            ShrekButton propertyChangedButton = (ShrekButton)sender;
            foreach(Button button in buttons.Keys)
            {
                if(buttons[button] == propertyChangedButton)
                {
                    button.Text = propertyChangedButton.ButtonText;
                    break;
                }
            }
        }

        private void Button_OnClick(object sender, EventArgs e)
        {
            buttons[((Button)sender)].Push();
        }
    }
}