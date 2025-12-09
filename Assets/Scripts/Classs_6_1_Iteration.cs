using UnityEngine;

namespace furi
{
    /// <summary>
    ///  反覆運算式 : 迴圈
    ///  for foreach do 與 while 
    /// </summary>
    public class Classs_6_1_Iteration : MonoBehaviour
    {
        private void Awake()
        {
            #region while,do與for迴圈基本使用
            // 迴圈請在一次事件內使用 Awake Start
            // while 迴圈 : 當布林值為True 時會持續進行
            // while (布林值) {程式區塊}
            // 無限迴圈 : 布林值一直是 true
            // 宣告區域變數 i 為 0
            int i = 0;
            // 當i < 7 就執行
            i = 7;
            while (i < 7)
            {
                Debug.Log($"<color=#f33>while 迴圈, i : {i}</color>");
                // i = i + 1
                i++;
            }
            int j = 0;
            j = 7;
            do
            {
                Debug.Log($"<color=#f33>do 迴圈, j : {j}</color>");
                j++;
            }
            while (j < 7);
            // for 迴圈:
            // for (初始值 ; 布林值 ; ) {程式區塊}
            for (int k = 0; k < 7; k++)
            {
                Debug.Log($"<color=#f79>do 迴圈, k : {k}</color>");
            }
            #endregion

            // foreach 迴圈
            // 資料結構 : 陣列、清單等等...
            // foreach (資料類型 資料名稱 in 資料結構) {程式區塊}
            // 字串就一種資料結構，用來存放 char 的陣列
            string dialougue = "嗨，你好，我是 NPC~";
            // foreach 迴圈將抓出 dialogue 的每一個字並存放在區域變數 text 內
            // var 無類型
            foreach (var text in dialougue)
            {
                Debug.Log($"<color=#f63>{text}</color>");  
            }
        }
    }
}

