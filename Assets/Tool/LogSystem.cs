using UnityEngine;
namespace furi.Tool
{
    /// <summary>
    /// 輸出訊息工具
    /// </summary>
    public class LogSystem
    {
        public static string LogWithColor(string message,string color)
        {
            string result = $"<color={color}>{message}</color>";
            Debug.Log(result);
            return result;
        }
    }
}
