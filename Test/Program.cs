using Lessons.Composite;

var settingsPanel = new SettingsPanel();
var colorPanel = new ColorPanel();
var symbol1 = new Symbol1();

var topPanel = new TopPanel();
var symbolMenu = new SymbolMenu();

topPanel.Add(settingsPanel);
topPanel.Add(colorPanel);

symbolMenu.Add(symbol1);

var  window = new Window();

window.Add(topPanel);
window.Add(symbolMenu);

window.Display();
