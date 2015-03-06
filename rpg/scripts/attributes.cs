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

// This file lays out the attributes and their individual effects on skills, as well as other effects they might have.
// The attributes are Strength, Dexterity, Constitution, Intelligence, and Wisdom.
// In addition, 4 LCK is worth one attribute point.
//
// The modifiers themselves are used for different things. Strength adds melee damage and encumbrance load.
// Dexterity assists with dodging, attack and cast speed, and archery damage by way of precision accuracy.
// Bonus values do not accrue until the points in the stat are above 10. So, a 14 in Strength renders a 40% damage bonus to melee.

// Attribute to Skill Modifier
$AttributeToSkillMod = 0.05; // Skills governed by a specific attribute get 5% better with each point of that attribute over 10

// Strength modifiers
$AttributeModifiers[Strength, CarryingBonus] = 0.25; // 50 pounds base carry; 25% extra per point of strength (multiplicative)

// Dexterity modifiers
$AttributeModifiers[Dexterity, SpeedBonus] = 0.05; // 5% faster attack and cast speed per point of dexterity 

// Constitution modifiers
$AttributeModifiers[Constitution, HPBonus] = 1; // 1 extra hitpoint per level per point of Constitution 
$AttributeModifiers[Constitution, SaveBonus] = 0.05; // 5% better chance to avoid specific spell effects

// Intelligence modifiers
$AttributeModifiers[Intelligence, SkillBonus] = 0.1; // .1 higher skill multiplier per point of intellect
$AttributeModifiers[Intelligence, ManaBonus] = 2; // 2 extra mana point per level per point of intellect

// Wisdom modifiers
$AttributeModifiers[Wisdom, SkillPointBonus] = 3; // 3 extra skill points per level point of wisdom
$AttributeModifiers[Wisdom, SaveBonus] = 0.05; // 5% better chance to avoid specific spell effects

// Racial modifiers XPRate indicates how much XP the race needs proportionally to level up. "1" is normal, or 1000 XP per level.
$RaceModifiers[Human, Strength] = 0;
$RaceModifiers[Human, Dexterity] = 0;
$RaceModifiers[Human, Constitution] = 0;
$RaceModifiers[Human, Intelligence] = 0;
$RaceModifiers[Human, Wisdom] = 0;
$RaceModifiers[Human, XPRate] = 0.9;

$RaceModifiers[Elf, Strength] = 0;
$RaceModifiers[Elf, Dexterity] = 2;
$RaceModifiers[Elf, Constitution] = -2;
$RaceModifiers[Elf, Intelligence] = 2;
$RaceModifiers[Elf, Wisdom] = 1;
$RaceModifiers[Elf, XPRate] = 1.2;

$RaceModifiers[Dwarf, Strength] = 1;
$RaceModifiers[Dwarf, Dexterity] = -1;
$RaceModifiers[Dwarf, Constitution] = 2;
$RaceModifiers[Dwarf, Intelligence] = 0;
$RaceModifiers[Dwarf, Wisdom] = 0;
$RaceModifiers[Dwarf, XPRate] = 1.1;

$RaceModifiers[Orc, Strength] = 2;
$RaceModifiers[Orc, Dexterity] = 0;
$RaceModifiers[Orc, Constitution] = 1;
$RaceModifiers[Orc, Intelligence] = -2;
$RaceModifiers[Orc, Wisdom] = -1;
$RaceModifiers[Orc, XPRate] = 1;

$RaceMaximum[Human, STR] = 20;
$RaceMaximum[Human, DEX] = 20;
$RaceMaximum[Human, CON] = 20;
$RaceMaximum[Human, INT] = 20;
$RaceMaximum[Human, WIS] = 20;

$RaceMaximum[Elf, STR] = 20;
$RaceMaximum[Elf, DEX] = 24;
$RaceMaximum[Elf, CON] = 18;
$RaceMaximum[Elf, INT] = 24;
$RaceMaximum[Elf, WIS] = 23;

$RaceMaximum[Dwarf, STR] = 22;
$RaceMaximum[Dwarf, DEX] = 18;
$RaceMaximum[Dwarf, CON] = 24;
$RaceMaximum[Dwarf, DEX] = 20;
$RaceMaximum[Dwarf, INT] = 19;
$RaceMaximum[Dwarf, WIS] = 21;

$RaceMaximum[Orc, STR] = 24;
$RaceMaximum[Orc, DEX] = 20;
$RaceMaximum[Orc, CON] = 22;
$RaceMaximum[Orc, INT] = 16;
$RaceMaximum[Orc, WIS] = 18;

function AddAttributePoint(%clientId, %att, %val) {
	dbecho($dbechoMode, "AddAttributePoint(" @ %clientId @ ", " @ %att @ ", " @ %val @ ")");
	%race = parseGender(fetchData(%clientId, "RACE"));
	%current = fetchData(%clientId, %att);
	if(%val == "")
		%val = 1;

	if((%current + %val) > $RaceMaximum[%race, %att])
		return False;
	else {
//		storeData(%clientId, %att, 
	}
	
}

