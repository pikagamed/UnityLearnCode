using UnityEngine;

public class Dog 
{
    #region Variable Declare

    public string name = "";
    public float weight = 0F;
    public string type = "米克斯";
    public string sex = "";
    public string color = "";
    public int age = 0;

    #endregion

    #region Method Declare

    /// <summary>
    /// 引導狗做出叫動作之方法
    /// </summary>
    public void Bark()
    {
        Debug.Log(name + "：汪汪!!!");
    }

    /// <summary>
    /// 轉換狗年齡之方法
    /// </summary>
    /// <returns>狗年齡×7</returns>
    public int TurnToHumanAge()
    {
        return age * 7;
    }

    /// <summary>
    /// 提示狗進食的訊息(速度)
    /// </summary>
    /// <param name="food">輸入食物</param>
    /// <param name="speed">輸入速度、預設值為慢</param>
    public void Eat(string food, string speed = "慢")
    {
        Debug.Log(name + "正在吃" + food + "，速度：" + speed);
    }

    /// <summary>
    /// 提示狗進食的訊息(份量)
    /// </summary>
    /// <param name="food">輸入食物</param>
    /// <param name="meal">輸入份量</param>
    public void Eat(string food, int meal)
    {
        Debug.Log(name + "正在吃" + food + "，份量：" + meal);
    }

    #endregion
}
