using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EmpranionEvents.Common.Globals;

public sealed class EmpranionGlobalNPC : GlobalNPC
{
    public override bool PreAI(NPC npc) {
        if (EmpranionSystem.IsGameActive && npc.type == NPCID.QueenBee) {
            switch (npc.type) {
                case NPCID.QueenBee:
                    const float maxBeeDistance = 80f * 16f;
            
                    if (Main.player[npc.target].DistanceSQ(npc.Center) > maxBeeDistance * maxBeeDistance) {
                        npc.active = false;
                        return false;
                    }
                    break;
            }
        }

        return true;
    }
}