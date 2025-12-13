using UnityEngine;
namespace furi
{
    /// <summary>
    /// NPC類別：NPC名稱與對話內容資料,有輸出 NPC 名稱與說話的功能
    /// </summary>
    public class Class_8_1_Npc
    {
        private string name;
        private string dialogue;

        // 建構子：沒有傳回類型，名稱與類別相同的公開方法
        public Class_8_1_Npc()
        {
            Debug.Log("<color=#f3d>預設建構子</color>");
        }
        public Class_8_1_Npc(string _name)
        {
            Debug.Log("<color=#f3d>有參數的建構子</color>");
        }

        public void LogName()
        {
            Debug.Log($"<color=#373>NPC的名稱：{name}</color>");
        }
        public void Talk()
        {
            Debug.Log($"<color=#373>{dialogue}</color>");
        }
    }

}
