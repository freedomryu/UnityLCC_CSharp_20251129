using furi.Class_15;
using furi.Tool;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace furi.Class_16
{
    /// <summary>
    /// 資料結構
    /// </summary>
    public class Class_16_DataStruct:MonoBehaviour
    {
        #region 清單
        public int[] attacks = { 10, 15, 7 };
        public float[] defens = { 1.5f, 7.5f, 0.3f };
        

        public List<int> speeds = new List<int>() { 3, 9, 7 };
        public List<string> porps = new List<string>() { "藥水", "地圖"};
        public List<float> playerDefens;
        #endregion
        private void Awake()
        {
            #region 清單
            LogSystem.LogWithColor($"第三筆速度：{speeds[2]}", "#3f3");
            speeds[0] = 10;
            LogSystem.LogWithColor($"第一筆速度：{speeds[0]}", "#3f3");

            porps.Add("寶劍");
            porps.RemoveAt(0);
            porps.Insert(1, "頭盔");
            
            foreach(var prop in porps)
            {
                LogSystem.LogWithColor($"道具：{prop}", "#f93");
            }
            playerDefens = new List<float>(defens);
            // 排序：小到大
            playerDefens.Sort();
            // 排序 ：大到小
            playerDefens.Reverse();

            foreach (var item in playerDefens)
            {
                LogSystem.LogWithColor($"道具：{item}", "#f93");
            }

            // Count 指清單內的資料，根據Add或Remove改變
            LogSystem.LogWithColor($"數量：{porps.Count}","#77f");
            // Capcity 指清單內的容量，系統自動分配
            LogSystem.LogWithColor($"容量：{porps.Capacity}", "#77f");

            List<int> numbers = new List<int>();

            for (int i = 0; i<20; i++)
            {
                numbers.Add(i);
                LogSystem.LogWithColor($"數量：{numbers.Count}", "#77f");
                LogSystem.LogWithColor($"容量：{numbers.Capacity}", "#f39");
            }
            #endregion
            #region 堆疊
            // 堆疊：先進後出，類似椅子堆再一起
            Stack<string> enemys = new Stack<string>();
            // 放資料進入堆疊機
            enemys.Push("史萊姆");
            enemys.Push("哥布林");

            LogStack<string>(enemys);

            // 拿資料並且不移除
            enemys.Peek();
            // 拿資料並且移除
            enemys.Pop();
            // 判斷是否包含某比資料
            LogSystem.LogWithColor($"{enemys.Contains("哥布林")}", "#3f6");
            // 清除所有資料
            enemys.Clear();

            LogStack<string>(enemys);
            #endregion
            // Queue 佇列：先進先出，先放進來的資料先被拿出來
            Queue<string> player = new Queue<string>();
            player.Enqueue("盜賊");
            player.Enqueue("法師");
            player.Enqueue("戰士");

            LogQueue<string>(player);
            // 拿東西不刪除
            LogSystem.LogWithColor(player.Peek(), "#f33");
            // 拿東西並刪除
            LogSystem.LogWithColor(player.Dequeue(), "#7f7");
            LogQueue<string>(player);

        }

        private void LogStack<T>(Stack<T> stack)
        {
            LogSystem.LogWithColor("------------", "#fff");
            foreach (var item in stack)
            {
                
                LogSystem.LogWithColor($"堆疊資料：{item}","#f77");
            }
        }

        private void LogQueue<T>(Queue<T> queue)
        {
            LogSystem.LogWithColor("------------", "#fff");
            foreach (var item in queue)
            {

                LogSystem.LogWithColor($"佇列資料：{item}", "#f77");
            }
        }

    }
}
