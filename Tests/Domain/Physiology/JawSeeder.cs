using Domain.Physiology;
using Tests.General;

namespace Tests.Domain.Physiology;

public static class JawSeeder
{
    public static Jaw CreateEmptyJaw()
    {
        return new(CreateDefaultJawId(), JawPosition.Upper);
    }

    public static JawId CreateDefaultJawId()
    {
        return new JawId(GeneralSeeder.CreateGuid1a2b());
    }
}
