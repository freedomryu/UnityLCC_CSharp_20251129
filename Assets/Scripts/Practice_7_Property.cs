using UnityEngine;
namespace furi
{
    public class Practice_7_Property:MonoBehaviour
    {
        [SerializeField]
        public float _hp = 100;

        public float hp
        {
            get 
            {
                if (_hp <= 0) Debug.Log("<color=#f33>腳色已經死了</color>");
                return _hp;
            }
        }
        private void Update()
        {
            Debug.Log(hp);
        }
    }
}
