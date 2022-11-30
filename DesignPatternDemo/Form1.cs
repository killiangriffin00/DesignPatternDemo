namespace DesignPatternDemo
{
    using System.ComponentModel;
    public partial class Form1 : Form
    {
        public Dictionary<string, ReadButton> buttons;
        public ShrekFileMediator mediator;

        public Form1()
        {
            InitializeComponent();
            buttons = new Dictionary<string, ReadButton>();
            mediator = new ShrekFileMediator();
            buttons[this.button1.Name] = new ReadButton(this.button1.Name, mediator);
            buttons[this.button2.Name] = new ReadButton(this.button2.Name, mediator);
            buttons[this.button3.Name] = new ReadButton(this.button3.Name, mediator);
            buttons[this.button4.Name] = new ReadButton(this.button4.Name, mediator);
            buttons[button1.Name].PropertyChanged += ButtonChangedEventHandler;
            buttons[button2.Name].PropertyChanged += ButtonChangedEventHandler;
            buttons[button3.Name].PropertyChanged += ButtonChangedEventHandler;
            buttons[button4.Name].PropertyChanged += ButtonChangedEventHandler;
        }

        private void ButtonChangedEventHandler(object sender, PropertyChangedEventArgs e)
        {
            ReadButton propertyChangedButton = (ReadButton)sender;
            if(button1.Name == propertyChangedButton.ButtonName)
            {
                button1.Text = propertyChangedButton.ButtonText;
            }
            if (button2.Name == propertyChangedButton.ButtonName)
            {
                button2.Text = propertyChangedButton.ButtonText;
            }
            if (button3.Name == propertyChangedButton.ButtonName)
            {
                button3.Text = propertyChangedButton.ButtonText;
            }
            if (button4.Name == propertyChangedButton.ButtonName)
            {
                button4.Text = propertyChangedButton.ButtonText;
            }
        }

        private void Button_OnClick(object sender, EventArgs e)
        {
            buttons[((Button)sender).Name].Push();
        }
    }
}