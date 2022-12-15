using EmpranionEvents.Utilities;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EmpranionEvents.Common.Globals.NPCs;

public sealed class EmpranionAINPC : GlobalNPC
{
    public override bool PreAI(NPC npc) {
        if (npc.type == NPCID.QueenBee) {
            bool shouldBeActive = false;

            foreach (Player player in NetworkUtils.GetActivePlayers()) {
                if (player.DistanceSQ(npc.Center) < 64f * 64f) {
                    shouldBeActive = true;
                }
            }

            if (!shouldBeActive) {
                npc.active = false;
            }

            return shouldBeActive;
        }

        return true;
    }
}