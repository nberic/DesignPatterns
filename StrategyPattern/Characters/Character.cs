using System;
using StrategyPattern.Services.AttackingServices;

namespace StrategyPattern.Characters
{
    public abstract class Character
    {
        private IAttackingService _attackingService;

        public IAttackingService AttackingService
        {
            get
            {
                return _attackingService;
            }

            set
            {
                Console.WriteLine("Changing weapon!");
                _attackingService = value;
            }
        }

        public Character(IAttackingService AttackingService)
        {
            _attackingService = AttackingService;
        }

        public void Attack()
        {
            AttackingService.Attack();
        }

        public abstract void Display();
    }
}