using furi.Tool;
using UnityEngine;

namespace furi
{
    /// <summary>
    /// 介面 Interface
    /// </summary>
    public class Class_15_Interface:MonoBehaviour
    {
        public object invetoryFitsr;

        
        private void Awake()
        {
            int random = Random.Range(0, 3);
            LogSystem.LogWithColor($"隨機：{random}", "#f33");

            if (random == 0) invetoryFitsr = new Porp();
            else if (random == 1) invetoryFitsr = new Equip();
            else if (random == 2) invetoryFitsr = new Map();
        }

        private void Update()
        {
            // 按下數字鍵1，可以使用第一個的物品
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                // 如果第一個是道具，就使用道具
                if (invetoryFitsr is Porp) ((Porp)invetoryFitsr).Use();
                // 如果第一個是裝備，就使用裝備
                else if (invetoryFitsr is Equip) ((Equip)invetoryFitsr).Use();
                // 如果第一個是地圖，就使用地圖
                else if (invetoryFitsr is Map) ((Map)invetoryFitsr).Use();

            }
        }
    }

    public class Porp
    {
        public void Use()
        {
            LogSystem.LogWithColor("使用道具，恢復體力", "#f96");
        }
    }

    public class Equip
    {
        public void Use()
        {
            LogSystem.LogWithColor("使用裝備，裝到對應位置", "#f96");
        }
    }

    public class Map
    {
        public void Use()
        {
            LogSystem.LogWithColor("使用地圖，開啟地圖功能", "#f96");
        }
    }
}
