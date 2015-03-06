//This file is part of Tribes RPG.
//Tribes RPG server side scripts
//Belt system written by Jason "phantom" Daley, and Carling

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



// ---------------------------------------
//
// Updated and ported by phantom
// 09-05-2010 - 04-05-2014
// It has been recoded to be compatible TvT.


	return %disp[%type];

$belttypelist = "AmmoItems GemItems";
function belt::checkmenus(%clientId)


	%optionsPerPage = 7;


	for(%i = %lb; %i <= %ub; %i++)


	if(%type == "AmmoItems"){

	if(!$playerNoDrop[%item]){
		Client::addMenuItem(%clientId, %cnt++ @ "Drop "@%amnt, %type@" drop "@%item@" "@%amnt);
}

	else if(%option == "back")
	else if(%option == "arm")
	return;
}



function MenuSellBelt(%clientId, %page)

function processMenuSellBelt(%clientId, %opt)






function MenuSellBeltItemFinal(%clientid, %item, %type)



function processMenuBuyBeltItemFinal(%clientId, %opt)

function processMenuSellBeltItemFinal(%clientId, %opt)

//-----------------------------------------------------------------
function MenuStoreBelt(%clientId, %page)
}

function processMenuStoreBelt(%clientId, %opt)
function belt::checkbankmenus(%clientId)
function belt::buildBankMenu(%clientId, %page){
function MenuWithdrawBelt(%clientId, %page)
function processMenuWithdrawBelt(%clientId, %opt)
function MenuStoreBeltItem(%clientid, %type, %page)
function processMenuStoreBeltItem(%clientid, %opt)
function MenuStoreBeltItemFinal(%clientid, %item, %type)


//---------------------------
function MenuWithdrawBeltItemFinal(%clientid, %item, %type)


function BeltItem::Add(%name,%item,%type,%weight,%cost)
	%num = $count[%type]++;

function Belt::TakeThisStuff(%clientid,%item,%amnt)
function isBeltItem(%item)
function Belt::AddToList(%list, %item)
function Belt::BankGiveThisStuff(%clientid, %item, %amnt)
function Belt::BankHasThisStuff(%clientid,%item)

function Belt::packgen(%clientId, %tmploot){