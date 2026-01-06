using furi.Tool;
using UnityEngine;
namespace furi.Class_15
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

    public interface IDestory
    {
        public void Destory();
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

    public class Potion : IUse, IDestory
    {
        public void Use()
        {
            LogSystem.LogWithColor("使用藥水，恢復魔力", "#a3f");
        }

        public void Destory()
        {
            LogSystem.LogWithColor("藥水使用完畢，刪除", "#f11");
        }

    }
    public class Chest : IUse, IDestory
    {
        public void Destory()
        {
            LogSystem.LogWithColor("寶箱使用完畢，刪除", "#f11");
        }

        public void Use()
        {
            LogSystem.LogWithColor("使用寶箱，獲得隨機道具", "#f3a");
        }

    }
}
