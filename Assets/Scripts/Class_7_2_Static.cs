using UnityEngine;
using UnityEngine.SceneManagement;

namespace furi
{
    public class Class_7_2_Static : MonoBehaviour
    {
        public int inventoryWater = 10;
        // 靜態變數：修飾詞後面加關鍵字 static
        // 靜態變數不顯示面板上
        public static int inventoryProp = 20;

        // 非靜態屬性
        public string skillMain => "火球術";
        // 靜態屬性
        public static string skillSecond => "治療盾";

        private float attack = 10;
        private static float mp = 100;

        public void Punch ()
        {
            Debug.Log("<color=#3f3>使用拳擊</color>");
            // 非靜態方法可以存取所有成員
            Debug.Log($"<color=#f9e>非靜態攻擊力：{attack}</color>");
            Debug.Log($"<color=#f9e>靜態魔力：{mp}</color>");
        }
        public static void Kick()
        {
            Debug.Log("<color=#3f3>使用踢擊</color>");
            // 靜態方法只能存取靜態成員
            // 由於attack是非靜態所以無法存取(導致錯誤)
            // Debug.Log($"<color=#f9e>非靜態攻擊力：{attack}</color>");
            Debug.Log($"<color=#f9e>靜態魔力：{mp}</color>");
        }

        private void Awake()
        {
            // inventoryWater = 7;
            // inventoryProp = 15;
            Debug.Log($"<color=#f31>藥水{inventoryWater}</color>");
            Debug.Log($"<color=#f31>道具{inventoryProp}</color>");
        }
        private void Start ()
        {
            // 在Unity內的差異
            // 場景切換時
            // 非靜態成員會被釋放(會還原為預設值)
            inventoryWater++; // 藥水加一
            Debug.Log($"<color=#f31>藥水{inventoryWater}</color>");
            inventoryProp++; // 道具加一
            Debug.Log($"<color=#f31>道具{inventoryProp}</color>");


        }
        private void Update()
        {
            // 在GAME場景按下1會重興載入場景
            // 如果按下數字一
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                SceneManager.LoadScene("課程_7_屬性與靜態");
            }
        }
    }
}
