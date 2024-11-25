using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Dubnium256 : RadioactiveSubstance
    {
        public override string name { get; } = "Dubnium256";
        public override double halfLife { get; } = 1.6d;
        public override double atomicWeight { get; } = 256.10768d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.7d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Lawrencium252() }, { 1.0d, new AlphaParticle(10357002.09) } } },
            { 0.3d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Rutherfordium256() } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    