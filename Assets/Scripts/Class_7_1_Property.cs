using UnityEngine;
namespace furi
{
    /// <summary>
    /// 屬性 Property
    /// </summary>
    public class Class_7_1_Property : MonoBehaviour 
    {
        #region 認識屬性 Property
        // 公開變數：可以讓外部讀取寫入
        public float moveSpeed = 3.5f;
        // 私人變數：不允許讓外部讀取寫入
        private float turnSpeed = 12.7f;
        // 公開屬性：允許存取
        public float runSpeed { get; set; }
        // 私人屬性：不允許存取
        private float sprintSpeed { get; set; }
        // 公開屬性：只有get代表唯獨(只能讀取不能寫入)
        public float jumpSpeed { get; }
        // prop + tab
        // 有預設屬性值
        public byte lv { get; set; } = 1;
        #endregion
        //屬性簡寫
        public float hp { get; set; } = 100;

        // 屬性標準寫法
        // _mp 用來裝屬性 mp值的容器
        private float _mp = 50;
        // 屬性是給予外部存取權限的窗口
        public float mp
        {
            get
            {
                return _mp;
            }
            set
            {
                _mp = value;
            }
        }
        // 取得屬性簡寫
        // 唯獨屬性 防禦值是30
        public int defence { get; } = 30;
        // 唯獨屬性 攻擊值是50
        public int attack => 50;

        private void Start()
        {
            Debug.Log($"<color=#77f>魔力：{mp}</color>");
            mp = 500;
            Debug.Log($"<color=#77f>魔力：{mp}</color>");
        }
        private void Awake()
        {
            Debug.Log("-----取得變數屬性-----");
            Debug.Log(moveSpeed);
            Debug.Log(turnSpeed);
            Debug.Log(runSpeed);
            Debug.Log(sprintSpeed);
            Debug.Log(jumpSpeed);
            Debug.Log(lv);
            Debug.Log("-----設定變數屬性-----");
            moveSpeed = 11.1f;
            turnSpeed = 2.5f;
            runSpeed = 30;
            sprintSpeed = 60.2f;
            //jumpSpeed = 90; // 沒有set
            lv = 10;
        }
        
    }
}
