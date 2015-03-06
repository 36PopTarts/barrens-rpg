//The below text is the original Tribes RPG license.
//This is a modified version known as "Barrens," created by Crazy Eyes in 2015.

//This file is part of Tribes RPG.
//Tribes RPG server side scripts
//Written by Jason "phantom" Daley,  Matthiew "JeremyIrons" Bouchard, and more (yet undetermined)

//	Copyright (C) 2014  Jason Daley

//	This program is free software: you can redistribute it and/or modify
//	it under the terms of the GNU General Public License as published by
//	the Free Software Foundation, either version 3 of the License, or
//	(at your option) any later version.

//	This program is distributed in the hope that it will be useful,
//	but WITHOUT ANY WARRANTY; without even the implied warranty of
//	MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//	GNU General Public License for more details.

//	You should have received a copy of the GNU General Public License
//	along with this program.  If not, see <http://www.gnu.org/licenses/>.

//You may contact the author at beatme101@gmail.com or www.tribesrpg.org/contact.php

//This GPL does not apply to Starsiege: Tribes or any non-RPG related files included.
//Starsiege: Tribes, including the engine, retains a proprietary license forbidding resale.


//######################################################################################
// Skills
//######################################################################################

// Common
$SkillSwords = 1;
$SkillAxes = 2;
$SkillClubs = 3;
$SkillDaggers = 4;
$SkillPolearms = 5;
$SkillArchery = 6;
$SkillDodging = 7;
$SkillParrying = 8;
$SkillBashing = 9;
$SkillTripping = 10;
$SkillHaggling = 39;
$SkillTravelling = 40;
$SkillArmorUse = 42;

// Rogue
$SkillCoercion = 11;
$SkillStealing = 12;
$SkillHiding = 13;
$SkillPoisoning = 14;
$SkillPseudomancy = 15;

// Rogue/Ranger
$SkillTrapping = 16;

// Invoker
$SkillFireAff = 17;
$SkillWaterAff = 18;
$SkillAirAff = 19;
$SkillEarthAff = 20;
$SkillOozeAff = 21;
$SkillLightningAff = 22;
$SkillIceAff = 23;
$SkillMagmaAff = 24;

// Necromancer
$SkillSummoning = 25;
$SkillBinding = 26;
$SkillPathomancy = 27;
$SkillChannelling = 28;

// Ranger
$SkillCamouflage = 29;
$SkillSurvival = 30;
$SkillMysticism = 31;
$SkillHunting = 32;

// Fighter
$SkillTactics = 33;
$SkillMastery = 34;

// Cleric
$SkillRestoration = 35;
$SkillThaumaturgy = 36;
$SkillSmiting = 37;
$SkillDevotion = 38;

// All Mages
$SkillSpellcraft = 41;

$MinLevel = "L";
$MinGroup = "G";
$MinClass = "C";
$MinRemort = "R";
$MinAdmin = "A";
$MinHouse = "H";

$SkillGroup[$SkillSwords] = "Fighter Berserker Paladin Rogue Assassin Ranger";
$SkillGroup[$SkillAxes] = "Fighter Berserker Ranger Paladin";
$SkillGroup[$SkillClubs] = "Fighter Rogue Berserker Ranger Paladin Cleric Assassin Invoker Necromancer";
$SkillGroup[$SkillDaggers] = "Fighter Rogue Berserker Paladin Ranger Necromancer Assassin Invoker";
$SkillGroup[$SkillPolearms] = "Fighter Berserker Paladin Ranger";
$SkillGroup[$SkillArchery] = "Fighter Ranger Rogue Assassin";
$SkillGroup[$SkillDodging] = Common;
$SkillGroup[$SkillParrying] = "Fighter Ranger Rogue Assassin Paladin Cleric";
$SkillGroup[$SkillTravelling] = Common;
$SkillGroup[$SkillBashing] = "Fighter Berserker Ranger Rogue Assassin Paladin Cleric";
$SkillGroup[$SkillTripping] = "Fighter Berserker Ranger Rogue Assassin Paladin";
$SkillGroup[$SkillHaggling] = Common;
$SkillGroup[$SkillArmorUse] = Common;

$SkillGroup[$SkillCoercion] = Rogue;
$SkillGroup[$SkillStealing] = Rogue;
$SkillGroup[$SkillHiding] = Rogue;
$SkillGroup[$SkillBackstabbing] = Rogue;
$SkillGroup[$SkillPoisoning] = Rogue;
$SkillGroup[$SkillPseudomancy] = Rogue;

$SkillGroup[$SkillTrapping] = "Rogue Ranger";

$SkillGroup[$SkillFireAff] = Invoker;
$SkillGroup[$SkillWaterAff] = Invoker;
$SkillGroup[$SkillAirAff] = Invoker;
$SkillGroup[$SkillEarthAff] = Invoker;
$SkillGroup[$SkillOozeAff] = Invoker;
$SkillGroup[$SkillMagmaAff] = Invoker;
$SkillGroup[$SkillLightningAff] = Invoker;
$SkillGroup[$SkillIceAff] = Invoker;

$SkillGroup[$SkillSummoning] = Necromancer;
$SkillGroup[$SkillBinding] = Necromancer;
$SkillGroup[$SkillChallenging] = Necromancer;
$SkillGroup[$SkillPathomancy] = Necromancer;

$SkillGroup[$SkillCamouflage] = Ranger;
$SkillGroup[$SkillSurvival] = Ranger;
$SkillGroup[$SkillMysticism] = Ranger;
$SkillGroup[$SkillHunting] = Ranger;

$SkillGroup[$SkillTactics] = Fighter;
$SkillGroup[$SkillMastery] = Fighter;

