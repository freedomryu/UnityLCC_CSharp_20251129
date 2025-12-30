using UnityEngine;
namespace furi
{

    public class Practice_8_Class:MonoBehaviour
    {
        
        private void Awake()
        {
            practice_8_Boss fireEnemy = new practice_8_Boss("火兵", "火球術", 400);
            practice_8_Boss waterEnemy = new practice_8_Boss("水兵", "水球術", 720);

            Debug.Log($"<color=#f93>{fireEnemy.name}， 招式：{fireEnemy.skillName}</color>");
            Debug.Log($"<color=#f93>{waterEnemy.name}， 招式：{waterEnemy.skillName}</color>");
        }
    }
    /// <summary>
    /// Boss類別
    /// </summary>
    public class practice_8_Boss
    {
        public string name;
        public string skillName;
        public float hp;

        public practice_8_Boss (string _name,string _skillName, float _hp)
        {
            name = _name;
            skillName = _skillName;
            hp = _hp;
        }
    }
}
