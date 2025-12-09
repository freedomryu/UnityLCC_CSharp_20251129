using UnityEngine;
namespace furi
{
    public class Classs_6_2_Array:MonoBehaviour
    {
        // 不使用陣列的寫法
        // 皮卡丘、小火龍、卡比獸
        public string card1 = "皮卡丘", card2 = "小火龍", card3 = "卡比獸";

        // 使用陣列的寫法：
        // 陣列：用來儲存多筆相同類型資料
        // 第一種：不指定值，透過 Unity 版面輸入
        // 修飾詞 資料類型[] 陣列名稱；
        public string[] cards;
        // 第二種：直接定義陣列的數量
        // 定義一個排組1，可以放五卡牌
        public string[] deck1 = new string[5];
        // 第三種：直接定義陣列的值
        public string [] deck2 = {"急凍鳥","賭霞","寶石海星"};
        // 二維陣列
        public string[,] inventory = { { "紅色藥水", "藍色藥水" }, { "炸彈", "金幣" } };

        private void Start()
        {
            #region 一維陣列
            // 存取陣列Set Get
            // Get 取得陣列資料
            // 陣列名稱[編號]
            Debug.Log($"<color=#f32>cards的第三張卡片：{cards[2]}");
            // 超出範圍會導致錯誤

            // Set 設定陣列資料
            // 陣列名稱[編號] 指定 值;
            // 將寶石海星定義為傑尼龜
            deck2[2] = "傑尼龜";
            Debug.Log($"<color=#f39>Deck2 的第三張卡片：{deck2[2]}");
            #endregion

            // 存取二維陣列
            Debug.Log($"<color=#3f3>編號[0,1]道具：{inventory[0,1]}</color>");

            inventory[1, 1]="好傷藥水";
            Debug.Log($"<color=#3f3>編號[1,1]道具：{inventory[1, 1]}</color>");
        }
    }

}
