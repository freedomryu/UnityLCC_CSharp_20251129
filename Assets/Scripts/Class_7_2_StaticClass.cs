using UnityEngine;

/// <summary>
///  靜態類別
///  靜態類別不能繼承 MonoBehaviour，不能放在unity的物件上
/// </summary>
public class Class_7_2_StaticClass 
{
    // 常數(靜態)
    // 常數是無法修改的 且需要預設值
    public const string playerName = "Furi";
    // 靜態可以修改 也可以不給予預設值
    public static string playerWeapon;

    // 靜態類別內只能有靜態成員
    public static int lv = 1;
    public static float speed => 500;

    public static void Run ()
    {

    }

}
