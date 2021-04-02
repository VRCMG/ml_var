using UnityEngine;

namespace ml_var
{
    public class VertexAnimationRemover : MelonLoader.MelonMod
    {
        [Harmony.HarmonyPatch(typeof(SkinnedMeshRenderer), "BakeMesh")]
        class Patch_SkinnedMeshRenderer_BakeMesh
        {
            static void Postfix(ref SkinnedMeshRenderer __instance)
            {
                __instance?.sharedMesh?.ClearBlendShapes();
            }
        }
    }
}
