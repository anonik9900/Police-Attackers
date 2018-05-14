using GTA;
using System;
using System.Collections.Generic;
using GTA.Math;
using GTA.Native;
using System.Windows.Forms;

/*
 * 
  Police Attackers v 1.0.2
  Developer : Anonik
  Based on : ScriptHookVDotNet
  Devolved in C#
  
  Need to Works : 
   
  Microsoft .NET Framework v4.5.2
  Visual C++ Redistributable Packages for Visual Studio
  ScriptHookVDotNet v.2.x
 
 */


public class RandomAttackers : Script
{
    public RandomAttackers()
    {
        Tick += OnTick;
        KeyDown += OnKeyDown;
        KeyUp += OnKeyUp;

        Interval = 10;
    }

    void OnTick(object sender, EventArgs e)
    {

    }

    void OnKeyDown(object sender, KeyEventArgs e)
    {

    }

    void OnKeyUp(object sender, KeyEventArgs e)
    {
        if(e.KeyCode == Keys.U)
        {
            Ped player = Game.Player.Character;

            Vector3 loc = player.Position + (player.ForwardVector * 5);

            Ped ped = World.CreatePed(PedHash.Cop01SMY, loc);  //Pedone che viene generato

            GTA.UI.ShowSubtitle("~r~Police have spawned, ~y~be careful"); //scritta che compare

            ped.Weapons.Give(WeaponHash.Pistol50, 100, true, true); //arma del pedone (WeaponHash.nome-arma, colpi, se è disponibile, se è carica)

            ped.Task.FightAgainst(player); //attacca il giocatore

            UI.Notify("Mod by Anonik");


        }

        if(e.KeyCode == Keys.I)
        {
            Ped player = Game.Player.Character;

            Vector3 loc = player.Position + (player.ForwardVector * 5);

            Ped ped = World.CreatePed(PedHash.Swat01SMY, loc);

            GTA.UI.ShowSubtitle("~r~Swat have spawned, ~y~be careful");

            ped.Weapons.Give(WeaponHash.CarbineRifle, 250, true, true);

            ped.Task.FightAgainst(player);

            UI.Notify("Mod by Anonik");
        }

        if(e.KeyCode == Keys.O)
        {
            Ped player = Game.Player.Character;

            Vector3 loc = player.Position + (player.ForwardVector * 5);

            Ped ped = World.CreatePed(PedHash.Marine03SMY, loc);

            GTA.UI.ShowSubtitle("~r~Marine spawned, ~y~be careful");

            ped.Weapons.Give(WeaponHash.SpecialCarbine, 250, true, true);

            ped.Task.FightAgainst(player);

            UI.Notify("Mod by Anonik");
        }

        if(e.KeyCode == Keys.X)
        {
            Ped player = Game.Player.Character;

            Vector3 loc = player.Position + (player.ForwardVector * 5);

            Ped bodyguard = World.CreateRandomPed(loc);

            //Ped bodyguard = World.CreatePed(PedHash.Cop01SMY, loc);

            bodyguard.Weapons.Give(WeaponHash.CarbineRifle, 9999, true, true);

            bodyguard.Armor = 100;

            PedGroup ped = player.CurrentPedGroup;

            Function.Call(Hash.SET_PED_AS_GROUP_MEMBER, bodyguard, ped);

            Function.Call(Hash.SET_PED_COMBAT_ABILITY, bodyguard, 100);

            Function.Call(Hash.SET_PED_ACCURACY, bodyguard, 100);

            bodyguard.Task.FightAgainstHatedTargets(50000);

            UI.Notify("Bodyguard Spawned");

            UI.Notify("Mod by Anonik");

            if (player.IsInvincible == true)
            {
                bodyguard.IsInvincible = true;
            }
        }

        if (e.KeyCode == Keys.K)
        {
            Ped player = Game.Player.Character;

            Vector3 loc = player.Position + (player.ForwardVector * 5);

            Ped bodyguard = World.CreatePed(PedHash.Cop01SMY, loc);

            bodyguard.Weapons.Give(WeaponHash.Pistol50, 9999, true, true);

            bodyguard.Armor = 100;

            PedGroup ped = player.CurrentPedGroup;

            Function.Call(Hash.SET_PED_AS_GROUP_MEMBER, bodyguard, ped);

            Function.Call(Hash.SET_PED_COMBAT_ABILITY, bodyguard, 100);

            Function.Call(Hash.SET_PED_ACCURACY, bodyguard, 100);

            bodyguard.Task.FightAgainstHatedTargets(50000);

            UI.Notify("Bodyguard Spawned");

            UI.Notify("Mod by Anonik");

            if (player.IsInvincible == true)
            {
                bodyguard.IsInvincible = true;
            }
        }

    }
}
