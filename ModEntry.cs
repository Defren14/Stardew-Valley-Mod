using StardewModdingAPI;

namespace MyMod
{
    public class ModEntry : Mod
    {
        public override void Entry(IModHelper helper)
        {
            Monitor.Log("Mod loaded successfully!", LogLevel.Info);
        }
    }
}
