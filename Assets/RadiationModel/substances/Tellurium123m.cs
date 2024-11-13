
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tellurium123m : RadioactiveSubstance
    {
        public override string name { get; } = "Tellurium123m";
        public override double halfLife { get; } = 10298880.0d;
        public override double atomicWeight { get; } = 122.90454d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(), new Tellurium123() } },

        };
    }
}
    
    