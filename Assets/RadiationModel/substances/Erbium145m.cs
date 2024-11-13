
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Erbium145m : RadioactiveSubstance
    {
        public override string name { get; } = "Erbium145m";
        public override double halfLife { get; } = 1.0d;
        public override double atomicWeight { get; } = 144.95809d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Holmium145() } },

        };
    }
}
    
    