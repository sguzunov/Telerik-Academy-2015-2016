namespace Infestation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class ExtendedHoldingPen : HoldingPen
    {
        protected override void ExecuteAddSupplementCommand(string[] commandWords)
        {
            var supllementType = commandWords[1];
            ISupplement supplement;
            switch (supllementType)
            {
                case "PowerCatalyst ":
                    {
                        supplement = new PowerCatalyst();
                        break;
                    }
                case "HealthCatalyst  ":
                    {
                        supplement = new HealthCatalyst();
                        break;
                    }
                case "AggressionCatalyst  ":
                    {
                        supplement = new AggressionCatalyst();
                        break;
                    }
                case "Weapon":
                    {
                        supplement = new Weapon();
                        break;
                    }
                default:
                    {
                        break;
                    }

                    var unitID = commandWords[2];
                    var unit = GetUnit(unitID);

                    unit.AddSupplement(supplement);
            }
        }

        protected override void ExecuteInsertUnitCommand(string[] commandWords)
        {
            switch (commandWords[1])
            {
                case "Tank ":
                    {
                        var tank = new Tank(commandWords[2]);
                        this.InsertUnit(tank);
                        break;
                    }
                case "Marine":
                    {
                        var marine = new Marine(commandWords[2]);
                        this.InsertUnit(marine);
                        break;
                    }
                case "Parasite":
                    {
                        var parasite = new Parasite(commandWords[2]);
                        this.InsertUnit(parasite);
                        break;
                    }
                case "Queen":
                    {
                        var queen = new Queen(commandWords[2]);
                        this.InsertUnit(queen);
                        break;
                    }
                default :
                    {
                       base.ExecuteInsertUnitCommand(commandWords);
                       break;
                    }
            }
        }
    }
}
