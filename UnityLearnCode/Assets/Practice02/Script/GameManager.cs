using UnityEngine;

public class GameManager : MonoBehaviour
{

    public Soldier SoldierA = new Soldier();
    public Warrior WarriorA = new Warrior();

    public void Start()
    {
        SoldierA.level = 45;
        Debug.Log(" 士兵經驗值 - 取得： " + SoldierA.GetExp());

        SoldierA.SetExp(100);
        Debug.Log(" 士兵經驗值 - 設定： " + SoldierA.exp);

        WarriorA.level = 50;
        Debug.Log(" 戰士經驗值 - 取得： " + WarriorA.Exp);

        WarriorA.Exp = 777;
        Debug.Log(" 戰士經驗值 - 取得： " + WarriorA.Exp);
    }

}
