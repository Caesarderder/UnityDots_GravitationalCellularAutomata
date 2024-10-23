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

//        var clientV4 = new ClientV4(tableManager.GlobalConfig.GLMApiKey);
//        var response = clientV4.chat.Completion(
//            new TextRequestBase()
//                .SetModel("glm-4")
//                .SetMessages(new[] { new MessageItem("user", "ÄãºÃ£¬ÄãÊÇË­£¿") })
//                .SetTemperature(0.7)
//                .SetTopP(0.7)
//        );
//
//        Console.WriteLine(JsonConvert.SerializeObject("¹þ¹þ¹þ¹þ¹þ¹þ   "+response));

        #endregion
    }

    private void LoadMainAct()
    {
        _=Manager<ActManager>.Inst.LoadAct("HomeAct");
    }

    #endregion
}
