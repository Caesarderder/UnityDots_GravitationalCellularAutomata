using System.Collections.Generic;

public enum ECharacterMapStatus
{
    Normal,
    Die,
}

public enum ECharacterAction
{
    None,
    DramaWithCharacter,
    GetItem,
    PutItem,

}

public class CharacterMapEnity
{
	#region Fileds 亻尔 女子
	public Cell Pos;
    public ECharacterMapStatus Status;
    public ECharacterAction Action;

	#endregion

	#region Methods
	#endregion
}
