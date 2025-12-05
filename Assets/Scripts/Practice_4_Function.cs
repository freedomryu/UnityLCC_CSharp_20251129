using UnityEngine;

/// <summary>
/// 函式
/// </summary>
public class Practice_4_Function:MonoBehaviour
{
    private void Awake()
    {
        Debug.Log($"<color=#3f3>布林值:{returnTrue()}</color>"); //True
        Debug.Log($"<color=#3f3>布林值:{returnFales()}</color>"); //False
    }
    /// <summary>
    /// 布林值true
    /// </summary>
    /// <returns>true</returns>
    private bool returnTrue ()
    {
        return true;
    }
    /// <summary>
    /// 布林值false
    /// </summary>
    /// <returns>false</returns>
    private bool returnFales()
    {
        return false;
    }
}
