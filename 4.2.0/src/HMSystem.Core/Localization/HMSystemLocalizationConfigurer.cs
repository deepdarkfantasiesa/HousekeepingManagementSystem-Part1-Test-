using System.Reflection;
using Abp.Configuration.Startup;
using Abp.Localization;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Json;
using Abp.Reflection.Extensions;

namespace HMSystem.Localization
{
    public static class HMSystemLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Languages.Add(new LanguageInfo("en", "English", "famfamfam-flags england", isDefault: true));
            localizationConfiguration.Languages.Add(new LanguageInfo("tr", "Türkçe", "famfamfam-flags tr"));

            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(HMSystemConsts.LocalizationSourceName,
                    new JsonEmbeddedFileLocalizationDictionaryProvider(
                        typeof(HMSystemLocalizationConfigurer).GetAssembly(),
                        "HMSystem.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}