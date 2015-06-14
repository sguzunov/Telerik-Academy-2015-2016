using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FarmersCreed.Units;
using FarmersCreed.Interfaces;

namespace FarmersCreed.Simulator
{
    public class ExtendedFarmSimulator : FarmSimulator
    {
        protected override void ProcessInput(string input)
        {
            string[] inputCommands = input.Split(' ');            

            switch (inputCommands[0])
            {
                case "feed":
                    {
                        string id = inputCommands[1];
                        string productId = inputCommands[2];
                        int quantity = int.Parse(inputCommands[3]);
                        var animal = this.GetAnimalById(id);
                        var product = this.GetProductById(productId) as IEdible;
                        this.farm.Feed(animal, product, quantity);
                        break;
                    }
                case "water":
                    {
                        string id = inputCommands[1];
                        var plant = this.GetPlantById(id);
                        this.farm.Water(plant);
                        break;
                    }
                case "exploit":
                    {
                        string unitType = inputCommands[1];
                        string id = inputCommands[2];

                        if (unitType == "animal")
                        {
                            var animal = this.GetAnimalById(id);
                            this.farm.Exploit(animal);
                        }
                        else 
                        {
                            var plant = this.GetPlantById(id);
                            this.farm.Exploit(plant);
                        }
                        break;
                    }
                default:
                    base.ProcessInput(input);
                    break;
            }
        }

        protected override void AddObjectToFarm(string[] inputCommands)
        {
            string type = inputCommands[1];
            string id = inputCommands[2];

            switch (type)
            {
                case "CherryTree":
                    {
                        var cherryTree = new CherryTree(id);
                        this.farm.Plants.Add(cherryTree);
                        break;
                    }
                case "TobaccoPlant":
                    {
                        var tobaccoPlant = new CherryTree(id);
                        this.farm.Plants.Add(tobaccoPlant);
                        break;
                    }
                case "Cow":
                    {
                        var cow = new Cow(id);
                        this.farm.Animals.Add(cow);
                        break;
                    }
                case "Swine":
                    {
                        var swine = new Swine(id);
                        this.farm.Animals.Add(swine);
                        break;
                    }
                default:
                    base.AddObjectToFarm(inputCommands);
                    break;
            }
        }
    }
}
