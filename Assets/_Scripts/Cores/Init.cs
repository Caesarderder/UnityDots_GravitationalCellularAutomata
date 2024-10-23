using Newtonsoft.Json;
using System;
using System.Threading.Tasks;
using UnityEngine;
//using ZhipuApi.Models.RequestModels;
//using ZhipuApi;
//using ZhipuApi.Modules;

public class Init : MonoBehaviour
{
    #region Methods
    public async void Awake()
    {
        await CaontainerInit();
        LoadMainAct();
        Destroy(gameObject);
    }

    private async Task CaontainerInit()
    {
        #region Register      
        var tableManager = new TableManager();
        Debug.Log(Time.time);
        await tableManager.Init();
        Debug.Log(Time.time);

        var uiManager=new UIManager();
        await uiManager.Init();
        Debug.Log(Time.time);

        GContext.RegisterSingleton<TableManager>(tableManager);
        GContext.RegisterSingleton<UIManager>(uiManager);
        GContext.RegisterSingleton<ActManager>();

        GContext.RegisterSingleton<StageDataProvider>();


        #endregion
    }

    private void LoadMainAct()
    {
        _=Manager<ActManager>.Inst.LoadAct("HomeAct");
    }

    #endregion
}
