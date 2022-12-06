using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EmpranionEvents.Common;

public sealed class EmpranionGlobalNPC : GlobalNPC
{
    public override bool PreAI(NPC npc) {
        switch (npc.type) {
            case NPCID.QueenBee:
                if (npc.DistanceSQ(Main.player[npc.target].Center) > EmpranionEvents.QueenBeeDespawnRange) {
                    npc.active = false;
                    return false;
                }
                break;
        }
        
        return true;
    }
}