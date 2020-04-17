using System;
using System.IO;

namespace BigBoys
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            foreach(var file in Directory.GetFiles("Game", "*.luaobj", SearchOption.AllDirectories))
            {
                var table = Lua.ReadLuaObj.FromStream(File.OpenRead(file));
                foreach(var kvp in table)
                {
                    var key = kvp.Key as string;
                    if (!key.EndsWith("BuildingBlocks"))
                    {
                        continue;
                    }
                    var value = kvp.Value as Lua.Table;
                    var blocks = Execution.BBBlock.CreateBlockList(value);
                }
            }

        }
    }
}