$SkillGroup[$SkillRestoration] = Cleric;
$SkillGroup[$SkillThaumaturgy] = Cleric;
$SkillGroup[$SkillSmiting] = Cleric;
$SkillGroup[$SkillDevotion] = Cleric;

$SkillGroup[$SkillSpellcraft] = "Invoker Necromancer";

//Attack Speed from Weapon Skill Modifier
$AttackSkillSpeedMod = 0.0015; // .15% faster per point
$SkillDesc[$SkillSwords] = "Swords";
$GoverningAttribute[$SkillSwords] = "STR or DEX";
$SkillDesc[$SkillAxes] = "Axes";
$GoverningAttribute[$SkillAxes] = "STR";
$SkillDesc[$SkillClubs] = "Clubs";
$GoverningAttribute[$SkillClubs] = "STR";
$SkillDesc[$SkillDaggers] = "Daggers";
$GoverningAttribute[$SkillDaggers] = "DEX";
$SkillDesc[$SkillPolearms] = "Polearms";
$GoverningAttribute[$SkillPolearms] = "STR or DEX";
$SkillDesc[$SkillArchery] = "Archery";
$GoverningAttribute[$SkillArchery] = "DEX";
$SkillDesc[$SkillDodging] = "Dodging";
$GoverningAttribute[$SkillDodging] = "STR";
$SkillDesc[$SkillParrying] = "Parrying";
$GoverningAttribute[$SkillParrying] = "DEX";
$SkillDesc[$SkillBashing] = "Bashing";
$GoverningAttribute[$SkillBashing] = "STR";
$SkillDesc[$SkillTripping] = "Tripping";
$GoverningAttribute[$SkillTripping] = "DEX";
$SkillDesc[$SkillTravelling] = "Travelling";
$SkillDesc[$SkillHaggling] = "Haggling";
$SkillDesc[$SkillArmorUse] = "Armor Use";
$GoverningAttribute[$SkillArmorUse] = "CON";

$SkillDesc[$SkillCoercion] = "Coercion";
$GoverningAttribute[$SkillCoercion] = "DEX";
$SkillDesc[$SkillStealing] = "Stealing";
$GoverningAttribute[$SkillStealing] = "DEX";
$SkillDesc[$SkillHiding] = "Hiding";
$GoverningAttribute[$SkillHiding] = "DEX";
$SkillDesc[$SkillPoisoning] = "Poisoning";
$GoverningAttribute[$SkillPoisoning] = "INT";
$SkillDesc[$SkillPseudomancy] = "Pseudomancy";
$GoverningAttribute[$SkillPseudomancy] = "INT";

$SkillDesc[$SkillTrapping] = "Trapping";
$GoverningAttribute[$SkillPseudomancy] = "INT or WIS";

$SkillDesc[$SkillFireAff] = "Fire Affinity";
$GoverningAttribute[$SkillFireAff] = "INT";
$SkillDesc[$SkillWaterAff] = "Water Affinity";
$GoverningAttribute[$SkillWaterAff] = "INT";
$SkillDesc[$SkillAirAff] = "Air Affinity";
$GoverningAttribute[$SkillAirAff] = "INT";
$SkillDesc[$SkillEarthAff] = "Earth Affinity";
$GoverningAttribute[$SkillEarthAff] = "INT";
$SkillDesc[$SkillOozeAff] = "Ooze Affinity";
$GoverningAttribute[$SkillOozeAff] = "INT";
$SkillDesc[$SkillLightningAff] = "Lightning Affinity";
$GoverningAttribute[$SkillLightningAff] = "INT";
$SkillDesc[$SkillIceAff] = "Ice Affinity";
$GoverningAttribute[$SkillIceAff] = "INT";
$SkillDesc[$SkillMagmaAff] = "Magma Affinity";
$GoverningAttribute[$SkillMagmaAff] = "INT";

$SkillDesc[$SkillSummoning] = "Summoning";
$GoverningAttribute[$SkillSummoning] = "INT";
$SkillDesc[$SkillBinding] = "Binding";
$GoverningAttribute[$SkillBinding] = "INT";
$SkillDesc[$SkillPathomancy] = "Pathomancy";
$GoverningAttribute[$SkillPathomancy] = "INT";
$SkillDesc[$SkillChannelling] = "Channelling";
$GoverningAttribute[$SkillChanelling] = "INT";

$SkillDesc[$SkillCamouflage] = "Camouflage";
$GoverningAttribute[$SkillCamouflage] = "DEX or WIS";
$SkillDesc[$SkillSurvival] = "Survival";
$GoverningAttribute[$SkillSurvival] = "WIS";
$SkillDesc[$SkillMysticism] = "Mysticism";
$GoverningAttribute[$SkillMysticism] = "WIS";
$SkillDesc[$SkillHunting] = "Hunting";
$GoverningAttribute[$SkillHunting] = "STR or DEX";

$SkillDesc[$SkillTactics] = "Tactics";
$GoverningAttribute[$SkillTactics] = "INT or WIS";
$SkillDesc[$SkillMastery] = "Mastery";
$GoverningAttribute[$SkillMastery] = "STR or DEX";

$SkillDesc[$SkillRestoration] = "Restoration";
$GoverningAttribute[$SkillRestoration] = "WIS";
$SkillDesc[$SkillThaumaturgy] = "Thaumaturgy";
$GoverningAttribute[$SkillThaumaturgy] = "WIS";
$SkillDesc[$SkillSmiting] = "Smiting";
$GoverningAttribute[$SkillSmiting] = "WIS";
$SkillDesc[$SkillDevotion] = "Devotion";
$GoverningAttribute[$SkillDevotion] = "WIS";

$SkillDesc[$SkillSpellcraft] = "Spellcraft";
$GoverningAttribute[$SkillSpellcraft] = "INT";

