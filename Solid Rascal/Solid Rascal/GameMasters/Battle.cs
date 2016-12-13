﻿using System;
using Solid_Rascal.Characters;
using Solid_Rascal.UI;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Rascal
{
    class Battle
    {

        public Alert _Alert;
        public Dice _Dice;
        public long FD, FA;

        public int ATK, DEF;

        public Battle(Character attacker, Character defender)
        {
            _Alert = new Alert();
            _Dice = new Dice();

            FA = (long)(attacker.sSTR / 4) + _Dice.Roll(1,10);
            FD = (long)(defender.sARMOR / 4) + _Dice.Roll(1, 10);

            ATK = (int)FA + _Dice.Roll(1, 100);
            DEF = (int)FD + _Dice.Roll(1, 100);

           // _Alert.Warning("[DEBUG] ATK: " + ATK + " DEF " + DEF + " [DEBUG]");

            if (ATK > DEF)
            {
                //Acertou
                defender.ReduceHealth((int)FA);
                _Alert.Warning("" + attacker.charNAME + " Attacks " + defender.charNAME + " for " + FA + " damage");
            }
            else if(ATK <= DEF)
            {
                //Errou
                _Alert.Warning("" + attacker.charNAME + " Attacks " + defender.charNAME + " and Misses!");
            }

            if(defender.sHP <= 0)
            {
                //Ded
                _Alert.Warning("" + attacker.charNAME + " Defeats the " + defender.charNAME);
                MainGame.KillAnEnemy(defender);
            }
        }
    }
}   