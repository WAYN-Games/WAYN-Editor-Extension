using UnityEditor;

namespace WaynGroup.Mgm.Ability
{
    internal class ScriptTemplates
    {

        public const string TemplatesRoot = "Packages/com.wayn_group.editor.extension/Editor";

        [MenuItem("Assets/Create/WAYN/Editor/ExtendedScriptableObjectDrawer")]
        public static void CreateAbilityEffectType()
        {
            ProjectWindowUtil.CreateScriptAssetFromTemplateFile(
                $"{TemplatesRoot}/ExtendedScriptableObjectDrawerTemplate.txt",
                "NewEffect.cs");
        }
       
    }
}
