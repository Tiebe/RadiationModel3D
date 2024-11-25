using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Fermium256 : RadioactiveSubstance
    {
        public override string name { get; } = "Fermium256";
        public override double halfLife { get; } = 9426.0d;
        public override double atomicWeight { get; } = 256.09177d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.919d, new Dictionary<double, RadioactiveSubstance> {  } },
            { 0.081d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Californium252() }, { 1.0d, new AlphaParticle(8047402.09) } } },

        };
    }
}
    