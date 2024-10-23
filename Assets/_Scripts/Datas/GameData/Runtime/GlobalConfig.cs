using UniRx;
using UnityEngine;


[CreateAssetMenu(fileName = "GlobalConfig", menuName = "Scriptable Objects/GlobalConfig")]
public class GlobalConfig : ScriptableObject
{
    #region LLM
    [Header("=====LLM--settings=====")]
    public ELLM LLM;
    public string ApiKey;
    public string lan="ÖÐÎÄ";

    [Header("=====LLM--ModuleSelect=====")]
    public string GLMUrl= "https://open.bigmodel.cn/api/paas/v3/model-api/{0}/{1}";
    public int GLMModleSelectIndex;
    public string[] GLMModleTypes={
        "glm-4-plus","glm-4-052","glm-4","glm-4-air","glm-4-airx","glm-4-long","glm-4-flashx","glm-4-flash"  
    };
    public string GLMApiKey;
    #endregion

    #region Stage
    [Header("=====Stage=====")]
    public int MaxStageSteps=3;
    public int StageMapSlelectCount=3;
    #endregion

}

public enum ELLM
{
    None=-1,
    ChatGPT,
    ChatGLM
}
