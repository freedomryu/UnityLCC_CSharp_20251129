using furi.Tool;
using UnityEngine;
namespace furi
{

    public class Practice_10_Inherit:MonoBehaviour
    {
        private void Awake()
        {
            Potion redPotion = new Potion("紅水");
            Potion bluePotion = new Potion("藍水");
            Equipmant helmet = new Equipmant("頭盔");

            redPotion.Use();
            bluePotion.Use(24);
            helmet.Use();
        }
    }

    public class Item 
    {
        public string name;
        public Item (string _name)
        {
            name = _name;
        }
        public virtual void Use()
        {
            LogSystem.LogWithColor($"{name}道具，使用Item方法", "#f33");
        }

    }
    public class Potion : Item
    {
        public Potion(string _name) : base(_name)
        {
        }
        public void Use(int increase)
        {
            LogSystem.LogWithColor($"{name}藥水，使用Potion方法，恢復量：{increase}", "#3f3");
        }
    }
    public class Equipmant : Item
    {
        public Equipmant(string _name) : base(_name)
        {
        }
        public override void Use()
        {
            LogSystem.LogWithColor($"{name}裝備，使用Equipmant方法", "#77f");
        }
    }
}
