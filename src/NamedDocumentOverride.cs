using Soenneker.Documents.Named;
using Soenneker.Utils.AutoBogus.Context;
using Soenneker.Utils.AutoBogus.Override;

namespace Soenneker.AutoFaker.Overrides.Documents.Named;

/// <summary>
/// An AutoFaker (AutoBogus) override for the NamedDocument object
/// </summary>
public class NamedDocumentOverrideOverride : AutoFakerOverride<NamedDocument>
{
    public override bool CanOverride(AutoFakerContext context)
    {
        return context.GenerateType.IsSubclassOf(typeof(NamedDocument));
    }

    public override void Generate(AutoFakerOverrideContext context)
    {
        var target = (context.Instance as NamedDocument)!;
        target.Name = context.Faker.Commerce.ProductName();
        target.Id = context.Faker.Random.Guid().ToString();
    }
}
