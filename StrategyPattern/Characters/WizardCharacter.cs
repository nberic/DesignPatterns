using System;
using StrategyPattern.Services.AttackingServices;

namespace StrategyPattern.Characters
{
    public class WizardCharacter : Character
    {

        public WizardCharacter(IAttackingService AttackingService)
        : base(AttackingService)    
        {
            
        }

        public override void Display()
        {
            Console.WriteLine("I am a mayar!");
        }
    }
}