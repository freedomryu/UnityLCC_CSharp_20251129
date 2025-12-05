
using System.Drawing;
using UnityEngine;

// 命名空間:
// 將類別分類,類似倉庫概念,不同倉庫可以有相同名稱類別
// 語法:namespace 命名空間名稱{內容}
namespace furi
{
    /// <summary>
    /// 選取陳述式 Selection Statement
    /// 1. if 判斷式
    /// 2. Switch 判斷式
    /// </summary>
    public class Class_5_Selection:MonoBehaviour
    {
        [SerializeField,Header("是否開門")]
        private bool isOpen;
        [SerializeField, Header("分數"),Range(0,100)]
        private int score = 100;

        private void Awake()
        {
            #region if判斷式基本陳述式用法
            // if 判斷式
            // if (布林值) {陳述式}
            if (true)
            {
                Debug.Log("當布林值為True執行這裡");
            }
            //快速完成 :　輸入if選取陳述式按tab或enter
            if (false)
            {
                Debug.Log("當布林值為False,不執行這裡且會有綠色蚯蚓");
            } 
            #endregion

        }
        private void Update()
        {
            Debug.Log("<color=#79f>更新事件</color>");
            
            if (isOpen)
            {
                Debug.Log("<color=#93f>已經開門</color>");
            }
            else
            {
                Debug.Log("<color=#93f>已經關門</color>");
            }

            if (score >= 60)
            {
                Debug.Log("<color=#3f3>你及格了</color>");
            }
            else
            {
                Debug.Log("<color=#3f3>你不及格</color>");
            }
        }
    }

}

