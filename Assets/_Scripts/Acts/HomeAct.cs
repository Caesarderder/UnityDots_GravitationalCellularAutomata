using System.Threading.Tasks;
public class HomeAct : ActBase
{

    public override async Task OnLoad()
    {
        _=base.OnLoad();
        var uiManager=Manager<UIManager>.Inst;
        await uiManager.ShowUI<HomePanel>();
    }

    public override void OnLoaded()
    {
        base.OnLoaded();
    }

    public override void OnUnload()
    {
        base.OnUnload();
        Manager<UIManager>.Inst.DestroyUI<HomePanel>();
    }

    public override void OnUnloaded()
    {
        base.OnUnloaded();
    }
}