$SkillDesc[L] = "Level";
$SkillDesc[G] = "Group";
$SkillDesc[C] = "Class";
$SkillDesc[R] = "Remort";
$SkillDesc[A] = "Admin Level";
$SkillDesc[H] = "House";

//######################################################################################
// Class multipliers
//######################################################################################

//***********************************
// GENERAL RULES FOR MULTIPLIERS:
//***********************************
// Unlike standard TRPG, skill multipliers in Barrens are compound numbers.
// They are composed of two things: 1) a bonus from your character's class (if any), i.e. warriors have at least 1.8 in all of their weapon skills
// 2) a modifier based on your character's Intelligence.
// Some classes, designed for characters with low intellect, have high base multipliers, such as the Warrior.
// Others, primarily mages, have relatively low base multipliers on their primary skills but usually end up having higher total skill multipliers because of their high intellect.
// This section comprises only the class base multiplier for each skill. The calculations are done elsewhere.

//******** SUMMARY ******************
//- Primary skills use a 20 multiplier
//- Secondary skills use a 15 multiplier
//- Normal skills use a ~10 multiplier
//- Weak skills use a ~5 multiplier
//- VERY weak skills use a 2
//- Unsuitable skills for a specific class use a 1

//--------------
// Cleric
//--------------
// Some are the givers of life, others take it away, but all show their devotion to their deity in some way. These are the clergy, who tend to be more versatile and better at supporting than their arcanist counterparts. They have enough close combat skill to finish off opponents weakened from their divine magic.
// Due to clerics' reliance on their God, they do not learn from combat as quickly as most other classes.
//
// Favored Attributes: Wisdom, Cnnstitution, Strength
// Restoration: These incantations erase wounds, destroy harmful magicks, and cure ailments.
// Thaumaturgy: The practice of miracles, thaumaturgy is a very diverse school, with some bizarre choices available.
// Smiting: Curses and projections of divine energy fall into this category of magic.
// Devotion: How connected a cleric is with his or her chosen deity. A higher status with one's god begets greater power and more spells.

$SkillMultiplier[Cleric, $SkillClubs] = 14;
$SkillMultiplier[Cleric, $SkillDodging] = 8;
$SkillMultiplier[Cleric, $SkillBashing] = 7;
$SkillMultiplier[Cleric, $SkillThaumaturgy] = 7;
$SkillMultiplier[Cleric, $SkillRestoration] = 7;
$SkillMultiplier[Cleric, $SkillSmiting] = 7;
$SkillMultiplier[Cleric, $SkillDevotion] = 10;
$SkillMultiplier[Cleric, $SkillTravelling] = 12;
$SkillMultiplier[Cleric, $SkillHaggling] = 10;
$EXPmultiplier[Cleric] = 0.85;

//--------------
// Druid
//--------------
// Druids are good with Bludgeoning weapons and are somewhat familiar with spells.  They specialize in Neutral casting.
// However they are also able to easily hide.

//Primary Skill: Neutral Casting
//Secondary Skill: Hiding, Slashing, Spell Resistance

$SkillMultiplier[Druid, $SkillSlashing] = 15;
$SkillMultiplier[Druid, $SkillPiercing] = 7;
$SkillMultiplier[Druid, $SkillBludgeoning] = 6;
$SkillMultiplier[Druid, $SkillDodging] = 20;
$SkillMultiplier[Druid, $SkillWeightCapacity] = 20;
$SkillMultiplier[Druid, $SkillBashing] = 5;
$SkillMultiplier[Druid, $SkillStealing] = 2;
$SkillMultiplier[Druid, $SkillHiding] = 20;
$SkillMultiplier[Druid, $SkillBackstabbing] = 5;
$SkillMultiplier[Druid, $SkillOffensiveCasting] = 7;
$SkillMultiplier[Druid, $SkillDefensiveCasting] = 7;
$SkillMultiplier[Druid, $SkillNeutralCasting] = 20;
$SkillMultiplier[Druid, $SkillSpellResistance] = 10;
$SkillMultiplier[Druid, $SkillHealing] = 13;
$SkillMultiplier[Druid, $SkillArchery] = 7;
$SkillMultiplier[Druid, $SkillEndurance] = 8;
$SkillMultiplier[Druid, $SkillMining] = 20;
$SkillMultiplier[Druid, $SkillSpeech] = 10;
$SkillMultiplier[Druid, $SkillSenseHeading] = 17;
$SkillMultiplier[Druid, $SkillEnergy] = 12;
$SkillMultiplier[Druid, $SkillHaggling] = 13;
$EXPmultiplier[Druid] = 0.8;

//--------------
// Rogue
//--------------
// A dark alley, traces of lamp light from the street fade into pitch blackness. You feel a sudden blow to the back of your skull, but oddly, it doesn't feel very painful.
// Suddenly, you're on the ground and your pockets are empty. There seems to be a gap in your memory.
//
// Masters of moving unseen in civilized and confined areas, rogues are natural player killers. They use their backstab to start the fight with a heavy advantage, and fleeing just allows 
// the rogue to attack them unseen once again. Rogues use underhanded tricks to get the better of their opponents, including poison. 
// Most rogues are quite clever, despite their lack of formal training. They're subtle enough to steal from others unseen, and can create and handle complicated traps. 
// Many rogues have a penchant for "pseudomancy," common slang for activating a magical item without the proper magical know-how or inherent attributes. This allows them to use wands 
// and scrolls despite not being spellcasters, although their success rate is determined by their investment in this skill.
// Rogues cannot use their stealth skills to hide in the wilderness (outside of a zone). They grew up in populated areas, where urban navigational skills and blending in with crowds
// trumped the art of camouflage and open-area stealth that the Rangers possess.

//Favored Attributes: Dexterity, Intelligence, Constitution

