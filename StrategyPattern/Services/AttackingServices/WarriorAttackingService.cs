using System;

namespace StrategyPattern.Services.AttackingServices
{
    public class WarriorAttackingService : IAttackingService
    {
        public void Attack()
        {
            Console.WriteLine("Sword slicing!");
        }
    }
}