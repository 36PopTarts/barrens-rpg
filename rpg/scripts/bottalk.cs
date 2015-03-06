//This file is part of Tribes RPG.
//Tribes RPG server side scripts
//New NPC Chat menu system written by Jason "phantom" Daley, tribesrpg.org

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

function NewBotMessage(%client, %closestId, %aimessage){//, %list){
	%clientId = %client;
	if(%client.tmpbottalk == "chat"){
		AI::sayLater(%client, %closestId, %aimessage, True);
		for(%i = 0; $botMenuOption[%client,%i] != ""; %i++)
			$botMenuOption[%client,%i] = "";
		%client.tmpbottalk = "";
		return;
	}

	%aiName = %closestId.name;
	if(%client.repack > 15)//Can have longer messages
		%menuname = "Conversation with "@$BotInfo[%ainame, NAME];
	else
		%menuname = $BotInfo[%ainame, NAME];

	disableOverrides(%client);
	%client.keyOverride = "bottalk";
	%client.overrideKeybinds = True;
	%clientPos = GameBase::getPosition(%client);
	%botPos = GameBase::getPosition(%closestId);
	%closest = Vector::getDistance(%clientPos, %botPos);

	if(%closest > ($maxAIdistVec + ($PlayerSkill[%client, $SkillSpeech] / 50)))
	{
		$state[%closestId, %client] = "";
		endBotTalkChoice(%client);
		return;
	}

	%msg = %menuname@"\n<jc>"@%aimessage@"\n\n<f2>";
	%max = 10;
	%cnt = 0;

	for(%i = 0; $botMenuOption[%client,%i] != ""; %i++)
	{
		%trigger = $botMenuOption[%client,%i];
		if((%break = string::findsubstr(%trigger, "|")) > 0){
			%trigger1 = string::getsubstr(%trigger, 0, %break);
			%trigger2 = string::getsubstr(%trigger, %break+1, 999);
		}
		else{
			%trigger1 = %trigger;
			%trigger2 = %trigger;
		}
		%cnt++;
		%msg = %msg @ %cnt@": "@%trigger1@"\n";
	}
	%client.curNPC = %closestId;
	%msg = %msg @ "\n\n0: Close menu.";
	rpg::longPrint(%client,%msg,1,0.7);

	%aiMessage = escapeString(%aiMessage);
	schedule::add("NewBotMessage("@%client@","@%closestId@",\""@%aimessage@"\");",0.4,"NewBotMessage"@%client);
}


function endBotTalkChoice(%client){
	%client.curNPC = "";
	bottomPrint(%client,"",0);
	disableOverrides(%client);
	for(%i = 0; $botMenuOption[%client,%i] != ""; %i++)
	{
		$botMenuOption[%client,%i] = "";
	}
	$yousaid[%client] = "";
}


function bottalkChoice(%client,%key){
	if(%key == 0){
		endBotTalkChoice(%client);
		return;
	}
		%object = %client.curNPC;
		for(%i = 0; $botMenuOption[%client,%i] != ""; %i++)
		{
			%trigger = $botMenuOption[%client,%i];
			if((%break = string::findsubstr(%trigger, "|")) > 0){
				%trigger1 = string::getsubstr(%trigger, 0, %break);
				%trigger2 = string::getsubstr(%trigger, %break+1, 999);
			}
			else{
				%trigger1 = %trigger;
				%trigger2 = %trigger;
			}
			%cnt++;
			if(%cnt == %key){
				%msg = %trigger2;
				%validOption = True;
				break;
			}
		}

	if(%validOption){
		endBotTalkChoice(%client);
		$yousaid[%client] = %msg;
		eval("bottalk::"@clipTrailingNumbers(%object.name)@"("@%client@","@%object@",False,\"#say "@%msg@"\");");
	}
	else{
		AI::sayLater(%client, %object, "What was that? Please pick an option on the list.", True);
	}
}



