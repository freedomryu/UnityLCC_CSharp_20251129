using furi.Tool;
using System;
using UnityEngine;
namespace furi
{
    /// <summary>
    /// 多型
    /// </summary>
    public class Class_10_2_Polymorphism:MonoBehaviour
    {
        private void Awake()
        {
            Trap trap1 = new Trap("落穴", 3);
            Magic magic1 = new Magic("死者甦醒",5);
            trap1.ShowCard();
            magic1.ShowCard();
            // 多形：多種型式，可以使用父類別或自己的成員
            trap1.Information();        // 形式1：呼叫Card的方法
            trap1.Information(37);      // 形式2：呼叫Card的方法

            // 多形：宣告時使用父類別，實例化的類別會決定形式
            Card card1 = new Card("一般卡片", 0);
            Magic magic2 = new Magic("羽毛掃", 7);
            card1.Information();        // 形式1：呼叫Card的方法
            magic2.Information();       // 形式2：呼叫Magic的方法

        }
    }
    public class Card
    {
        public string name;
        public int cost;
        public Card(string _name, int _cost)
        {
            name = _name;
            cost = _cost;
        }
        public void ShowCard()
        {
            LogSystem.LogWithColor($"卡片名：{name}消耗：{cost}點","#66f");
        }
        public virtual void Information()
        {
            LogSystem.LogWithColor($"{name}這是一張卡", "#aaa");
        }
    }
    public class Trap : Card
    {
        public Trap(string _name, int _cost) : base(_name, _cost)
        {
        }
        public void Information(int index)
        {
            LogSystem.LogWithColor($"{name}這是一張陷阱卡編號：{index}", "#f77");
        }
    }
    public class Magic : Card
    {
        public Magic(string _name, int _cost) : base(_name, _cost)
        {
        }
        public override void Information()
        {
            LogSystem.LogWithColor($"{name}這是一張魔法卡", "#77f");
        }
    }
}
