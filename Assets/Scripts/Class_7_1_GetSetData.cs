using UnityEngine;
namespace furi
{
    /// <summary>
    /// 練習存取資料用
    /// </summary>
    public class Class_7_1_GetSetData:MonoBehaviour
    {
        public Class_7_1_Property Property;

        private void Awake()
        {
            // 取另一個類別的資料
            Debug.Log(Property.moveSpeed); // 可取得公開變數
            // Debug.Log(Property.turnSpeed); // 不可取得私人變數

            // 設定另一個類別資料
            Property.moveSpeed = 7.7f; // 可設定公開變數
            // Property.turnSpeed = 7.7f; // 不可設定私人變數

            Debug.Log(Property.runSpeed); // 可以取得公開的屬性
            //Debug.Log(Property.sprintSpeed); // 不可以取得私人的屬性

            Property.runSpeed = 50.3f; // 可以設定有set的屬性
            //Property.jumpSpeed = 50.3f; // 不可以設定沒有set的屬性

        }
    }
}
