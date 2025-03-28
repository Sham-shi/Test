
namespace Lessons.Adapter;

public class Adapter : Target
{
    private SpecificApi specificApi;
    public Adapter()
    {
        specificApi = new SpecificApi();
    }

    public override void Request()
    {
        specificApi.SpecificRequest();
    }
}
