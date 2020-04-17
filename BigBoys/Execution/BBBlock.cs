using System;
using System.Collections.Generic;
using BigBoys.Functions;
using BigBoys.Lua;

namespace BigBoys.Execution
{
    public class BBBlock
    {
        public BBFunction Function { get; }
        public Table Params { get; }
        public IReadOnlyList<BBBlock> SubBlocks { get; }

        public BBBlock(BBFunction function, Table @params, IReadOnlyList<BBBlock> subBlocks)
        {
            Function = function ?? throw new ArgumentNullException(nameof(function));
            Params = @params ?? new Table();
            SubBlocks = subBlocks;
        }

        public static IReadOnlyList<BBBlock> CreateBlockList(Table table)
        {
            if (table == null)
            {
                return null;
            }
            var result = new List<BBBlock>();
            foreach (var kvp in table)
            {
                var value = kvp.Value as Table ?? throw new InvalidCastException("Block is not a table!");
                var block = new BBBlock(
                    function: value["Function"] as BBFunction,
                    @params: value["Params"] as Table,
                    subBlocks: CreateBlockList(value["SubBlocks"] as Table)
                    );
                result.Add(block);
            }
            return result;
        }
    }
}
