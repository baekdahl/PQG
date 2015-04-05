namespace Engine
{
    public class QuestCompletionKill
    {
        public Monster Monsters { get; set; }
        public int Quantity { get; set; }

        public QuestCompletionKill(Monster monsters, int quantity)
        {
            Monsters = monsters;
            Quantity = quantity;
        }
    }
}
