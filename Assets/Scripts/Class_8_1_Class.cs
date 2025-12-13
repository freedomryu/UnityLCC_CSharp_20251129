using UnityEngine;
namespace furi
{
    /// <summary>
    /// 類別 Class
    /// </summary>
    public class Class_8_1_Class:MonoBehaviour
    {
        

        private void Awake()
        {
            // 實體化NPC並儲存在npcJack 變數內
            Class_8_1_Npc npcJack = new Class_8_1_Npc();
            Class_8_1_Npc npcFuri = new Class_8_1_Npc("furi");

            npcJack.LogName();
            npcFuri.LogName();
        }
    }
}
