using furi.Tool;
using System.Collections.Generic;
using UnityEngine;

namespace furi.Class_16
{
    /// <summary>
    /// 資料結構
    /// </summary>
    public class Class_16_DataStruct:MonoBehaviour
    {
        public int[] attacks = { 10, 15, 7 };
        public float[] defens = { 1.5f, 7.5f, 0.3f };

        public List<int> speeds = new List<int>() { 3, 9, 7 };
        public List<string> porps = new List<string>() { "藥水", "地圖"};

        private void Awake()
        {
            LogSystem.LogWithColor($"第三筆速度：{speeds[2]}", "#3f3");
            speeds[0] = 10;
            LogSystem.LogWithColor($"第一筆速度：{speeds[0]}", "#3f3");
        }
    }
}
