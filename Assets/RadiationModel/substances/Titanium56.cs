using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Titanium56 : RadioactiveSubstance
    {
        public override string name { get; } = "Titanium56";
        public override double halfLife { get; } = 0.2d;
        public override double atomicWeight { get; } = 55.95768d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 6760000.0), new Vanadium56() } },

        };
    }
}
    
    