function processbottalk(%clientId,%TrueClientId,%message,%cropped,%w1){


	//process TownBot talk

	%initTalk = False;
	for(%i = 0; (%w = GetWord("hail hello hi greetings yo hey sup salutations g'day howdy", %i)) != -1; %i++)
		if(String::ICompare(%cropped, %w) == 0)
			%initTalk = True;

	%clientPos = GameBase::getPosition(%TrueClientId);
	%closest = 5000000;

	for(%i = 0; (%id = GetWord($TownBotList, %i)) != -1; %i++)
	{
		%botPos = GameBase::getPosition(%id);
		%dist = Vector::getDistance(%clientPos, %botPos);

		if(%dist < %closest)
		{
			%closest = %dist;
			%closestId = %id;
			%closestPos = %botPos;
		}
	}


	%aiName = %closestId.name;
	%displayName = $BotInfo[%aiName, NAME];




	if(%closest <= ($maxAIdistVec + ($PlayerSkill[%TrueClientId, $SkillSpeech] / 50)) && Client::getTeam(%TrueClientId) == GameBase::getTeam(%closestId))
	{

		//pecho(%aiName @ " " @ %closestId);
		if(%TrueClientId.curNPC != "")
			endBotTalkChoice(%TrueClientId);
		if(%initTalk)
		{
			//Rotate Bot to look at player
			%rot = Vector::getRotation(Vector::normalize(Vector::sub(%clientPos, %closestPos)));
			%rot = "0 -0 "@GetWord(%rot, 2);
			GameBase::setRotation(%closestId, %rot);
		}

		if(String::findSubStr(%cropped, "\"") != -1){
			return;
		}

		%TrueClientId.tmpbottalk = "chat";
		%fname = clipTrailingNumbers(%aiName);
		eval("bottalk::"@%fName@"("@%TrueClientId@","@%closestId@","@%initTalk@",\""@escapestring(%message)@"\");");
		echo("bottalk::"@%fName@"("@%TrueClientId@","@%closestId@","@%initTalk@",\""@escapestring(%message)@"\");");
	}
	else
	{
		//This condition occurs when you are talking from too far of any TownBot.  All states are cleared here.
		//This means that potentially, you could initiate a conversation with the banker, travel for an hour
		//WITHOUT saying a word, come back and continue the conversation.  As soon as you speak in a way that
		//townbots hear you (#say, #shout, #tell) and are too far from them, all conversations are reset.

		//This is old code but I am leaving it in just because it could still be useful.

		for(%i = 0; (%id = GetWord($TownBotList, %i)) != -1; %i++)
			$state[%id, %TrueClientId] = "";
	}

}


function bottalk::merchant(%TrueClientId, %closestId, %initTalk, %message){
	//process merchant code
	%trigger[2] = "buy";
	if(%initTalk)
	{
		$botMenuOption[%TrueClientId,0] = "I would like to buy something.";
		NewBotMessage(%TrueClientId, %closestId, "Did you come to see what items you can buy?");
		$state[%closestId, %TrueClientId] = 1;
	}
	else if($state[%closestId, %TrueClientId] == 1)
	{
		if(String::findSubStr(%message, %trigger[2]) != -1)
		{
			SetupShop(%TrueClientId, %closestId);
			AI::sayLater(%TrueClientId, %closestId, "Take a look at what I have.", True);
			$state[%closestId, %TrueClientId] = "";
		}
	}
}


