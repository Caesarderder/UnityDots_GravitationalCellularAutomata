using System.Threading.Tasks;
using UnityEngine.AddressableAssets;
using UnityEngine;
using Newtonsoft.Json;

public class TableManager 
{
    public TableManager()
    {
    }
    public GlobalConfig GlobalConfig { get; private set; }
    public TestConfig TestConfig { get; private set; }

    #region Sheet
    public WorldConfig_SO WorldConfig{ get; private set; }
    public PlaceConfig_SO PlaceConfig{ get; private set; }
    public CharacterConfig_SO CharacterConfig{ get; private set; }
    #endregion

    public async Task Init()
    {
        GlobalConfig=await Addressables.LoadAssetAsync<GlobalConfig>(typeof(GlobalConfig).ToString()).Task;
        TestConfig=await Addressables.LoadAssetAsync<TestConfig>(typeof(TestConfig).ToString()).Task;

        WorldConfig = await Addressables.LoadAssetAsync<WorldConfig_SO>(typeof(WorldConfig).ToString()).Task;
        WorldConfig.Init();

        PlaceConfig = await Addressables.LoadAssetAsync<PlaceConfig_SO>(typeof(PlaceConfig).ToString()).Task;
        PlaceConfig.Init();

        CharacterConfig = await Addressables.LoadAssetAsync<CharacterConfig_SO>(typeof(CharacterConfig).ToString()).Task;
        CharacterConfig.Init();
    }

}
