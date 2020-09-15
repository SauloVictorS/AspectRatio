# AspectRatio
An easy way to resize a form and keep the aspect ratio of its components.
To keep the aspect ratio of a form, you will need the component to be resized and an anchor that will return the new size value.
The anchor have to be a panel that will be resizes along with the window. Or even the window itself (i didn't recommend this, because if the your component is smaller then te window it won't resize correctly). So always put your component inside of a panel that rezises along with the window.

To activate the code, use the event SizeChanged on the anchor panel. Not on the component that will be resized.

The anchor panel must be docked as a Fill
The ProportionalPanel is anchored as Top Left

![Resizing Form](https://doc-08-7g-docs.googleusercontent.com/docs/securesc/it1sunt4ufvfdspnmjptg8vf3olfvpgq/f7eooov3gdp9kun02hh5rkidrlorhhl5/1600135050000/07625659027684392502/07625659027684392502/1fQbZutYYOddoiixiAjXSL1SVtiOrXbH9?e=)
