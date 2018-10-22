using GameMechanics.Actions.Spells;
using GameMechanics.Actions.Spells.Conjuration.Level0;
using GameMechanics.Actions.Spells.Evocation.Level1;
using GameMechanics.Classes;
using GameMechanics.Creatures;
using GameMechanics.Dice;
using GameMechanics.Encounters;
using GameMechanics.Encounters.Tiles;
using GameMechanics.Equipments.Armours.LightArmour;
using GameMechanics.Equipments.Weapons.SimpleMeleeWeapons;
using GameMechanics.Races;
using GameMechanics.Races.PlayerRaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("******************************************************************************");
                Console.WriteLine("Main Menu");
                Console.WriteLine("******************************************************************************");
                Console.WriteLine();
                Console.WriteLine("Select an option");
                Console.WriteLine();
                Console.WriteLine("(1) Dice Roller");
                Console.WriteLine("(2) Character Tester");
                Console.WriteLine("(3) Encounter Tester");
                Console.WriteLine();
                Console.WriteLine("type \"EXIT\" to end the program");
                Console.WriteLine();
                switch (Console.ReadLine().ToUpper())
                {
                    case "1":
                        exit = DiceRoller();
                        break;
                    case "2":
                        exit = CharacterTester();
                        break;
                    case "3":
                        exit = EncounterTester();
                        break;
                    case "EXIT":
                        exit = true;
                        break;
                }
            }
        }

        private static bool DiceRoller()
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("******************************************************************************");
                Console.WriteLine("DICE ROLLER");
                Console.WriteLine("******************************************************************************");
                Console.WriteLine();
                Console.WriteLine("Enter the dice to roll. e.g. 6d8+1 rolls 6 8-sided dice, adding 1 to each die roll");
                Console.WriteLine("Available dice are d4, d6, d8, d10, d12, d20 and d100");
                Console.WriteLine();
                Console.WriteLine("type \"MENU\" to return to the main menu");
                Console.WriteLine("type \"EXIT\" to end the program");
                Console.WriteLine();
                var command = Console.ReadLine();

                if (command.ToUpper() == "EXIT")
                {
                    exit = true;
                }
                else if (command.ToUpper() == "MENU")
                {
                    break;
                }
                else
                {
                    try
                    {
                        var commandParameters = command.Replace(" ", "").Split('d');

                        if (commandParameters.Count() == 2)
                        {
                            int numberOfDice = Convert.ToInt32(commandParameters[0]);
                            int typeOfDie;
                            int dieAddition;
                            commandParameters = commandParameters[1].Split('+');
                            if (commandParameters.Count() == 1)
                            {
                                typeOfDie = Convert.ToInt32(commandParameters[0]);
                                dieAddition = 0;
                            }
                            else if (commandParameters.Count() == 2)
                            {
                                typeOfDie = Convert.ToInt32(commandParameters[0]);
                                dieAddition = Convert.ToInt32(commandParameters[1]);
                            }
                            else
                            {
                                throw new Exception();
                            }

                            if (numberOfDice > 0
                                && (new List<int> { 4, 6, 8, 10, 12, 20, 100 }).Contains(typeOfDie))
                            {
                                Die die;

                                switch (typeOfDie)
                                {
                                    case 4:
                                        die = new d4();
                                        break;
                                    case 6:
                                        die = new d6();
                                        break;
                                    case 8:
                                        die = new d8();
                                        break;
                                    case 10:
                                        die = new d10();
                                        break;
                                    case 12:
                                        die = new d12();
                                        break;
                                    case 20:
                                        die = new d20();
                                        break;
                                    case 100:
                                        die = new d100();
                                        break;
                                    default:
                                        throw new Exception();
                                }

                                var result = die.Roll(numberOfDice);

                                Console.WriteLine(string.Format("Total: {0}", result));

                            }
                            else
                            {
                                throw new Exception();
                            }
                        }
                        else
                        {
                            throw new Exception();
                        }
                    }
                    catch
                    {
                        Console.WriteLine("The input was invalid.");
                        Console.WriteLine();
                    }
                }
            }
            return exit;
        }

        private static bool CharacterTester()
        {
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("******************************************************************************");
                Console.WriteLine("Character Tester");
                Console.WriteLine("******************************************************************************");
                Console.WriteLine();
                Console.WriteLine("Select a race");
                Console.WriteLine("(1) Dwarf - Hill");
                Console.WriteLine("(2) Dwarf - Mountain");
                Console.WriteLine("(3) Elf - High");
                Console.WriteLine("(4) Elf - Wood");
                Console.WriteLine("(5) Elf - Drow");
                Console.WriteLine();
                Console.WriteLine("type \"MENU\" to return to the main menu");
                Console.WriteLine("type \"EXIT\" to end the program");
                Console.WriteLine();
                var command = Console.ReadLine();

                if (command.ToUpper() == "EXIT")
                {
                    exit = true;
                }
                else if (command.ToUpper() == "MENU")
                {
                    break;
                }
                else
                {
                    try
                    {
                        Race race;
                        switch (command)
                        {
                            case "1":
                                race = new HillDwarf();
                                break;
                            case "2":
                                race = new MountainDwarf();
                                break;
                            case "3":
                                race = new HighElf();
                                break;
                            case "4":
                                race = new WoodElf();
                                break;
                            case "5":
                                race = new Drow();
                                break;
                            default:
                                throw new Exception();
                        }

                        Creature creature = new Creature
                        {
                        };
                        creature.SetAbilityScores(new AbilityScores(10, 10, 10, 10, 10, 10));
                        creature.SetRace(race);
                        creature.RollInitiative();

                        Console.WriteLine(string.Format("Str: {0} ({1})", creature.AbilityScores.Strength, creature.AbilityScores.StrengthModifier));
                        Console.WriteLine(string.Format("Dex: {0} ({1})", creature.AbilityScores.Dexterity, creature.AbilityScores.DexterityModifier));
                        Console.WriteLine(string.Format("Con: {0} ({1})", creature.AbilityScores.Constitution, creature.AbilityScores.ConstitutionModifier));
                        Console.WriteLine(string.Format("Int: {0} ({1})", creature.AbilityScores.Intelligence, creature.AbilityScores.IntelligenceModifier));
                        Console.WriteLine(string.Format("Wis: {0} ({1})", creature.AbilityScores.Wisdom, creature.AbilityScores.WisdomModifier));
                        Console.WriteLine(string.Format("Cha: {0} ({1})", creature.AbilityScores.Charisma, creature.AbilityScores.CharismaModifier));
                        Console.WriteLine(string.Format("Initiative: {0}", creature.Initiative));
                        Console.WriteLine();

                        var club = new Club();
                        Console.WriteLine(string.Format("Is Light = {0}", club.IsLight));
                    }
                    catch (Exception ex)
                    {

                        Console.WriteLine("The input was invalid.");
                        Console.WriteLine();
                    }
                }
            }
            return exit;
        }

        private static bool EncounterTester()
        {
            bool exit = false;

            CombatEncounter encounter = new CombatEncounter();
            encounter.CreateNewField(3, 3);
            encounter.AddTile(new RockFloor { }, (0, 0));
            encounter.AddTile(new RockFloor { }, (0, 1));
            encounter.AddTile(new RockFloor { }, (0, 2));
            encounter.AddTile(new RockFloor { }, (1, 0));
            encounter.AddTile(new RockFloor { }, (1, 1));
            encounter.AddTile(new RockFloor { }, (1, 2));
            encounter.AddTile(new RockFloor { }, (2, 0));
            encounter.AddTile(new RockFloor { }, (2, 1));
            encounter.AddTile(new RockFloor { }, (2, 2));

            Creature creature1 = new Creature();
            creature1.SetName("Character1");
            creature1.SetRace(new HillDwarf());
            creature1.SetClass(new Fighter());
            creature1.SetFaction("Goodies");
            creature1.SetAbilityScores(new AbilityScores
            {
                Strength = 18,
                Dexterity = 10,
                Constitution = 14,
                Intelligence = 8,
                Wisdom = 10,
                Charisma = 11
            });
            var handaxe = new Handaxe();
            creature1.AddToInventory(handaxe);
            creature1.EquipWeapon1(handaxe);
            var padded = new Padded();
            creature1.AddToInventory(padded);
            creature1.EquipArmour(padded);
            creature1.SetMaxHP(25);

            Creature creature2 = new Creature();
            creature2.SetName("Character2");
            creature2.SetRace(new Drow());
            creature2.SetClass(new Wizard());
            creature2.SetFaction("Baddies");
            creature2.SetAbilityScores(new AbilityScores
            {
                Strength = 8,
                Dexterity = 12,
                Constitution = 10,
                Intelligence = 18,
                Wisdom = 10,
                Charisma = 14
            });
            var dagger = new Dagger();
            creature2.AddToInventory(dagger);
            creature2.EquipWeapon1(dagger);
            creature2.SetMaxHP(20);
            creature2.SpellSlots = new SpellSlots { Level0Enabled = true, Level1Max = 3, Level1Current = 3 };
            creature2.KnownSpells = new List<Spell> { new CureWounds(), new AcidSplash() };

            encounter.Creatures.Add(creature1);
            encounter.Field[1, 1].Creatures.Add(creature1);
            encounter.Creatures.Add(creature2);
            encounter.Field[1, 2].Creatures.Add(creature2);

            encounter.PlayEncounter();


            return exit;
        }
    }
}
