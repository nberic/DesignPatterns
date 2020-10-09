using System;

namespace StrategyPattern.Services.AttackingServices
{
    public class WizardAttackingService : IAttackingService
    {
        public void Attack()
        {
            Console.WriteLine("Conjuring magic!");
        }
    }
}