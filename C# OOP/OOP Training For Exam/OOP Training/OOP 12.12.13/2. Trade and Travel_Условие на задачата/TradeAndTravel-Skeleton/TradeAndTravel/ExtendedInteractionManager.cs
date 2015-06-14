namespace TradeAndTravel
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ExtendedInteractionManager : InteractionManager
    {
        public ExtendedInteractionManager()
            : base()
        { 
        }

        protected override Item CreateItem(string itemTypeString, string itemNameString, Location itemLocation, Item item)
        {
            switch (itemTypeString)
            {
                case "weapon":
                    {
                        return new Weapon(itemNameString, itemLocation);
                    }
                case "wood":
                    {
                        return new Wood(itemNameString, itemLocation);
                    }
                case "iron":
                    {
                        return new Iron(itemNameString, itemLocation);
                    }
                default:
                    return base.CreateItem(itemTypeString, itemNameString, itemLocation, item);
            }            
        }

        protected override Location CreateLocation(string locationTypeString, string locationName)
        {
            switch (locationTypeString)
            {
                case "mine":
                    {
                        return new Mine(locationName);
                    }
                case "forest":
                    {
                        return new Forest(locationName);
                    }
                default:
                    {
                        return base.CreateLocation(locationTypeString, locationName);
                    }                   
            }                        
        }

        protected override Person CreatePerson(string personTypeString, string personNameString, Location personLocation)
        {
            Person p = null;

            switch (personTypeString)
            {
                case "merchant":
                    {
                        p = new Merchant(personNameString, personLocation);
                        break;
                    }
                default:
                    {
                        p = base.CreatePerson(personTypeString, personNameString, personLocation);
                        break;
                    }
            }

            return p;
        }

        protected override void HandlePersonCommand(string[] commandWords, Person actor)
        {
            switch (commandWords[1])
            {
                case "gather":
                    {
                        this.HandleGatherInteraction(actor,commandWords[2]);
                        break;
                    }
                case "craft":
                    {
                        this.HandleCraftInteraction(actor, commandWords[2],commandWords[3]);
                        break;
                    }
                default:
                    {
                        base.HandlePersonCommand(commandWords, actor);
                        break;
                    }
            }            
        }

        private void HandleCraftInteraction(Person actor, string itemType,string itemName)
        {
            switch (itemType)
            {
                case "armor":
                    {
                        this.CraftArmor(actor, itemName);
                        break;
                    }
                case "weapon":
                    {
                        this.CraftWeapon(actor, itemName);
                        break;
                    }
                default: break;
            }
        }

        private void CraftWeapon(Person actor, string itemName)
        {
            if (actor.ListInventory().Any(i => i.ItemType == ItemType.Iron) && actor.ListInventory().Any(i => i.ItemType == ItemType.Wood))
            {
                this.AddToPerson(actor, new Weapon(itemName));
            }
        }

        private void CraftArmor(Person actor, string itemName)
        {
            if (actor.ListInventory().Any(i => i.ItemType == ItemType.Iron))
            {
                AddToPerson(actor, new Armor(itemName));
            }
        }

        private void HandleGatherInteraction(Person actor,string itemName)
        {
            var gatheringLocation = actor.Location as IGatheringLocation;

            if (gatheringLocation != null)
            {
                var actorInventory = actor.ListInventory();
                bool hasRequiredItem = actorInventory.Any(
                    (item) => item.ItemType == gatheringLocation.RequiredItem
                    );

                if (hasRequiredItem)
                {
                    var producedItem = gatheringLocation.ProduceItem(itemName);
                    this.AddToPerson(actor, producedItem);
                }
            }
        }
    }
}
