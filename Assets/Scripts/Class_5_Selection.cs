
using System.Drawing;
using System.Runtime.CompilerServices;
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
        [SerializeField, Header("武器")]
        private string weapon;
        [SerializeField, Header("血量"),Range(0,100)]
        private float hp = 100;
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
            #region 判斷式if
            if (isOpen)
            {
                Debug.Log("<color=#93f>已經開門</color>");
            }
            else
            {
                Debug.Log("<color=#93f>已經關門</color>");
            }
            // 比較運算子、邏輯運算子結果為布林值
            // if會在最上方 else會在最下方 中間可以多個 else if
            if (score >= 60)
            {
                Debug.Log("<color=#f96>你及格了</color>");
            }
            else if (score > 20)
            {
                Debug.Log("<color=#f9a>你不及格,但是可以補考補救</color>");
            }
            else
            {
                Debug.Log("<color=#3f3>你不及格</color>");
            }
            #endregion

            #region 判斷式switch
            // switch 判斷式
            // switch (要判斷的值) {陳述式}
            switch (weapon)
            {
                // case 值:
                // 當判斷職等於會執行這裡
                // break; 跳出判斷是
                // 如果武器等語小刀,攻擊力等於 20
                // 蝴蝶刀與小刀一樣
                case "蝴蝶刀":
                case "小刀":
                    Debug.Log("<color=#ff3>攻擊力:20</color>");
                    break;
                case "美工刀":
                    Debug.Log("<color=#ff3>攻擊力:10</color>");
                    break;
                case "屠龍刀":
                    Debug.Log("<color=#ff3>攻擊力:436</color>");
                    break;
                // 當weapon的值不等於上面所有值執行
                default:
                    Debug.Log("<color=#ff3>這是不能使用的武器</color>");
                    break;

            }
            #endregion

            #region 練習區
            switch (hp)
            {
                case >= 80:
                    Debug.Log("<color=#07e82c>血量安全</color>");
                    break;

                case >= 60:
                    Debug.Log("<color=#e7f7be>健康狀態有狀況</color>");
                    break;

                case >= 40:
                    Debug.Log("<color=#f7c8a3>警告，快喝水</color>");
                    break;

                case >= 1:
                    Debug.Log("<color=#ff0808>快死掉</color>");
                    break;

                default:
                    Debug.Log("<color=#ff0808>你已經死了</color>");
                    break;
            } 
            #endregion
        }
    }

}

