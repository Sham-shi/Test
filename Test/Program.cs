using Lessons.Bridge.GameObjects;
using Lessons.Bridge.Renders;

var render2D = new Render2D();
var grass = new Grass(render2D);

grass.Draw();

grass.Render = new Render3D();

grass.Draw();