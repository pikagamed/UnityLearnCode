using UnityEngine;

[System.Serializable]
public class Dog 
{
    #region Variable Declare

    private string name = "";
    private float weight = 0F;
    private string type = "米克斯";
    private string sex = "";
    private string color = "";
    private int age = 0;

    #endregion

    public string Name
    {
        get
        {
            return name;
        }
    }

    #region Method Declare

    /// <summary>
    /// 建構子
    /// </summary>
    /// <param name="name"></param>
    /// <param name="weight"></param>
    /// <param name="type"></param>
    /// <param name="sex"></param>
    /// <param name="color"></param>
    /// <param name="age"></param>
    public Dog(string name, float weight, string type, string sex, string color, int age)
    {
        this.name = name;
        this.weight = weight;
        this.type = type;
        this.sex = sex;
        this.color = color;
        this.age = age;
    }

    /// <summary>
    /// 取得資訊
    /// </summary>
    public void GetInfo()
    {
        Debug.Log(this.name + " 品種：" + this.type + " 顏色：" + this.color);
    }

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
