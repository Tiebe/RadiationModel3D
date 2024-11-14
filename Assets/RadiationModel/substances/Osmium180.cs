using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Osmium180 : RadioactiveSubstance
    {
        public override string name { get; } = "Osmium180";
        public override double halfLife { get; } = 1290.0d;
        public override double atomicWeight { get; } = 179.95238d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 1481000.0), new Rhenium180() } },

        };
    }
}
    
    