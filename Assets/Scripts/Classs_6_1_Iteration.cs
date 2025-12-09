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
        }
    }
}