function bottalk::banker(%TrueClientId, %closestId, %initTalk, %message){
	//process banker code
	%trigger[2] = "deposit";
	%trigger[3] = "withdraw";
	%trigger[4] = "storage";
	%aiName = %closestId.name;
	if(%initTalk)
	{
		if(%TrueClientId.repack < 16) {
			$botMenuOption[%TrueClientId,0] = "deposit";
			$botMenuOption[%TrueClientId,1] = "withdraw";
			$botMenuOption[%TrueClientId,2] = "storage";
		}
		else {
			$botMenuOption[%TrueClientId,0] = "I would like to deposit coins.";
			$botMenuOption[%TrueClientId,1] = "I would like to withdraw coins.";
			$botMenuOption[%TrueClientId,2] = "I would like to check my storage.";
		}
		NewBotMessage(%TrueClientId, %closestId, "I can keep your money from being stolen by thieves.  DEPOSIT, WITHDRAW or look at your STORAGE?  You are carrying " @ fetchData(%TrueClientId, "COINS") @ " coins and I have " @ fetchData(%TrueClientId, "BANK") @ " of yours.");
		$state[%closestId, %TrueClientId] = 1;
	}
	else if($state[%closestId, %TrueClientId] == 1)
	{
			%msg = "How much do you want me to hold? You are carrying " @ fetchData(%TrueClientId, "COINS") @ " coins and I have " @ fetchData(%TrueClientId, "BANK") @ " of yours.";
			if(%client.tmpbottalk == "chat")
				%msg = %msg @ " You may also <f1>#say<f0> an amount.";
		if(String::findSubStr(%message, %trigger[3]) != -1)
			%msg = "How much do you want to take out? You are carrying " @ fetchData(%TrueClientId, "COINS") @ " coins and I have " @ fetchData(%TrueClientId, "BANK") @ " of yours.";
			if(%client.tmpbottalk == "chat")
				%msg = %msg  @ " You may also <f1>#say<f0> an amount.";
		if(String::findSubStr(%message, %trigger[4]) != -1)
		{
			//storage
			AI::sayLater(%TrueClientId, %closestId, "This is the equipment you have stored here.", True);
			SetupBank(%TrueClientId, %closestId);
			$state[%closestId, %TrueClientId] = "";
		}
	}
	else if($state[%closestId, %TrueClientId] == 2)
	{
		//deposit
		if(%cropped == "all")
			%cropped = fetchData(%TrueClientId, "COINS");
		
		%c = floor(%cropped);
		if(%c <= 0)
		{
			NewBotMessage(%TrueClientId, %closestId, "Huh? I didn't understand that. Can you say that more clearly?");
			//AI::sayLater(%TrueClientId, %closestId, "Invalid request.  Your transaction has been cancelled.~wError_Message.wav", True);
		}
		else if(%c <= fetchData(%TrueClientId, "COINS"))
		{
			storeData(%TrueClientId, "BANK", %c, "inc");
			storeData(%TrueClientId, "COINS", %c, "dec");
			RefreshAll(%TrueClientId);
			NewBotMessage(%TrueClientId, %closestId, "You have given me " @ %c @ " coins.  You are now carrying " @ fetchData(%TrueClientId, "COINS") @ " coins and I have " @ fetchData(%TrueClientId, "BANK") @ " of yours.  Have a nice day.");

			playSound(SoundMoney1, GameBase::getPosition(%closestId));
		}
		else
		{
			NewBotMessage(%TrueClientId, %closestId, "Sorry, you don't seem to have that many coins.");
			//AI::sayLater(%TrueClientId, %closestId, "Sorry, you don't seem to have that many coins.  Your transaction has been cancelled.", True);
			//beep beep robo-banker sez "duz not compute"
		}
		$state[%closestId, %TrueClientId] = "";
	}
	else if($state[%closestId, %TrueClientId] == 3)
	{
		//withdraw
		if(%cropped == "all")
			%cropped = fetchData(%TrueClientId, "BANK");
		%c = floor(%cropped);
		if(%c <= 0)
		{
			NewBotMessage(%TrueClientId, %closestId, "Huh? didn't understand that. Can you say that more clearly?");
			//AI::sayLater(%TrueClientId, %closestId, "Invalid request.  Your transaction has been cancelled.~wError_Message.wav", True);
			//BEEP BOOP
		}
	else if(%c <= fetchData(%TrueClientId, "BANK"))
		{
			storeData(%TrueClientId, "COINS", %c, "inc");
			storeData(%TrueClientId, "BANK", %c, "dec");
			RefreshAll(%TrueClientId);
			NewBotMessage(%TrueClientId, %closestId, "I have given you " @ %c @ " coins.  You are now carrying " @ fetchData(%TrueClientId, "COINS") @ " coins and I have " @ fetchData(%TrueClientId, "BANK") @ " of yours.  Have a nice day.");

			playSound(SoundMoney1, GameBase::getPosition(%TrueClientId));
		}
		else
		{
			NewBotMessage(%TrueClientId, %closestId, "I'm sorry but you don't have that many coins in my bank.");
			//AI::sayLater(%TrueClientId, %closestId, "I'm sorry but you don't have that many coins in my bank.  Your transaction has been cancelled.", True);
			//You know, Robots was a pretty decent movie, you should watch it.
		}
		$state[%closestId, %TrueClientId] = "";
	}
}





