using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nobelium256 : RadioactiveSubstance
    {
        public override string name { get; } = "Nobelium256";
        public override double halfLife { get; } = 2.91d;
        public override double atomicWeight { get; } = 256.09428d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9947d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Fermium252() }, { 1.0d, new AlphaParticle(9603002.09) } } },
            { 0.0053d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    