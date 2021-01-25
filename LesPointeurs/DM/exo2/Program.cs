using System;

namespace exo2
{
    unsafe class Program
    {
        static void Main(string[] args)
        {
            Boss sauron = new Boss(100, 0.5f);
            Player frodon = new Player("frodon", 10, &sauron);
        }

        public struct Boss
        {
            int life;
            float shield;

            public Boss(int life, float shield)
            {
                this.life = life;
                this.shield = shield;
            }

            public bool IsBossDead(int life)
            {
                bool isDead;

                if(life <= 0)
                {
                    isDead = true;
                }
                else
                {
                    isDead = false;
                }

                return isDead;
            }

            public int ApplyDamage(int life, float shield, int damage)
            {
                if(!IsBossDead(life))
                {
                    life -= (int)(damage*shield);
                }
                return (int)(damage*shield);
            }

            public void BossState(int life, float shield)
            {
                Console.WriteLine($"vie : {life}\n protection : {shield}");
            }
        }

        public struct Player
        {
            string name;

            int damage;

            Boss* bossPointer;

            public Player(string name, int damage, Boss* bossPointer)
            {
                this.name = name;
                this.damage = damage;
                this.bossPointer = bossPointer;
            }

            public void Attack(string name, int damage, Boss* bossPointer)
            {
                Console.WriteLine($"Le Player {name} a blessé le Boss de {damage}");
            }
        }
    }
}
