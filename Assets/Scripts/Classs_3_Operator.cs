using UnityEngine;

/// <summary>
/// 課程 3 : 運算子
/// 補充 : Unity 欄位屬性 、 Unity 事件
/// </summary>
public class Classs_3_Operator : MonoBehaviour
{
    #region 基本欄位屬性
    // C# 變數 = 欄位 Field
    // 欄位屬性 field Attritube
    // [標題(標題文字)]:在屬性面板上顯示標題文字
    [Header("等級")]
    // [提示(提示文字)]:在屬性面板上顯示提示文字
    public int lv = 1;
    [Tooltip("這是角色移動速度 建議不超過")]
    public float moveSpeed = 2.5f;
    //[範圍(最小,最大)]
    [Range(1, 100)]
    public byte count = 10;
    //範圍不能使用在非數值類型上
    [Range(0, 10)]
    public string weapon = "匕首";
    // [文字範圍(最小行,最大行)]
    [TextArea(2, 5)]
    public string itemDescriprion = "這裡是道具描述";
    //多欄位屬性
    [Header("血量")]
    [Range(0, 999)]
    public int hp = 100;
    [Header("攻擊力")]
    [Range(0, 100)]
    public float attack = 30.5f;
    //[在屬性面板隱藏]:將公開變數隱藏
    [HideInInspector]
    public string password = "我是密碼";
    //[在屬性面板隱公開]:將私人變數公開
    [SerializeField]
    private float mp = 500f;
    #endregion

    //使用Unity的事件
    //1.必須在腳本後面加 : MonoBehaviour
    //2.使用關鍵字快捷完成事件
    //喚醒事件:播放遊戲後會執行的第一個事件,只執行一次
    private void Awake()
    {
        #region 基本輸出
        //將括號內的訊息輸出到Unity的console控制台面板
        //Ctrl+Shift+C開啟控制面板
        Debug.Log("HelloWorld"); //輸出文字
        Debug.Log(hp); //輸出變數數值
        Debug.Log("攻擊力" + attack); //字串與變數
        Debug.Log($"攻擊力:{attack}"); //$字串格式
        Debug.Log("攻擊力:{attack}"); //沒有$

        Debug.Log("<b>粗體</b>");
        Debug.Log("<color=orange>橘色</color>");
        Debug.Log("<color=#66aaff>藍色</color>");
        Debug.Log("<color=#6af>藍色</color>");
        #endregion

        #region 算術運算子
        Debug.Log("<color=#f93>--- 算術運算子 ---</color>");
        Debug.Log(10 + 3); //13
        Debug.Log(10 - 3); //7
        Debug.Log(10 * 3); //30
        Debug.Log(10 / 3); //3
        Debug.Log(10 % 3); //10 / 3 = 3...1 結果是1

        Debug.Log("<color=#f93>--- 算術運算子:區域變數 ---</color>");
        //區域變數:僅在此大括號內不用內存取(不需要修飾詞)
        float numberA = 10;
        float numberB = 3;

        Debug.Log(numberA + numberB);
        Debug.Log(numberA - numberB);
        Debug.Log(numberA * numberB);
        Debug.Log(numberA / numberB);
        Debug.Log(numberA % numberB);
        #endregion

        Debug.Log("<color=#f93>--- 比較運算子 ---</color>");

        int numberC = 100, numberD = 1;

        Debug.Log(numberC > numberD); // True
        Debug.Log(numberC < numberD); // False
        Debug.Log(numberC >= numberD); // True
        Debug.Log(numberC <= numberD); //False
        Debug.Log(numberC == numberD); //False
        Debug.Log(numberC != numberD); //True

    }

}
