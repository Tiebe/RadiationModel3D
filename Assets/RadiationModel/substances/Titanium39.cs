using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Titanium39 : RadioactiveSubstance
    {
        public override string name { get; } = "Titanium39";
        public override double halfLife { get; } = 0.0285d;
        public override double atomicWeight { get; } = 39.00268d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 16673000.0), new Scandium39() } },

        };
    }
}
    
    