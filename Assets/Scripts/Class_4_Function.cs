using Unity.Mathematics;
using UnityEngine;
/// <summary>
/// 方法
/// 中文 : 方法 函式 函數 功能
/// 英文 : function method(Unity)
/// </summary>
public class Class_4_Function : MonoBehaviour
{
    private void Awake()
    {
        #region 方法基本語法與參數呼叫練習
        //呼叫方法
        //方法名稱();
        fristFunction();
        //呼叫有參數的方法 : 小括號內要放引數
        //UseSkill() : //錯誤少了引數
        UseSkill("火球術", 30);
        UseSkill("冰錐術", 50);
        //呼叫預設參數方法 : 可以不用填
        SpawnEnemy();
        SpawnEnemy("史萊姆");

        Fire(700);
        Fire(500, "保齡球");

        //買紅水50個
        BuyItem();
        //買紅水31個
        BuyItem(count: 31);
        //買綠水43個
        BuyItem("綠水", 43);
        //買綠水76個
        BuyItem("綠水", 76);
        #endregion

        //呼叫有回傳的方法
        //第一種:把結果放進區域變數內
        float number9 = Square(9);
        Debug.Log($"<color=#a33>9 的平方{number9}</color>");
        //第二種:把回傳方法當作傳回類型使用
        Debug.Log($"<color=#a33>7 的平方{Square(7)}</color>");

        Debug.Log(60/Square(1.68f));

        Debug.Log($"<color=#a33>BMI={BMI(1.68f,60)}</color>");
        
        Debug.Log($"<color=#a33>BMI={BMI(1.70f,91)}</color>");
        Move();
        Move(50.5f);
    }
    // 框選要整理的程式 > Ctrl+K+S > #region 快速完成
    #region 方法基本語法與參數
    //方法
    //包含一系列程式區塊
    //方法語法:
    //修飾詞 傳回資料類型 方法名稱() {程式區塊}
    //方法命名習慣 : Unity 習慣使用大寫開頭
    //void 無傳回 : 使用此方法不會有回傳資料
    private void fristFunction()
    {
        Debug.Log("第一個方法");
    }

    //參數語法 : 與區域變數相同
    private void UseSkill(string skill, float cost)
    {
        Debug.Log($"<color=#f93>施放技能:{skill}</color>");
        Debug.Log($"<color=#f93>施放消耗:{cost}</color>");
    }
    private void SpawnEnemy(string enemy = "哥布林")
    {
        Debug.Log($"<color=#f33>生成敵人{enemy}</color>");
    }

    /// <summary>
    /// 發射方法
    /// </summary>
    /// <param name="speed">發射速度</param>
    /// <param name="fire">發射的物件</param>
    private void Fire(int speed, string fire = "子彈")
    {
        Debug.Log($"<color=#66f>發射物件:{fire},速度{speed}</color>");
    }

    /// <summary>
    /// 購買道具
    /// </summary>
    /// <param name="item">道具名稱</param>
    /// <param name="count">道具數量</param>
    private void BuyItem(string item = "紅水", int count = 50)
    {
        Debug.Log($"<color=#3f3>購買商品:{item},數量{count}</color>");
    }
    #endregion

    #region 傳回
    //傳回方法 : 傳回類型不是void,呼叫該方法會獲得結果
    //傳回方法必須在{}內使用return關鍵字將結果回傳
    /// <summary>
    /// 平方
    /// </summary>
    /// <param name="number">要平方的數字</param>
    /// <returns>數字的平方</returns>
    private float Square(float number)
    {
        return number * number;
    }

    /// <summary>
    /// BMI計算 : 體重/身高*2 
    /// </summary>
    /// <param name="height">身高</param>
    /// <param name="weight">體重</param>
    /// <returns></returns>
    private float BMI(float height, float weight)
    {
        return weight / math.pow(height, 2);
    }
    #endregion

    //方法多載 function overload
    //參數的類型或數量不同
    //零個參數
    /// <summary>
    /// 移動
    /// </summary>
    private void Move()
    {
        Debug.Log("<color=#19f>移動中</color>");
    }
    /// <summary>
    /// 移動還有指定速度
    /// </summary>
    /// <param name="speed"></param>
    private void Move(float speed)
    {
        Debug.Log($"<color=#19f>移動中,速度{speed}</color>");
    }
}
