using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace gnohp18.quiz;

[Dependency(ReplaceServices = true)]
public class quizBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "quiz";
}
