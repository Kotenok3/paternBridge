using paternBridge;

var widows = new GraphicsElement(new WindowsGraphics());
var mac = new GraphicsElement(new MacGraphics());
widows.DrawButton();
widows.DrawTextField("Hello");

mac.DrawTextField("Hello windows");