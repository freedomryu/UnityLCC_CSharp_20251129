using furi.Tool;
using UnityEngine;


namespace furi.Class_15
{
    /// <summary>
    /// 泛型
    /// </summary>
    public class Class_15_Generics:MonoBehaviour
    {
        private void Awake()
        {
            int numberA = 7, numberB = 9;
            LogSystem.LogWithColor($"數字A與B：{numberA} | {numberB}","#f93");
            SwapNumber(ref numberA,ref numberB );
            LogSystem.LogWithColor($"數字A與B：{numberA} | {numberB}", "#f93");

            char charA = '嘿', charB = '嗨';
            LogSystem.LogWithColor($"字元A與B：{charA} | {charB}", "#f93");
            SwapNumber(ref numberA, ref numberB);
            LogSystem.LogWithColor($"字元A與B：{charA} | {charB}", "#f93");

            object objA = 3.5f, objB = 7.7f;
            LogSystem.LogWithColor($"物件A與B：{objA} | {objB}", "#f93");
            SwapNumber(ref numberA, ref numberB);
            LogSystem.LogWithColor($"物件A與B：{objA} | {objB}", "#f93");

            // 使用泛型
            bool boolA=true,boolB=false;
            LogSystem.LogWithColor($"布林值A與B：{boolA} | {boolB}", "#f93");
            Swap<bool>(ref boolA, ref boolB);
            LogSystem.LogWithColor($"布林值A與B：{boolA} | {boolB}", "#f93");

            byte byteA = 1, byteB = 9;
            LogSystem.LogWithColor($"A與B：{byteA} | {byteB}", "#f93");
            Swap<byte>(ref byteA, ref byteB);
            LogSystem.LogWithColor($"A與B：{byteA} | {byteB}", "#f93");

            var player1 = new DataPlayer<int>();
            player1.data = 99;
            player1.logData(123);

            var player2 = new DataPlayer<string>();
            player2.data = "玩家二號";
            player2.logData("哈囉");

        }
        private void Start()
        {
            var player = new Player();
            var enemy = new Enemy();
            var attackEvent = new AttackEvent<Player, Enemy>();
            attackEvent.Attack(player, enemy);
            var hp = new Hp();
            var atttack = new Attack();
            hp.Increase(10.5f);
            atttack.Increase(50);

            var checker = new CheckValue<Hp, float> ();
            checker.Check(hp);
        }
        /// <summary>
        /// 數字對調
        /// </summary>
        /// <param name="a">第一個數字</param>
        /// <param name="b">第二個數字</param>
        public void SwapNumber(ref int a, ref int b)
        {
            int temp = a;
            a = b; 
            b = temp;
        }
        public void SwapChar(ref char a, ref char b)
        {
            char temp = a;
            a = b;
            b = temp;
        }
        public void SwapObject(ref object a, ref object b)
        {
            object temp = a;
            a = b;
            b = temp;
        }
        /// <summary>
        /// 使用泛型進行
        /// </summary>
        /// <typeparam name="T">要對調的資料類型</typeparam>
        /// <param name="a">第一個資料</param>
        /// <param name="b">第二個資料</param>
        public void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        public class DataPlayer<T>
        {
            public T data;
            public void logData(T data)
            {
                LogSystem.LogWithColor(data, "#3ff");
            }
        }

        public class Player { }
        public class Enemy { }

        public class AttackEvent<T,U>
        {
            public void Attack(T attacker, U defender)
            {
                LogSystem.LogWithColor($"{attacker}攻擊{defender}", "#f3f");
            }
        }

        
    }
    #region 泛型介面
    public interface Istat<T>
    {
        public T Value { get; set; }
        public void Increase(T amount);
    }
    public class Hp : Istat<float>
    {
        public float Value { get; set; }

        public void Increase(float amount)
        {
            Value += amount;
            LogSystem.LogWithColor($"血量：{Value}", "#f3f");
        }
    }
    public class Attack : Istat<int>
    {
        public int Value { get ; set; }

        public void Increase(int amount)
        {
            Value += amount;
            LogSystem.LogWithColor($"攻擊力：{Value}", "#f3f");
        }
    }
    #endregion

    // 泛型 T 必須實作 Istat<T> 介面
    public class CheckValue<T,U> where T : Istat<U>
    {
        public void Check(T stat)
        {
            LogSystem.LogWithColor($"狀態的值：{stat.Value}", "#3d3");
        }
    }
}