$SkillMultiplier[Rogue, $SkillDaggers] = 16;
$SkillMultiplier[Rogue, $SkillSwords] = 12;
$SkillMultiplier[Rogue, $SkillClubs] = 12;
$SkillMultiplier[Rogue, $SkillArchery] = 12;
$SkillMultiplier[Rogue, $SkillDodging] = 14;
$SkillMultiplier[Rogue, $SkillArmorUse] = 10;
$SkillMultiplier[Rogue, $SkillWeightCapacity] = 7;
$SkillMultiplier[Rogue, $SkillTripping] = 15;
$SkillMultiplier[Rogue, $SkillBashing] = 8;
$SkillMultiplier[Rogue, $SkillTrapping] = 17;
$SkillMultiplier[Rogue, $SkillStealing] = 17;
$SkillMultiplier[Rogue, $SkillHiding] = 17;
$SkillMultiplier[Rogue, $SkillCoercion] = 17;
$SkillMultiplier[Rogue, $SkillPseudomancy] = 14;
$SkillMultiplier[Rogue, $SkillPoisoning] = 17;
$SkillMultiplier[Rogue, $SkillHaggling] = 17;
$SkillMultiplier[Rogue, $SkillTravelling] = 12;
$EXPmultiplier[Rogue] = 1;

//--------------
// Bard
//--------------
//Bards are much like thieves, except that they are a bit more evenly balanced.

//Primary Skill: Stealing
//Secondary Skill: Archery

$SkillMultiplier[Bard, $SkillSlashing] = 13;
$SkillMultiplier[Bard, $SkillPiercing] = 15;
$SkillMultiplier[Bard, $SkillBludgeoning] = 13;
$SkillMultiplier[Bard, $SkillDodging] = 20;
$SkillMultiplier[Bard, $SkillWeightCapacity] = 8;
$SkillMultiplier[Bard, $SkillBashing] = 2;
$SkillMultiplier[Bard, $SkillStealing] = 20;
$SkillMultiplier[Bard, $SkillHiding] = 18;
$SkillMultiplier[Bard, $SkillBackstabbing] = 18;
$SkillMultiplier[Bard, $SkillOffensiveCasting] = 3;
$SkillMultiplier[Bard, $SkillDefensiveCasting] = 3;
$SkillMultiplier[Bard, $SkillNeutralCasting] = 5;
$SkillMultiplier[Bard, $SkillSpellResistance] = 5;
$SkillMultiplier[Bard, $SkillHealing] = 20;
$SkillMultiplier[Bard, $SkillArchery] = 14;
$SkillMultiplier[Bard, $SkillEndurance] = 20;
$SkillMultiplier[Bard, $SkillMining] = 20;
$SkillMultiplier[Bard, $SkillSpeech] = 10;
$SkillMultiplier[Bard, $SkillSenseHeading] = 15;
$SkillMultiplier[Bard, $SkillEnergy] = 06;
$SkillMultiplier[Bard, $SkillHaggling] = 20;
$EXPmultiplier[Bard] = 0.8;

//--------------
// Fighter
//--------------
// Masters of the martial arts, Fighters are unmatched when it comes to a toe-to-toe slugfest. However, once things like status effects and spells come into play, they need to be 
// careful. Fighters possess innately strong bodies, which gives them a significant advantage over mage classes, assuming both characters are new. As both characters progress,
// however, Fighters begin to lose their significant edge. Apprentice mages often seek Fighters as travelling companions to keep them safe from ruthless thugs. Fighters are still very 
// potent once mages leave their apprenticeship, but they have to be smarter about what fights they pick. Even so, Fighters are difficult to take down even when significantly weakened 
// with magic, owing to their outstanding physical stature. They are front-line opponents through and through.
//
// After a certain point, Fighters choose a weapon to specialize in. They learn special techniques with that weapon which are sure to give them the edge in any melee fight. Each
// class of weapon offers different advantages upon mastery, shaping the Fighter's fighting style as they progress. Fighters also know basic tools of the trade that they picked up from
// tours of military duty and current experiences, such as war cries and other leadership maneuvers, as well as several common fighting techniques.
// Fighters are a good choice for new players, since they are difficult to take down in a one-on-one fight without proper preparations, reducing their death rate. They also advance 
// quickly, allowing new players to see a higher level before permanent death occurs. Often, all they need to bring to a proper fight is themselves and their weapon, reducing the 
// know-how needed to play them effectively.
// The practical and constant nature of the Fighter's fighting as well as the narrow focus of their profession makes them apt at learning from their mistakes and learning new tricks, 
// and thus they have a slightly increased rate of experience gain.

//Favored Attributes: Strength and/or Dexterity, Constitution, Wisdom (for extra SP)

$SkillMultiplier[Fighter, $SkillSwords] = 19;
$SkillMultiplier[Fighter, $SkillDaggers] = 19;
$SkillMultiplier[Fighter, $SkillAxes] = 19;
$SkillMultiplier[Fighter, $SkillClubs] = 19;
$SkillMultiplier[Fighter, $SkillPolearms] = 19;
$SkillMultiplier[Fighter, $SkillArchery] = 15;
$SkillMultiplier[Fighter, $SkillDodging] = 16;
$SkillMultiplier[Fighter, $SkillParrying] = 19;
$SkillMultiplier[Fighter, $SkillBashing] = 16;
$SkillMultiplier[Fighter, $SkillTripping] = 16;
$SkillMultiplier[Fighter, $SkillArmorUse] = 19;
$SkillMultiplier[Fighter, $SkillTactics] = 12;
$SkillMultiplier[Fighter, $SkillMastery] = 12;
$SkillMultiplier[Fighter, $SkillHaggling] = 10;
$SkillMultiplier[Fighter, $SkillTravelling] = 13;
$EXPmultiplier[Fighter] = 1.15;

//--------------
// Paladin
//--------------
//Paladins are much like Fighters, except that they are a bit more evenly balanced.

