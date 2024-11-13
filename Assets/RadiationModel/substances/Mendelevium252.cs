
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Mendelevium252 : RadioactiveSubstance
    {
        public override string name { get; } = "Mendelevium252";
        public override double halfLife { get; } = 138.0d;
        public override double atomicWeight { get; } = 252.08639d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Fermium252() } },

        };
    }
}
    
    