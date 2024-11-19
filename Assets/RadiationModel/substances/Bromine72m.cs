using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bromine72m : RadioactiveSubstance
    {
        public override string name { get; } = "Bromine72m";
        public override double halfLife { get; } = 10.6d;
        public override double atomicWeight { get; } = 71.9367d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.0123, 100800.0), new Bromine72() } },

        };
    }
}
    
    