using Lessons.Bridge.Renders;

namespace Lessons.Bridge.GameObjects;

public class Grass : GameObject
{
    public Grass(IRender render) : base(render)
    {

    }
    public override void Draw()
    {
        Render.Render();
    }
}
