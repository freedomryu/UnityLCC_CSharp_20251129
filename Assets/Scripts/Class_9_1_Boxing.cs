using furi.Tool;
using UnityEngine;
namespace furi
{
    /// <summary>
    /// 裝箱 Boxing 拆箱 Unboxing
    /// </summary>
    public class Class_9_1_Boxing:MonoBehaviour 
    {
        // 實質型別的資料類型
        // 結構、列舉、整數、浮點數、布林值、字元
        // 實質型別的資料會儲存在 Stack 記憶體內
        private int number = 100;
        // 參考型別資料類型
        // 物件、類別、字串
        // 物品資料為參考型別
        private object box;

        private object boxNumber = 50;
        private int count;

        private void Awake()
        {
            // 裝箱 Boxing 
            // 將實質型別資料放到參考型別資料
            box = number;
            LogSystem.LogWithColor(box.ToString(),"#f33");

            // 拆箱 Unboxing 
            // 將參考型別資料放到實質型別資料內
            // 在前方添加 (要轉換的資料類型)
            count = (int)boxNumber;
            LogSystem.LogWithColor(count.ToString(), "#f33");


        }

    }
}
