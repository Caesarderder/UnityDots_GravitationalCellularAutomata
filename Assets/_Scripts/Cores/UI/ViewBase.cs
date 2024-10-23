using System;
using UniRx;
using UnityEngine;

public class ViewBase: MonoBehaviour
{
	#region Fileds 亻尔 女子
	protected CompositeDisposable _disposables=new();
	public string Name=>this.GetType().Name;
	protected Type _vmType=>_vm.GetType();
	protected ViewModule _vm;
	#endregion

	#region Methods
	public virtual void Load() {
		EventAggregator.Publish(new SUILoad { Type = Name});
		_vm= ViewModule.Resolve(_vmType) ;
	}
	public virtual void Show() 
	{
		EventAggregator.Publish(new SUILoaded { Type = Name});
        Debug.Log($"<color=green>UI:   {Name.ToString()}   Loaded</color>");
    }
	public virtual void Hide() { EventAggregator.Publish(new SUIUnload { Type = Name}); }
	public virtual void Destroy() 
	{
		_disposables.Dispose();
		ViewModule.Unregister(_vm.GetType());
		EventAggregator.Publish(new SUIUnloaded{ Type = Name});
        Debug.Log($"<color=yellow>UI:   {Name.ToString()}   UnLoaded</color>");
        Destroy(gameObject);

	}

	#endregion
}
