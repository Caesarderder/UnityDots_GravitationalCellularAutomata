using System;
using UniRx;
using UnityEngine;
using UnityEngine.UI;
public class HomePanel : ViewBase
{
    [SerializeField]
    Button 
        btn_enterGame,
        btn_bag,
        btn_producer,
        btn_LLMTest
        ;

    protected Type _vmType=>typeof(HomePanelVM);
    HomePanelVM VM=>_vm as HomePanelVM;
    

#region Unity

    private void Start()
    {
        btn_enterGame.OnClickAsObservable().Subscribe(_=>OnEnterGame()).AddTo(_disposables);
        btn_bag.OnClickAsObservable().Subscribe(_=>OnOpenBag()).AddTo(_disposables);
        btn_producer.OnClickAsObservable().Subscribe(_=>OnOpenProducer()).AddTo(_disposables);
        btn_LLMTest.OnClickAsObservable().Subscribe(_=>OnEnterLLMTestAct()).AddTo(_disposables);
    }

    private void Update()
    {
    }

    public override void Destroy()
    {
        base.Destroy();
    }

    public override void Hide()
    {
        base.Hide();
    }

    public override void Load()
    {
        base.Load();
    }

    public override void Show()
    {
        base.Show();
    }
    #endregion

    
    
    private async void OnEnterGame()
    {
        await Manager<ActManager>.Inst.LoadAct("StageAct");
//        GContext.Container.ResloveSingleton<UIManager>().DestroyUI<HomeUI>();
    }
    private void OnOpenBag()
    {

    }
    private void OnOpenProducer()
    {

    }

    private async void OnEnterLLMTestAct()
    {
        await Manager<ActManager>.Inst.LoadAct("LLMTestAct");
    }


}
