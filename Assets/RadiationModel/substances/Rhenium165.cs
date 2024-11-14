using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhenium165 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhenium165";
        public override double halfLife { get; } = 1.6d;
        public override double atomicWeight { get; } = 164.96709d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.86d, new List<RadioactiveSubstance> { new BetaParticle(1, 8202000.0), new Tungsten165() } },
            { 0.14d, new List<RadioactiveSubstance> { new AlphaParticle(6715047.4), new Tantalum161() } },

        };
    }
}
    
    