//Primary Skill: Bludgeoning
//Secondary Skill: Healing

$SkillMultiplier[Paladin, $SkillSwords] = 15;
$SkillMultiplier[Paladin, $SkillPiercing] = 15;
$SkillMultiplier[Paladin, $SkillBludgeoning] = 12;
$SkillMultiplier[Paladin, $SkillDodging] = 15;
$SkillMultiplier[Paladin, $SkillWeightCapacity] = 15;
$SkillMultiplier[Paladin, $SkillBashing] = 15;
$SkillMultiplier[Paladin, $SkillStealing] = 3;
$SkillMultiplier[Paladin, $SkillHiding] = 3;
$SkillMultiplier[Paladin, $SkillBackstabbing] = 3;
$SkillMultiplier[Paladin, $SkillOffensiveCasting] = 2;
$SkillMultiplier[Paladin, $SkillDefensiveCasting] = 12;
$SkillMultiplier[Paladin, $SkillNeutralCasting] = 3;
$SkillMultiplier[Paladin, $SkillSpellResistance] = 9;
$SkillMultiplier[Paladin, $SkillHealing] = 13;
$SkillMultiplier[Paladin, $SkillArchery] = 12;
$SkillMultiplier[Paladin, $SkillEndurance] = 15;
$SkillMultiplier[Paladin, $SkillMining] = 10;
$SkillMultiplier[Paladin, $SkillSpeech] = 8;
$SkillMultiplier[Paladin, $SkillSenseHeading] = 5;
$SkillMultiplier[Paladin, $SkillEnergy] = 9;
$SkillMultiplier[Paladin, $SkillHaggling] = 13;
$EXPmultiplier[Paladin] = 1.0;

//--------------
// Ranger
//--------------
// Rangers are masters of the place between places, the untamed wilds. Rangers are notoriously difficult to kill, since their backyard is everywhere, and they're very good at eluding
// pursuers in the wild. They are extremely resourceful, and always know how to put together basic gear even when left with nothing. Rangers are well-suited to the bow and arrow, 
// since they spend so much time in open areas. It is a trivial task to survive as a Ranger; dangerous opponents are easy to evade, and food is plentiful and easy to hunt. Rangers are 
// connected to the earth, sky, and land around them in a very primal sense. They can exert control and perform rituals
// that onlookers would call magic to assist them. Rangers are never lost and have a very easy time travelling about the game world. Rangers can also use traps to help ambush an 
// unaware opponent. This is a very good choice for new players.

//Favored Attributes: Strength and/or Dexterity, Constitution, Wisdom

$SkillMultiplier[Ranger, $SkillClubs] = 16;
$SkillMultiplier[Ranger, $SkillDaggers] = 12;
$SkillMultiplier[Ranger, $SkillSwords] = 9;
$SkillMultiplier[Ranger, $SkillAxes] = 12;
$SkillMultiplier[Ranger, $SkillArchery] = 17;
$SkillMultiplier[Ranger, $SkillDodging] = 16;
$SkillMultiplier[Ranger, $SkillParrying] = 12;
$SkillMultiplier[Ranger, $SkillBashing] = 15;
$SkillMultiplier[Ranger, $SkillTripping] = 15;
$SkillMultiplier[Ranger, $SkillArmorUse] = 11;
$SkillMultiplier[Ranger, $SkillSurvival] = 17;
$SkillMultiplier[Ranger, $SkillCamouflage] = 16;
$SkillMultiplier[Ranger, $SkillMysticism] = 14;
$SkillMultiplier[Ranger, $SkillHunting] = 17;
$SkillMultiplier[Ranger, $SkillHaggling] = 07;
$SkillMultiplier[Ranger, $SkillTravelling] = 18;
$EXPmultiplier[Ranger] = 0.95;

//--------------
// Invoker
//--------------
// Invokers are masters of the wheel of elemental planes, drawing from the four primary planes and, later, the four intermediate planes.
// Each element has different spells, promoting a different play style. Spells do not become useless when you level up. Some are not designed for PvE at all.
// Invokers are difficult to play and are easily killed at low levels if the player is not aware of what they are doing. If the player wishes to go low-level PvP hunting,
// they will want to procure a wand. Invokers are awful at melee and should avoid it at all costs, except when they have the advantage (i.e. enchanted weapon).
// Most are moderately proficient with bashing weapons, however, since some spells directly affect your weapon and can be useful in an ambush to deal extra damage.
// Invokers have a somewhat reduced rate of experience gain, since most of their power comes from their library studies.

//Favored Attributes: Intelligence, Wisdom, Constitution

$SkillMultiplier[Invoker, $SkillClubs] = 9;
$SkillMultiplier[Invoker, $SkillDaggers] = 5;
$SkillMultiplier[Invoker, $SkillDodging] = 8;
$SkillMultiplier[Invoker, $SkillHaggling] = 10;
$SkillMultiplier[Invoker, $SkillFireAff] = 16;
$SkillMultiplier[Invoker, $SkillWaterAff] = 16;
$SkillMultiplier[Invoker, $SkillEarthAff] = 16;
$SkillMultiplier[Invoker, $SkillAirAff] = 16;
$SkillMultiplier[Invoker, $SkillLightningAff] = 12;
$SkillMultiplier[Invoker, $SkillOozeAff] = 12;
$SkillMultiplier[Invoker, $SkillIceAff] = 12;
$SkillMultiplier[Invoker, $SkillMagmaAff] = 12;
$SkillMultiplier[Invoker, $SkillTravelling] = 6;
$SkillMultiplier[Invoker, $SkillSpellcraft] = 16;
$EXPmultiplier[Invoker] = 0.8;

