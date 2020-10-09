using StrategyPattern.Characters;
using StrategyPattern.Services.AttackingServices;

namespace StrategyPattern
{
    static class Program
    {
        static void Main(string[] args)
        {
            // Attacking properties for a wizard character
            var warriorAttackingService = new WarriorAttackingService();
            var wizardAttackingService = new WizardAttackingService();

            var gandalf = new WizardCharacter(wizardAttackingService);
            gandalf.Display();

            // Attack as a wizard
            gandalf.Attack();

            // Attack as warrior
            gandalf.AttackingService = warriorAttackingService;
            gandalf.Attack();
        }
    }
}
