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

    public void Bark()
    {
        Debug.Log(name + "：汪汪");
    }

    #endregion
}