//--------------
// Necromancers
//--------------
// Often misjudged, Necromancers are nevertheless never truly pure; no good person could have committed the acts they did to get where they are now. As a Necromancer might tell you, 
// "Necromancy" is actually a very ill-defined popular term for a vague group of magical disciplines that are sometimes, but not necessarily always, related. Necromancers are a loosely
// defined community of brotherly individuals that commune to discuss their research. Around each other, they are inclusive, non-judgmental, warm and respectful. Towards anyone else 
// they feel complete apathy at best and utter hatred at worst. Despite their callousness, Necromancers are smart and resourceful. They are accustomed to laying low and living far 
// away from civilization due to the mutual hatred between them and the rest of society.
//
// Necromancers might be thought of as a mixture in playstyle of the Invoker, Cleric and Ranger. At character creation, they cannot choose any of the Good spheres for their 
// motivations. Necromancy is divided into four schools of magic: summoning, binding, pathomancy and channeling. Summoning covers the magic used to unearth and bind undead to the 
// Necromancer's service. At a fairly early stage in the skill path, the Necromancer unlocks the ability to revive a slain enemy and bind it to his service. However, the enemy's stats 
// will be reduced based on how low his Summoning skill is. Other summons will become available later in the path. Binding refers to magic that manipulates spirits and spiritual 
// energy. Necromancers can bind souls from fallen enemies and use them to cast deadly spells that rip at the soul of another target. Pathomancy is a biological school of magic that
// manipulates infections and rot. Necromancers can use this magic not only to inflict terrible plagues on their enemies, but also manipulate key bodily functions, including putting
// an unwitting victim to sleep. Finally, Channelling is the Necromancers' mockery of Invocation. Instead of drawing from an Elemental plane, it draws from the plane of Death, 
// harnessing the same energy used to fuel unlife. This energy can be used to manipulate the life force of an opponent, removing it altogether or transferring it to the Necromancer.
//
// The most prized possession of all Necromancers is the gift of eternal life; or, if that definition of life makes you uneasy, eternal existence. It is said that an unnatural level
// of mastery of the dark arts is necessary to draw the Necromancer's consciousness close enough to the plane of Death to transfer it to a more perfect body. Many theories exist on
// the possibilities of storing and manipulating one's own life force in order to achieve a state of eternal existence. 

//Favored Attributes: Intelligence, Wisdom, Constitution

$SkillMultiplier[Necromancer, $SkillDaggers] = 11;
$SkillMultiplier[Necromancer, $SkillClubs] = 10;
$SkillMultiplier[Necromancer, $SkillDodging] = 10;
$SkillMultiplier[Necromancer, $SkillHaggling] = 4;
$SkillMultiplier[Necromancer, $SkillSummoning] = 16;
$SkillMultiplier[Necromancer, $SkillBinding] = 16;
$SkillMultiplier[Necromancer, $SkillChannelling] = 16;
$SkillMultiplier[Necromancer, $SkillPathomancy] = 16;
$SkillMultiplier[Necromancer, $SkillTravelling] = 13;
$SkillMultiplier[Necromancer, $SkillSpellcraft] = 15;
$EXPmultiplier[Necromancer] = 0.9;

//######################################################################################
// Skill Restriction tables
//######################################################################################

//To determine skill restrictions, do the following:
//
//-Determine the following variables first:
//	(weapon):
//	a = ATK * 1.1 (archery is 0.75)
//	b = Delay = Cap((Weight / 3), 1, "inf")
//
//	(armor):
//	a = (DEF + MDEF) / 6
//	b = 1.0
//
//-To find out what the skill restriction number is, follow this formula, where s is the final skill restriction:
//	s = Cap((a / b) - 20), 0, "inf") * 10.0;
//

// Chat functions
$SkillRestriction["#say"] = $SkillSpeech @ " 0";
$SkillRestriction["#shout"] = $SkillSpeech @ " 0";
$SkillRestriction["#whisper"] = $SkillSpeech @ " 0";
$SkillRestriction["#tell"] = $SkillSpeech @ " 0";
$SkillRestriction["#global"] = $SkillSpeech @ " 0";
$SkillRestriction["#zone"] = $SkillSpeech @ " 0";
$SkillRestriction["#group"] = $SkillSpeech @ " 0";
$SkillRestriction["#party"] = $SkillSpeech @ " 0";
$SkillRestriction["#steal"] = $SkillStealing @ " 150";
$SkillRestriction["#pickpocket"] = $SkillStealing @ " 2700";
$SkillRestriction["#mug"] = $SkillStealing @ " 6200";
$SkillRestriction["#compass"] = $SkillTravelling @ " 150";
$SkillRestriction["#track"] = $Travelling @ " 500";
$SkillRestriction["#trackpack"] = $Travelling @ " 1200";
$SkillRestriction["#hide"] = $SkillHiding @ " 150";
$SkillRestriction["#bash"] = $SkillBashing @ " 150";
$SkillRestriction["#shove"] = $SkillBashing @ " 50";
$SkillRestriction["#zonelist"] = $SkillTravelling @ " 450";
$SkillRestriction["#advcompass"] = $SkillTravelling @ " 200";


// Fire Spells
$SkillRestriction[channelheat] = $SkillFireAff @ " 200";
$SkillRestriction[firewall] = $SkillFireAff @ " 1000";
$SkillRestriction[fireball] = $SkillFireAff @ " 1900";
$SkillRestriction[combust] = $SkillFireAff @ " 2600";
$SkillRestriction[heatmetal] = $SkillFireAff @ " 3200";
$SkillRestriction[dbf] = $SkillFireAff @ " 4600";
$SkillRestriction[fireshield] = $SkillFireAff @ " 5500";
$SkillRestriction[haste] = $SkillFireAff @ " 6800";
$SkillRestriction[nova] = $SkillFireAff @ " 8800";

