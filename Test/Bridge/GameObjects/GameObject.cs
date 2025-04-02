using Lessons.Bridge.Renders;

namespace Lessons.Bridge.GameObjects;

public abstract class GameObject
{
    public IRender Render { get; set; }
    public GameObject(IRender render)
    {
        Render = render;
    }
    public abstract void Draw();
}
