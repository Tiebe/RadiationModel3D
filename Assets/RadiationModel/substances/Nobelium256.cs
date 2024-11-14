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

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9945d, new List<RadioactiveSubstance> { new AlphaParticle(9601047.4), new Fermium252() } },
            { 0.0055000000000000005d, new List<RadioactiveSubstance> {  } },

        };
    }
}
    
    