// Earth Spells
$SkillRestriction[tremor] = $SkillEarthAff @ " 150";
$SkillRestriction[crystallize] = $SkillEarthAff @ " 550";
$SkillRestriction[fragment] = $SkillEarthAff @ " 1300";
$SkillRestriction[rockslide] = $SkillEarthAff @ " 2150";
$SkillRestriction[dig] = $SkillEarthAff @ " 3500";
$SkillRestriction[shunt] = $SkillEarthAff @ " 5000";
$SkillRestriction[earthshield] = $SkillEarthAff @ " 5500";
$SkillRestriction[slow] = $SkillEarthAff @ " 6400";
$SkillRestriction[stonehail] = $SkillEarthAff @ " 800";

// Water Spells
$SkillRestriction[slip] = $SkillWaterAff @ " 150";
$SkillRestriction[douse] = $SkillWaterAff @ " 500";
$SkillRestriction[drown] = $SkillWaterAff @ " 1400";
$SkillRestriction[torrent] = $SkillWaterAff @ " 2600";
$SkillRestriction[whirlpool] = $SkillWaterAff @ " 3700";
$SkillRestriction[saturate] = $SkillWaterAff @ " 5100";
$SkillRestriction[watershield] = $SkillWaterAff @ " 5500";
$SkillRestriction[ridethewaves] = $SkillWaterAff @ " 6400";
$SkillRestriction[geyser] = $SkillWaterAff @ " 8500";

// Air Spells
$SkillRestriction[shove] = $SkillAirAff @ " 150";
$SkillRestriction[invis] = $SkillAirAff @ " 500";
$SkillRestriction[purge] = $SkillAirAff @ " 1400";
$SkillRestriction[windwall] = $SkillAirAff @ " 2400";
$SkillRestriction[buffet] = $SkillAirAff @ " 3800";
$SkillRestriction[airshield] = $SkillAirAff @ " 5500";
$SkillRestriction[ridethewinds] = $SkillAirAff @ " 6400";
$SkillRestriction[improvedinvis] = $SkillAirAff @ " 8000";
$SkillRestriction[vortex] = $SkillAirAff @ " 9000";

// Ice Spells
$SkillRestriction[frostshards] = $SkillIceAFf @ " 250"; 
$SkillRestriction[frozenheart] = $SkillIceAFf @ " 750"; 
$SkillRestriction[frostnova] = $SkillIceAff @ " 1400";
$SkillRestriction[frostbite] = $SkillIceAff @ " 2600";
$SkillRestriction[coldsnap] = $SkillIceAff @ " 4000";
$SkillRestriction[iceshield] = $SkillIceAff @ " 5500";
$SkillRestriction[icebody] = $SkillIceAff @ " 7400";
$SkillRestriction[direhail] = $SkillIceAff @ " 9500"; 

// Lightning Spells
$SkillRestriction[shockingtouch] = $SkillIceAFf @ " 150"; 
$SkillRestriction[repulse] = $SkillIceAff @ " 700";
$SkillRestriction[electrocute] = $SkillIceAff @ " 1400";
$SkillRestriction[lightningbolt] = $SkillIceAff @ " 2500"; 
$SkillRestriction[conduit] = $SkillIceAff @ " 3800"; 
$SkillRestriction[lightningshield] = $SkillIceAff @ " 5500"; 
$SkillRestriction[chainlightning] = $SkillIceAff @ " 7500"; 
$SkillRestriction[deathimpulse] = $SkillIceAff @ " 9500"; 

// Paraelemental
$SkillRestriction[smokecloud] = $SkillAirAff @ " 2400 " @ $SkillFireAff @ " 3800";
$SkillRestriction[embercloud] = $SkillAirAff @ " 4800 " @ $SkillFireAff @ " 7600";
$SkillRestriction[napalm] = $SkillOozeAff @ " 4000 " @ $SkillFireAff @ " 4000";
$SkillRestriction[cloud] = $SkillAirAff @ " 6000 " @ $SkillLightningAff @ " 4000";
$SkillRestriction[flameweapon] = $SkillFireAff @ " 2000 " @ $SkillEarthAff @  " 2000";
$SkillRestriction[chargeweapon] = $SkillLightningAff @ " 2000 " @ $SkillEarthAff @  " 2000";
$SkillRestriction[acidicweapon] = $SkillOozeAff @ " 2000 " @ $SkillEarthAff @  " 2000";

// Summoning Spells
$SkillRestriction[raisedead] = $SkillSummoning @ " 500"; 
$SkillRestriction[animategolem] = $SkillSummoning @ " 2000"; 
$SkillRestriction[bulwark] = $SkillSummoning @ " 3000"; 

// Binding Spells
$SkillRestriction[bind] = $SkillBinding @ " 200"; 
$SkillRestriction[curse] = $SkillBinding @ " 300"; 
$SkillRestriction[haunt] = $SkillBinding @ " 900"; 
$SkillRestriction[horror] = $SkillBinding @ " 1600"; 

// Channelling Spells
$SkillRestriction[lifeshock] = $SkillChannelling @ " 2200"; 
$SkillRestriction[gate] = $SkillChannelling @ " 5000"; 
$SkillRestriction[call] = $SkillChannelling @ " 7000"; 
$SkillRestriction[powerwordkill] = $SkillChannelling @ " 9000"; 

// Pathomancy spells
$SkillRestriction[sleep] = $SkillPathomancy @ " 500"; 
$SkillRestriction[blind] = $SkillPathomancy @ " 1500"; 
$SkillRestriction[ghoultouch] = $SkillPathomancy @ " 2700"; 
$SkillRestriction[crimsonscourge] = $SkillPathomancy @ " 5800"; 

//######################################################################################
// Skill functions
//######################################################################################

function GetNumSkills()
{
	dbecho($dbechoMode, "GetNumSkills()");
	%c = 0;
	for(%i = 1; $SkillDesc[%i] != ""; %i++){
		%c++;
	}
	return %c;
}

