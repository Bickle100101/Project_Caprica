using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Caprica
{
	public class Building 
	{

        //Represents a constructed Building on a PLanet?
        //   Maybe also gets used in list of Building Templates?

        public Building(string name, int requiredProduction, int unlockedByTechId, BuildingEndOfTurnFunction endOfTurnFunction)
        {
            this.name = name;
            this.requiredProduction = requiredProduction;
            this.unlockedByTechId = unlockedByTechId;
           // this.endOfTurnFunction = endOfTurnFunction;
        }

        string name;
        int requiredProduction;
        int unlockedByTechId = -1; //Default.  Buildings buildable at GameStart

        int bonusFlatProduction;

        public delegate void BuildingEndOfTurnFunction(Colony colony, int currentGameTurn, int builtGameTurn);
        event BuildingEndOfTurnFunction EndOfTurnFunction;

        public void DoEndOfTurn(Colony colony, int currentGameTurn, int builtGameTurn)
        {
            EndOfTurnFunction(colony, currentGameTurn, builtGameTurn);
        }

    }

    static public class SetUpBuildings
    {
        static SetUpBuildings()
        {
            //This function will read a config file with building 
            //  parameters and maybe some LUA code for end of turn logic
            AllBuildings = new Building[]
            {
                new Building("Barracks", 100, -1, (c, turn, built) => { Debug.Log("Barracks Turn Processing"); }),  //Each Building on each PLanet Reports in),
            };
        }

        static public Building[] AllBuildings;
    }
}