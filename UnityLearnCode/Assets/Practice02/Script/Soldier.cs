using UnityEngine;

[System.Serializable]
public class Soldier
{
    #region 欄位宣告
    public int exp;
    public int level;
    #endregion

    #region 方法宣告

    /// <summary>
    /// 設定經驗值，計算經驗值為等級×10
    /// </summary>
    /// <returns>傳回計算後經驗值</returns>
    public int GetExp()
    {
        exp = level * 10;
        return level * 10;
    }

    /// <summary>
    /// 設定經驗值
    /// </summary>
    /// <param name="Exp">取得的經驗值</param>
    public void SetExp(int Exp)
    {
        exp = Exp;
    }

    #endregion
}
