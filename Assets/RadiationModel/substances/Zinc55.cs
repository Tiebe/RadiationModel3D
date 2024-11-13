
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Zinc55 : RadioactiveSubstance
    {
        public override string name { get; } = "Zinc55";
        public override double halfLife { get; } = 0.0198d;
        public override double atomicWeight { get; } = 54.98468d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Copper55() } },

        };
    }
}
    
    