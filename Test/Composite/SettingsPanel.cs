
namespace Lessons.Composite;

public class SettingsPanel : Component
{
    public List<Component> components;

    public SettingsPanel()
    {
        components = new List<Component>();
    }
    public override void Add(Component component)
    {
        components.Add(component);
    }

    public override void Display()
    {
        for (int i = 0; i < components.Count; i++)
        {
            components[i].Display();
        }
    }

    public override void Remove(Component component)
    {
        components.Remove(component);
    }
}
