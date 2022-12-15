using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EmpranionEvents.Common.Globals.NPCs;

public sealed class EmpranionStatsNPC : GlobalNPC
{
    public override void SetDefaults(NPC npc) {
        switch (npc.type) {
            case NPCID.DevourerHead:
                npc.damage = 18;
                npc.defense = 1;

                break;

            case NPCID.DevourerBody:
                npc.damage = 10;
                npc.defense = 4;

                break;

            case NPCID.DevourerTail:
                npc.damage = 7;
                npc.defense = 7;

                break;

            case NPCID.TombCrawlerHead:
                npc.lifeMax = 40;

                break;

            case NPCID.TombCrawlerBody:
                npc.lifeMax = 40;

                break;

            case NPCID.TombCrawlerTail:
                npc.lifeMax = 40;

                break;
        }
    }
}