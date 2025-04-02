using Lessons.Bridge.Renders;

namespace Lessons.Bridge.GameObjects;

public class Stone : GameObject
{
    public Stone(IRender render) : base(render)
    {

    }
    public override void Draw()
    {
        Render.Render();
    }
}
