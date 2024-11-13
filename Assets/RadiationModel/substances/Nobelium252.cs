
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nobelium252 : RadioactiveSubstance
    {
        public override string name { get; } = "Nobelium252";
        public override double halfLife { get; } = 2.467d;
        public override double atomicWeight { get; } = 252.08897d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.6759999999999999d, new List<RadioactiveSubstance> { new AlphaParticle(), new Fermium248() } },

            { 0.313d, new List<RadioactiveSubstance> {  } },

            { 0.011000000000000001d, new List<RadioactiveSubstance> { new BetaParticle(), new Mendelevium252() } },

        };
    }
}
    
    