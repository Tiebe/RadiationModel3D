
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhenium190m : RadioactiveSubstance
    {
        public override string name { get; } = "Rhenium190m";
        public override double halfLife { get; } = 11160.0d;
        public override double atomicWeight { get; } = 189.96202d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.544d, new List<RadioactiveSubstance> { new BetaParticle(), new Osmium190() } },

            { 0.456d, new List<RadioactiveSubstance> { new GammaParticle(), new Rhenium190() } },

        };
    }
}
    
    