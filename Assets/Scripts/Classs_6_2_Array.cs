using UnityEngine;
namespace furi
{
    public class Classs_6_2_Array:MonoBehaviour
    {
        #region 一~三維陣列
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
        public string[] deck2 = { "急凍鳥", "賭霞", "寶石海星" };
        // 二維陣列
        public string[,] inventory = { { "紅色藥水", "藍色藥水" }, { "炸彈", "金幣" } };
        // 三圍陣列
        public string[,,] shop =
        {
            // 第一頁
            {{"小刀","美工刀"},{"武士刀","屠龍刀" } },
            // 第二頁
            {{"精靈球","高級球"},{"大師球","巢穴球" } }
        }; 
        #endregion

        private int[][] numbers = new int[2][];

        private int[][,] count = new int[2][,];
        
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

            #region 二維和三維
            // 存取二維陣列
            Debug.Log($"<color=#3f3>編號[0,1]道具：{inventory[0, 1]}</color>");

            inventory[1, 1] = "好傷藥水";
            Debug.Log($"<color=#3f3>編號[1,1]道具：{inventory[1, 1]}</color>");

            // 存取三維陣列
            // 取得屠龍刀
            Debug.Log($"<color=#f3d>第一頁第二排第二個：{shop[0, 1, 1]}</color>");

            // 設定高級球為超級球
            Debug.Log($"<color=#f3d>第二頁第一排第二個：{shop[1, 0, 1]}</color>");
            shop[1, 0, 1] = "超級球";
            Debug.Log($"<color=#f3d>第二頁第一排第二個：{shop[1, 0, 1]}</color>");
            #endregion

            #region 陣列長度與維度
            // 獲得陣列的長度和維度
            // 一維~多維度陣列長度：陣列名稱.Length
            Debug.Log($"<color=#f93>一維牌組2的長度：{deck2.Length}</color>");
            Debug.Log($"<color=#f93>二維道具的長度：{inventory.Length}</color>");
            Debug.Log($"<color=#f93>三維商品的長度：{shop.Length}</color>");
            // 陣列維度：陣列名稱.Rank
            Debug.Log($"<color=#f93>一維牌組2的長度：{deck2.Rank}</color>");
            Debug.Log($"<color=#f93>二維道具的長度：{inventory.Rank}</color>");
            Debug.Log($"<color=#f93>三維商品的長度：{shop.Rank}</color>");
            #endregion
            numbers[0]= new int[] {1,3,5};
            numbers[1] = new int[] { 9, 8};

            

            // 取得數字 3 和 9 
            Debug.Log($"<color=#3ff>不規則陣列數字陣列 3：{numbers[0][1]}");
            Debug.Log($"<color=#3ff>不規則陣列數字陣列 9：{numbers[1][0]}");

            // 將 8 改成 6
            numbers[1][1] = 6;
            Debug.Log($"<color=#3ff>不規則陣列數字陣列 8 改成 6 ：{numbers[1][1]}");

            // 不規則陣列：包含多維陣列
            count[0] = new int[,] { { 1, 1 }, { 1, 1 } };
            count[1] = new int[,] { { 2, 2, 2 }, { 2, 2, 2 } };
            Debug.Log($"<color=#3ff>couunt 的第二列的[0,0] ：{count[1][0,0]}");

        }
    }

}
