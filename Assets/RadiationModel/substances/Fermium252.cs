using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Fermium252 : RadioactiveSubstance
    {
        public override string name { get; } = "Fermium252";
        public override double halfLife { get; } = 91404.0d;
        public override double atomicWeight { get; } = 252.08247d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(8176002.09), new Californium248() } },
            { 2.3e-05d, new List<RadioactiveSubstance> {  } },

        };
    }
}
    
    