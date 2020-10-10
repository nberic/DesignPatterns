using System;
using StrategyPattern.Services.AttackingServices;

namespace StrategyPattern.Characters
{
    public abstract class Character
    {
        private IAttackingService _attackingService;

        public Character(IAttackingService AttackingService)
        {
            _attackingService = AttackingService;
        }

        public virtual void Attack()
        {
            _attackingService.Attack();
        }

        public virtual void ChangeWeapon(IAttackingService attackingService)
        {
            Console.WriteLine("Changing weapon!");
            _attackingService = attackingService;
        }

        public abstract void Display();
    }
}