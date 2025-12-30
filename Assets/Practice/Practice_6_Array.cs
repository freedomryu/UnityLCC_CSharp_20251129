using UnityEngine;

public class Practice_6_Array :MonoBehaviour
{
    public string[,,] character =
    {
        {{"大岩蛇","超夢" },{ "皮卡丘","波加曼"},{"雷丘","水伊布" } },
        {{"緞帶肥肥","藍水靈" },{ "泡泡魚","蒙面河豚"},{"木妖","菇菇寶貝" }},
        {{"蓋倫","好運姐" },{ "凱爾","雷玟"},{"艾希","李星" } }
    };

    private void Start()
    {
        Debug.Log($"<color=#ffcccc>{character[0,1,0]}</color>");
        Debug.Log($"<color=#ff9966>{character[1, 2, 1]}</color>");
        Debug.Log($"<color=#00cc44>{character[2, 0, 0]}</color>");
        Debug.Log($"<color=#00cc44>{character[2, 0, 0]}</color>");
    }
}