function GetClassSkills(%clientId)
{
	dbecho($dbechoMode, "GetClassSkills()");
	%c = 0;
	for(%i = 1; $SkillDesc[%i] != ""; %i++){
		if(String::findsubstr($SkillGroup[%i], fetchData(%clientId,
{
	return $PlayerSkill[%clientId, %skill];
}
function GetSkillMultiplier(%clientId, %skill)
{
	dbecho($dbechoMode, "GetSkillMultiplier(" @ %clientId @ ", " @ %skill @ ")");

	%a = $SkillMultiplier[fetchData(%clientId, "CLASS"), %skill];
	%b = fetchData(%clientId, "RemortStep") * 10;

	%c = Cap(%a + %b, "inf", 300);

	return %c;
}
function GetEXPmultiplier(%clientId)
{
	dbecho($dbechoMode, "GetEXPmultiplier(" @ %clientId @ ")");

	%a = $EXPmultiplier[fetchData(%clientId, "CLASS")];

	return %a;
}

function SetAllSkills(%clientId, %n)
{
	dbecho($dbechoMode, "SetAllSkills(" @ %clientId @ ", " @ %n @ ")");

	for(%i = 1; $SkillDesc[%i] != ""; %i++)
		$PlayerSkill[%clientId, %i] = %n;
}

function SkillCanUse(%clientId, %thing)
{
	dbecho($dbechoMode, "SkillCanUse(" @ %clientId @ ", " @ %thing @ ")");

	if(%clientId.adminLevel >= 5)
		return True;

	%flag = 0;
	%gc = 0;
	%gcflag = 0;
	for(%i = 0; GetWord($SkillRestriction[%thing], %i) != -1; %i+=2)
	{
		%s = GetWord($SkillRestriction[%thing], %i);
		%n = GetWord($SkillRestriction[%thing], %i+1);

		if(%s == "L")
		{
			if(fetchData(%clientId, "LVL") < %n)
				%flag = 1;
		}
		else if(%s == "R")
		{
			if(fetchData(%clientId, "RemortStep") < %n)
				%flag = 1;
		}
		else if(%s == "A")
		{
			if(%clientId.adminLevel < %n)
				%flag = 1;
		}
		else if(%s == "G")
		{
			%gcflag++;
			if(String::ICompare(fetchData(%clientId, "GROUP"), %n) == 0)
				%gc = 1;
		}
		else if(%s == "C")
		{
			%gcflag++;
			if(String::ICompare(fetchData(%clientId, "CLASS"), %n) == 0)
				%gc = 1;
		}
		else if(%s == "H")
		{
			%hflag++;
			if(String::ICompare(fetchData(%clientId, "MyHouse"), %n) == 0)
				%hh = 1;
		}
		else
		{
			if($PlayerSkill[%clientId, %s] < %n)
				%flag = 1;
		}
	}

	//First, if there are any class/group restrictions, house restrictions, check these first.
	if(%gcflag > 0)
	{
		if(%gc == 0)
			%flag = 1;
	}
	if(%hflag > 0)
	{
		if(%hh == 0)
			%flag = 1;
	}

	
	if(%flag != 1)
		return True;
	else
		return False;
}

function UseSkill(%clientId, %skilltype, %successful, %showmsg, %base, %refreshall)
{
	dbecho($dbechoMode, "UseSkill(" @ %clientId @ ", " @ %skilltype @ ", " @ %successful @ ", " @ %showmsg @ ", " @ %base @ ", " @ %refreshall @ ")");

	if(%base == "") %base = 35;

	%ub = ($skillRangePerLevel * fetchData(%clientId, "LVL")) + 20 + fetchData(%clientId, "RemortStep");
	if($PlayerSkill[%clientId, %skilltype] < %ub)
	{
		if(%successful)
			$SkillCounter[%clientId, %skilltype] += 1;
		else
			$SkillCounter[%clientId, %skilltype] += 0.05;

		%p = 1 - ($PlayerSkill[%clientId, %skilltype] / 1150);
		%e = round( (%base / GetSkillMultiplier(%clientId, %skilltype)) * %p );

		if($SkillCounter[%clientId, %skilltype] >= %e)
		{
			$SkillCounter[%clientId, %skilltype] = 0;
			%retval = AddSkillPoint(%clientId, %skilltype, 1);

			if(%retval)
			{
				if(%showmsg)
					Client::sendMessage(%clientId, $MsgBeige, "You have increased your skill in " @ $SkillDesc[%skilltype] @ " (" @ $PlayerSkill[%clientId, %skilltype] @ ")");
				if(%refreshall)
					RefreshAll(%clientId);
			}
		}
	}
}

function WhatSkills(%thing)
{
	dbecho($dbechoMode, "WhatSkills(" @ %thing @ ")");

	%t = "";
	for(%i = 0; GetWord($SkillRestriction[%thing], %i) != -1; %i+=2)
	{
		%s = GetWord($SkillRestriction[%thing], %i);
		%n = GetWord($SkillRestriction[%thing], %i+1);

		%t = %t @ $SkillDesc[%s] @ ": " @ %n @ ", ";
	}
	if(%t == "")
		%t = "None";
	else
		%t = String::getSubStr(%t, 0, String::len(%t)-2);
	
	return %t;
}

function GetSkillAmount(%thing, %skill)
{
	dbecho($dbechoMode, "GetSkillAmount(" @ %thing @ ", " @ %skill @ ")");

	for(%i = 0; GetWord($SkillRestriction[%thing], %i) != -1; %i+=2)
	{
		%s = GetWord($SkillRestriction[%thing], %i);

		if(%s == %skill)
			return GetWord($SkillRestriction[%thing], %i+1);
	}
	return 0;
}