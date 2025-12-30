using furi.Tool;
using UnityEngine;
namespace futi.Class_15
{

    public class Class_15_InterfaceObject:MonoBehaviour
    {
        
    }

    // 介面使用步驟
    // 1.定義介面與介面成員
    // 2.類別實作介面
    // 3.實作介面的成員

    // 步驟1
    // 帶有「使用」功能的介面，遊戲內能被使用的物品
    public interface IUse
    {
        public void Use();
    }

    // 步驟2
    // C# 單一繼承 多重實作介面
    public class Weapon : IUse
    {
        public void Use()
        {
            LogSystem.LogWithColor("使用武器，施展武器技能", "#fa3");
        }

    }

    public class Potion : IUse
    {
        public void Use()
        {
            LogSystem.LogWithColor("使用藥水，恢復魔力", "#a3f");
        }

    }
    public class Chest : IUse
    {
        public void Use()
        {
            LogSystem.LogWithColor("使用寶箱，獲得隨機道具", "#f3a");
        }

    }
}
