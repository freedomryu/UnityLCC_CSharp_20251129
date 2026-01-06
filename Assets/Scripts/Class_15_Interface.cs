using furi.Tool;
using UnityEngine;

namespace furi.Class_15
{
    /// <summary>
    /// 介面 Interface
    /// </summary>
    public class Class_15_Interface:MonoBehaviour
    {
        public object invetoryFitsr;
        public object invetory2;


        private void Awake()
        {
            int random = Random.Range(0, 3);
            LogSystem.LogWithColor($"隨機：{random}", "#f33");

            if (random == 0) invetoryFitsr = new Porp();
            else if (random == 1) invetoryFitsr = new Equip();
            else if (random == 2) invetoryFitsr = new Map();

            int random2 = Random.Range(0, 3);

            if (random2 == 0) invetory2 = new Weapon();
            else if (random2 == 1) invetory2 = new Potion();
            else if (random2 == 2) invetory2 = new Chest();
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

            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                // 如果第二格道具的物品有時做介面 就使用
                if (invetory2 is IUse) ((IUse)invetory2).Use();

                if(invetory2 is IDestory) ((IDestory)invetory2).Destory();
                // 如果物品擴充，判段式不需要添加 ，只需讓物品的都有實作介面即可
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
