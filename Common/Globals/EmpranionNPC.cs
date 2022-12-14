using EmpranionEvents.Utilities;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EmpranionEvents.Common.Globals;

public sealed class EmpranionNPC : GlobalNPC
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