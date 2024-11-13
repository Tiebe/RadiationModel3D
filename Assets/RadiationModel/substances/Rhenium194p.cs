
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhenium194p : RadioactiveSubstance
    {
        public override string name { get; } = "Rhenium194p";
        public override double halfLife { get; } = 100.0d;
        public override double atomicWeight { get; } = 193.97163d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Osmium194() } },

        };
    }
}
    
    