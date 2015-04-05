using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public static class World
    {
        public static readonly List<Item> Items = new List<Item>();
        public static readonly List<Monster> Monsters = new List<Monster>();
        public static readonly List<Quest> Quests = new List<Quest>();
        public static readonly List<Location> Locations = new List<Location>();

        public const int ITEM_ID_RAT_TAIL = 1;
        public const int ITEM_ID_PIECE_OF_FUR = 2;
        public const int ITEM_ID_HEALING_POTION = 3;
        public const int ITEM_ID_SNAKE_FANG = 4;

        public const int MONSTER_ID_RAT = 1;
        public const int MONSTER_ID_SNAKE = 2;

        public const int QUEST_ID_KILLQUEST = 1;

        public const int LOCATION_ID_TOWN_SQUARE = 1;
        public const int LOCATION_ID_ALCHEMIST_GARDEN = 2;

        static World()
        {
            PopulateItems();
            PopulateMonsters();
            PopulateQuests();
            PopulateLocations();
        }

        private static void PopulateItems()
        {
            Items.Add(new Item(ITEM_ID_RAT_TAIL, "Rat tail", "Rat tails"));
            Items.Add(new Item(ITEM_ID_PIECE_OF_FUR, "Piece of fur", "Pieces of fur"));
        }

        private static void PopulateMonsters()
        {
            Monster rat = new Monster(MONSTER_ID_RAT, "Rat", 5, 3, 10, 3, 3);
            rat.LootTable.Add(new LootItem(ItemByID(ITEM_ID_RAT_TAIL), 75, false));
            rat.LootTable.Add(new LootItem(ItemByID(ITEM_ID_PIECE_OF_FUR), 75, true));

            Monster snake = new Monster(MONSTER_ID_SNAKE, "Snake", 4, 2, 10, 3, 3);
            snake.LootTable.Add(new LootItem(ItemByID(ITEM_ID_SNAKE_FANG), 50, true));

            Monsters.Add(rat);
            Monsters.Add(snake);
        }

        private static void PopulateQuests()
        {

            Quest KillQuest =
                new Quest(
                    QUEST_ID_KILLQUEST,
                    "Clear the " + Locations[(RandomNumberGenerator.NumberBetween(0, Locations.Count))].Name,
                    "Kill " + Monsters[(RandomNumberGenerator.NumberBetween(0, Monsters.Count))].Name + ". You will receive a healing potion and 10 gold pieces.", 20, 10);

            KillQuest.QuestCompletionItems.Add(new QuestCompletionItem(ItemByID(ITEM_ID_RAT_TAIL), 3));

            KillQuest.RewardItem = ItemByID(ITEM_ID_HEALING_POTION);

            Quests.Add(KillQuest);

        }

        private static void PopulateLocations()
        {
            // Create each location

            Location townSquare = new Location(LOCATION_ID_TOWN_SQUARE, "Town square", "You see a fountain.");

            Location alchemistsGarden = new Location(LOCATION_ID_ALCHEMIST_GARDEN, "Alchemist's garden", "Many plants are growing here.");
            alchemistsGarden.MonsterLivingHere = MonsterByID(RandomNumberGenerator.NumberBetween(0, Monsters.Count));


            // Add the locations to the static list

            Locations.Add(townSquare);
            Locations.Add(alchemistsGarden);
        }

        public static Item ItemByID(int id)
        {
            foreach (Item item in Items)
            {
                if (item.ID == id)
                {
                    return item;
                }
            }

            return null;
        }

        public static Monster MonsterByID(int id)
        {
            foreach (Monster monster in Monsters)
            {
                if (monster.ID == id)
                {
                    return monster;
                }
            }

            return null;
        }

        public static Quest QuestByID(int id)
        {
            foreach (Quest quest in Quests)
            {
                if (quest.ID == id)
                {
                    return quest;
                }
            }

            return null;
        }

        public static Location LocationByID(int id)
        {
            foreach (Location location in Locations)
            {
                if (location.ID == id)
                {
                    return location;
                }
            }

            return null;
        }
    }
}