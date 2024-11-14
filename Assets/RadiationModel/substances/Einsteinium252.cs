using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Einsteinium252 : RadioactiveSubstance
    {
        public override string name { get; } = "Einsteinium252";
        public override double halfLife { get; } = 40754880.0d;
        public override double atomicWeight { get; } = 252.08297d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.78d, new List<RadioactiveSubstance> { new AlphaParticle(7755047.4), new Berkelium248() } },
            { 0.22d, new List<RadioactiveSubstance> { new Californium252() } },

        };
    }
}
    
    