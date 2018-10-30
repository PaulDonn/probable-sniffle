using System;
using GameMechanics.Creatures;
using GameMechanics.Dice;

namespace GameMechanics.Classes
{
    public abstract class Class
    {
        public abstract Die HitDie { get; }

        public virtual void AddLevelOne(Creature creature)
        {
            if(creature.AbilityScores != null)
            {
                creature.SetMaxHP(HitDie.Sides + creature.AbilityScores.ConstitutionModifier);
            }
            else
            {
                creature.SetMaxHP(HitDie.Sides);
            }
        }

        public virtual void RemoveLevelOne(Creature creature)
        {
            creature.SetMaxHP(1);
        }

        public virtual void LevelUp(Creature creature)
        {
            if (creature.AbilityScores != null)
            {
                creature.SetMaxHP(creature.MaxHitPoints + HitDie.Roll() + creature.AbilityScores.ConstitutionModifier);
            }
            else
            {
                creature.SetMaxHP(creature.MaxHitPoints + HitDie.Roll());
            }
        }

        public void AddClassTraits(Creature creature)
        {
            throw new NotImplementedException();
        }
    }
}
