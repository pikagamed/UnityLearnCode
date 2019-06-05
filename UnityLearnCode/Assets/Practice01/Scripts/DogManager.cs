using UnityEngine;

public class DogManager : MonoBehaviour
{
    #region Instant
    public Dog Dog1 = new Dog();
    public Dog Dog2 = new Dog();
    #endregion

    #region Event

    private void Start()
    {
        Dog1.name = "小白";
        Dog1.weight = 18.6F;
        Dog1.type = "秋田犬";
        Dog1.sex = "雌";
        Dog1.color = "白";
        Dog1.age = 3;

        Dog2.name = "波奇";
        Dog2.weight = 22.5F;
        Dog2.type = "柴犬";
        Dog2.sex = "雄";
        Dog2.color = "黑";
        Dog2.age = 5;

        Debug.Log(Dog1.name + " 品種：" + Dog1.type + " 顏色：" + Dog1.color);
        Debug.Log(Dog2.name + " 品種：" + Dog2.type + " 顏色：" + Dog2.color);

        Dog1.Bark();
        Dog2.Bark();

        Debug.Log(Dog1.name + "相當於人類" + Dog1.TurnToHumanAge() + "歲");
        Debug.Log(Dog2.name + "相當於人類" + Dog2.TurnToHumanAge() + "歲");

        Dog1.Eat("西莎");
        Dog2.Eat("寶路", 3);
    }

    #endregion

}