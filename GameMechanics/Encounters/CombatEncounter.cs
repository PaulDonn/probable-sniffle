using GameMechanics.Actions.Spells;
using GameMechanics.Creatures;
using GameMechanics.Encounters.Tiles;
using GameMechanics.Enums;
using GameMechanics.Equipments;
using GameMechanics.Equipments.Armours;
using GameMechanics.Equipments.Weapons;
using GameMechanics.Equipments.Weapons.Ammunitions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameMechanics.Encounters
{
    public class CombatEncounter
    {
        public List<Creature> Creatures;
        
        public Tile[,] Field { get; set; }

        public CombatEncounter()
        {
            Creatures = new List<Creature>();
            Field = new Tile[0,0];
        }

        public void CreateNewField(int xSize, int ySize)
        {
            Field = new Tile[xSize,ySize];
        }

        public void AddTile(Tile tile, (int x, int y) coordinates)
        {
            if (coordinates.x < Field.GetLength(0)
             && coordinates.y < Field.GetLength(1))
            {
                Field[coordinates.x, coordinates.y] = tile;
                tile.Coordinates = (coordinates.x, coordinates.y);
            }
        }

        private void RollInitiative()
        {
            foreach (var creature in Creatures)
            {
                creature.RollInitiative();
                Creatures = Creatures.OrderByDescending(n => n.Initiative).ToList();
            }
        }

        public (int x, int y) GetCoordinates(Creature creature)
        {
            foreach(var tile in Field)
            {
                if(tile.Creatures.Contains(creature))
                {
                    return tile.Coordinates;
                }
            }
            throw new Exception("Creature does not exist in Field");
        }

        public void PlayEncounter()
        {
            RollInitiative();

            while(Creatures.Where(n => n.Status != CreatureState.Dead).Select(n => n.Faction).GroupBy(n => n).Count() > 1)
            {
                //Round Start

                foreach(var creature in Creatures)
                {
                    //Turn Start
                    var endTurn = false;

                    while (!endTurn)
                    {
                        endTurn = CheckResponse(creature, Console.ReadLine().ToLower());
                    }

                    //Turn End
                }

                //Round End
            }
        }

        private bool CheckResponse(Creature activeCreature, string response)
        {
            Creature target = null;
            Equipment equipment = null;
            Spell spell = null;
            int? spellLevel = null;
            bool rightHand = true;

            if(response == "end" || response == "end turn")
            {
                return true;
            }
            var responseItems = response.Split(' ');
            foreach (var responseItem in responseItems)
            {
                if (target == null)
                {
                    target = Creatures.FirstOrDefault(n => n.Name.Replace(" ", "").ToLower() == responseItem);
                }
                if (equipment == null)
                {
                    equipment = activeCreature.Inventory.Equipment.FirstOrDefault(n => n.Name.Replace(" ","").ToLower() == responseItem);
                }
                if (spell == null)
                {
                    spell = activeCreature.KnownSpells.FirstOrDefault(n => n.Name.Replace(" ", "").ToLower() == responseItem);
                }
                if (spellLevel == null && new List<string> {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9" }.Contains(responseItem))
                {
                    spellLevel = Convert.ToInt32(responseItem);
                }
                if (responseItem == "left" || responseItem == "lefthand" || responseItem == "leftweapon" || responseItem == "weapon2" || responseItem == "secondweapon")
                {
                    rightHand = false;
                }
            }
            foreach(var responseItem in responseItems)
            {
                switch (responseItem)
                {
                    case "help":
                        ShowHelp();
                        return false;
                    case "checkactions":
                        ShowAvailableActions(activeCreature);
                        return false;
                    case "checkequipment":
                        ShowEquipment(activeCreature);
                        return false;
                    case "checkinventory":
                        ShowInventory(activeCreature);
                        return false;
                    case "attack":
                        MakeAttack(activeCreature, target, rightHand);
                        return false;
                    case "cast":
                        CastSpell(spell, spellLevel, activeCreature, target);
                        return false;
                    case "equip":
                        EquipItem(activeCreature, equipment, rightHand);
                        return false;
                }
            }
            return false;
        }

        private void ShowHelp()
        {
            Console.WriteLine("**Help - Command Options**");
            Console.WriteLine("Attack (e.g. Attack Wolf / LeftHand Attack Wolf)");
            Console.WriteLine("Throw (e.g. Throw weapon at Wolf / Throw LeftHand weapon at Wolf)");
            Console.WriteLine("Cast (e.g. Cast Firebolt at Wolf / Cast HealingWord on Self at level 2");
            Console.WriteLine("Equip (e.g. Equip LeatherArmour / Equip Dagger in LeftHand");
            Console.WriteLine("CheckActions");
            Console.WriteLine("CheckEquipment");
            Console.WriteLine("CheckInventory");
            Console.WriteLine("End Turn");
        }

        private void ShowAvailableActions(Creature activeCreature)
        {
            activeCreature.GetActions();
        }

        private void ShowEquipment(Creature activeCreature)
        {
            activeCreature.GetEquipment();
        }

        private void ShowInventory(Creature activeCreature)
        {
            activeCreature.GetInventory();
        }

        private void MakeAttack(Creature attacker, Creature target, bool rightHand)
        {
            if(target == null)
            {
                throw new Exception("No valid target for attack");
            }
            if (rightHand)
            {
                if (attacker.EquipmentSet.Weapon1 == null)
                {
                    throw new Exception("No weapon in right hand");
                }
                attacker.EquipmentSet.Weapon1.MakeDefaultAttack(this, attacker, target);
            }
            else
            {
                if (attacker.EquipmentSet.Weapon2 == null)
                {
                    throw new Exception("No weapon in left hand");
                }
                attacker.EquipmentSet.Weapon2.MakeDefaultAttack(this, attacker, target);
            }
        }

        private void CastSpell(Spell spell, int? spellLevel, Creature caster, Creature target)
        {
            if (spell == null)
            {
                throw new Exception("No valid spell available");
            }
            if (target == null)
            {
                throw new Exception("No valid target for casting");
            }
            if (spellLevel.HasValue)
            {
                spell.CastAtLevel(caster, new List<Creature> { target }, spellLevel.Value);
            }
            else
            {
                spell.Cast(caster, new List<Creature> { target });
            }
        }

        private void EquipItem(Creature activeCreature, Equipment equipment, bool rightHand)
        {
            if(equipment == null)
            {
                throw new Exception("No valid equipment available");
            }
            if (equipment.GetType() == typeof(Weapon))
            {
                if(rightHand)
                {
                    activeCreature.EquipWeapon1((Weapon)equipment);
                }
                else
                {
                    activeCreature.EquipWeapon2((Weapon)equipment);
                }
            }
            if (equipment.GetType() == typeof(Ammunition))
            {
                activeCreature.EquipAmmunition((Ammunition)equipment);
            }
            if (equipment.GetType() == typeof(Shield))
            {
                activeCreature.EquipShield((Shield)equipment);
            }
            if (equipment.GetType() == typeof(Armour))
            {
                activeCreature.EquipArmour((Armour)equipment);
            }
        }

        private void UseItem()
        {

        }
    }
}
