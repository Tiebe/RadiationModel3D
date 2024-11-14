using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Strontium83 : RadioactiveSubstance
    {
        public override string name { get; } = "Strontium83";
        public override double halfLife { get; } = 116676.0d;
        public override double atomicWeight { get; } = 82.91755d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 2272600.0), new Rubidium83() } },

        };
    }
}
    
    