function bottalk::quest(%TrueClientId, %closestId, %initTalk, %message){
	%aiName = %closestId.name;
	//process quest code
	%trigger[2] = $BotInfo[%aiName, CUE, 1];
	%trigger[3] = $BotInfo[%aiName, NCUE, 1];
	%trigger[4] = "buy";

	%hasTheStuff = HasThisStuff(%TrueClientId, $BotInfo[%aiName, NEED]);

	if($BotInfo[%aiName, CSAY] == "" && %hasTheStuff == 666)
		%hasTheStuff = False;
	if($BotInfo[%aiName, LSAY] == "" && %hasTheStuff == 667)
		%hasTheStuff = False;



	if(%hasTheStuff == 666 && %initTalk)// $state[%closestId, %TrueClientId] == "")
	{
		NewBotMessage(%TrueClientId, %closestId, $BotInfo[%aiName, CSAY], True);
		$state[%closestId, %TrueClientId] = -5;
	}
	else if(%hasTheStuff == 667 && %initTalk)// $state[%closestId, %TrueClientId] == "")
	{
		NewBotMessage(%TrueClientId, %closestId, $BotInfo[%aiName, LSAY], True);
		$state[%closestId, %TrueClientId] = -5;
	}
	else if(%hasTheStuff == False)
	{
		if(%initTalk)
		{
			$botMenuOption[%TrueClientId,0] = %trigger[2];
			$botMenuOption[%TrueClientId,1] = "Have anything for me to buy?";
			NewBotMessage(%TrueClientId, %closestId, $BotInfo[%aiName, SAY, 1] @ " [" @ %trigger[2] @ "]", True);
			$state[%closestId, %TrueClientId] = 1;
		}
		else if($state[%closestId, %TrueClientId] == 1)
		{
			if(String::findSubStr(%message, %trigger[2]) != -1)
			{
				NewBotMessage(%TrueClientId, %closestId, $BotInfo[%aiName, SAY, 2], True);
				$state[%closestId, %TrueClientId] = "";
			}
		}
	}
	else if(%hasTheStuff == True)
	{
		if(%initTalk)
		{
			$botMenuOption[%TrueClientId,0] = %trigger[3];
			$botMenuOption[%TrueClientId,1] = "Have anything for me to buy?";
			NewBotMessage(%TrueClientId, %closestId, $BotInfo[%aiName, NSAY, 1] @ " [" @ %trigger[3] @ "]", True);
			$state[%closestId, %TrueClientId] = 1;
		}
		else if($state[%closestId, %TrueClientId] == 1)
		{
			if(String::findSubStr(%message, %trigger[3]) != -1)
			{
				if(HasThisStuff(%TrueClientId, $BotInfo[%aiName, NEED]))
				{
					if($BotInfo[%aiName, TAKE] != "")
						TakeThisStuff(%TrueClientId, $BotInfo[%aiName, TAKE], True);
					if($BotInfo[%aiName, GIVE] != "")
						GiveThisStuff(%TrueClientId, $BotInfo[%aiName, GIVE], True);

					NewBotMessage(%TrueClientId, %closestId, $BotInfo[%aiName, NSAY, 2], True);
				}
				else
					AI::sayLater(%TrueClientId, %closestId, "Nice try, I'm keeping what I managed to get from you.", True);
	
				$state[%closestId, %TrueClientId] = "";
				Game::refreshClientScore(%TrueClientId);
			}
		}
	}
}


	%aiName = %closestId.name;

