using UnityEngine;

public class StageData 
{
	public int CurStep;
	
}

public class StageDataProvider
{
	#region Fileds 亻尔 女子
	public StageData Data;

	#endregion

	#region Methods
	public StageDataProvider()
	{
		Load();
	}
    private void Load()
    {
        Data = DataFabUtil.LocalLoad<StageData>(nameof(StageData));
        if (Data == null)
            Data = new StageData();
    }
    private void Save()
    {
        DataFabUtil.LocalSave(nameof(StageData), Data);

    }



    public void EnterStage()
    {

    }



	#endregion
}
