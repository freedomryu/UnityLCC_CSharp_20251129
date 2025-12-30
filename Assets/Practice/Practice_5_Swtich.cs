using UnityEngine;

public class Practice_5_Swtich : MonoBehaviour
{
    [SerializeField, Header("寫量"),Range(0,100) ]
    private float hp = 100;

    private void Update()
    {
        switch (hp)
        {
            case >=80:
                Debug.Log($"血量安全");
            break;
            case >= 60:
                Debug.Log($"健康狀態有狀況");
                break;
            case >= 40:
                Debug.Log($"警告，快喝水");
                break;
            case >= 10:
                Debug.Log($"快死掉了");
                break;
            case <= 0:
                Debug.Log($"你已經死了");
                break;
        }
    }
}