function bottalk::blacksmith(%TrueClientId, %closestId, %initTalk, %message){
	%aiName = %closestId.name;
	//process smith code
	%trigger[2] = "buy";
	%trigger[3] = "smith";

	if(%initTalk)
	{
		if($BotInfo[%aiName, SHOP] != "")
			$botMenuOption[%TrueClientId,0] = "Buy";
		NewBotMessage(%TrueClientId, %closestId, "Hail friend, look at the anvil and say #smith to smith things.");
		$state[%closestId, %TrueClientId] = 1;

		//We stop using the blacksmith because it isn't belt-compatible.
		return;
		$botMenuOption[%TrueClientId,0] = "Yeah I'd like to smith.";
		NewBotMessage(%TrueClientId, %closestId, "Hail friend, are you here to have me SMITH an old weapon?");
		$state[%closestId, %TrueClientId] = 1;
	}
	else if($state[%closestId, %TrueClientId] == 1)
	{
		if(String::findSubStr(%message, %trigger[2]) != -1)
		{
			if($BotInfo[%aiName, SHOP] != "")
			{
				SetupShop(%TrueClientId, %closestId);
				AI::sayLater(%TrueClientId, %closestId, "Take a look at what I have.", True);
			}
			else
				NewBotMessage(%TrueClientId, %closestId, "I have nothing to sell.");
			$state[%closestId, %TrueClientId] = "";
		}
		//We stop using the blacksmith because it isn't belt-compatible.
		return;
		if(String::findSubStr(%message, %trigger[3]) != -1)
		{
			AI::sayLater(%TrueClientId, %closestId, "Click Use on an item and I will tell you how much it will cost to smith. Click Use on this item again and I will get to work.", True);
			SetupBlacksmith(%TrueClientId, %closestId);
			$state[%closestId, %TrueClientId] = "";
		}
	}
}


function bottalk::guildmaster(%TrueClientId, %closestId, %initTalk, %message){
	//process guildmaster code
	%trigger[2] = "join";
	if(%initTalk)
	{
		if(fetchData(%TrueClientId, "LVL") >= 25)
		{
			%h = fetchData(%TrueClientId, "MyHouse");
			if(%h == "")
			{
			}
			else
			{
			}
		}
		else
		{
			NewBotMessage(%TrueClientId, %closestId, "Come back when you are at least level 25. Goodbye.");
			$state[%closestId, %TrueClientId] = "";
		}
	}
	else if($state[%closestId, %TrueClientId] == 1 || $state[%closestId, %TrueClientId] == 2)
	{
		if(String::findSubStr(%message, %trigger[2]) != -1)
		{
			%ch = fetchData(%TrueClientId, "MyHouse");
			%hlist = "";
			if($state[%closestId, %TrueClientId] == 1)
			{
				//join new house
			}
			else if($state[%closestId, %TrueClientId] == 2)
			{
				//change house
			}
		}
	}
	else if($state[%closestId, %TrueClientId] == 3 || $state[%closestId, %TrueClientId] == 4)
	{
		%houseNum = "";
		for(%i = 1; $HouseName[%i] != ""; %i++)
		{
			if(String::ICompare(%cropped, $HouseName[%i]) == 0)
				%houseNum = %i;
		}
		if(%houseNum != "")
		{
			if($state[%closestId, %TrueClientId] == 3)
				%cost = $joinHouseCost;
			else if($state[%closestId, %TrueClientId] == 4)
				%cost = $changeHouseCost;
			%c = floor(fetchData(%TrueClientId, "COINS"));
			if(%c >= %cost)
			{
				storeData(%TrueClientId, "COINS", %cost, "dec");
				BootFromCurrentHouse(%TrueClientId, True);
				JoinHouse(%TrueClientId, %houseNum, True);
				GiveThisStuff(%TrueClientId, $HouseStartUpEq[%houseNum]);
				RefreshAll(%TrueClientId);
				NewBotMessage(%TrueClientId, %closestId, "Welcome to " @ $HouseName[%houseNum] @ "! You have "@fetchData(%TrueClientId,"RankPoints")@" rank points. Good luck on your adventures!");

				playSound(SoundMoney1, GameBase::getPosition(%TrueClientId));
			}
			else
			{
				NewBotMessage(%TrueClientId, %closestId, "I'm sorry but you do not have enough coins. Goodbye.");
			}
		}
		else
		{
			NewBotMessage(%TrueClientId, %closestId, "This guild does not exist.");
		}
		$state[%closestId, %TrueClientId] = "";
	}
}



		$botMenuOption[%TrueClientId,0] = "I want to fight!";
		$botMenuOption[%TrueClientId,1] = "Let me leave.";
			if(%x != -1)
			{
				TeleportToMarker(%TrueClientId, "TheArena\\WaitingRoomMarkers", 0, 1);
				$state[%closestId, %TrueClientId] = "";
			}