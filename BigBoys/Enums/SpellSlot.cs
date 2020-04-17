using System;
namespace BigBoys.Enums
{
    public struct SpellSlot
    {
        public SlotsType Type { get; set; }
        public int Number { get; set; }
        public SpellbookType Book { get; set; }
        public SpellSlot(SlotsType type, int number, SpellbookType book)
        {
            Type = type;
            Number = number;
            Book = book;
        }
    }
}
