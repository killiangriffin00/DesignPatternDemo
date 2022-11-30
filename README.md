# Design Pattern Demo

Two design patterns will be the target of this demo. The application gets text from a text file when one of the buttons is clicked. The Singleton Design pattern will be expressed with it being necessary to only have one instance of a file accessor that the buttons can use. The Mediator design pattern is expressed in defining the ShrekFileMediator as the mechanism for communication between the file accessor and the button.

A potential expansion on this is by making another mediator to present the text recieved from the file accessor in a text box instead of on the buttons. Then the functionality from the new mediator can be easily placed in the button class.