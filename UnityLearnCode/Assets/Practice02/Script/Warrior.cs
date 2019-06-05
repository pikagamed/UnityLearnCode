using UnityEngine;

[System.Serializable]
public class Warrior
{
    #region 欄位宣告
    public int exp;
    public int level;
    #endregion

    public int Exp
    {
        get
        {
            return level * 10;
        }
        set
        {
            exp = value;
        }
    }
}
