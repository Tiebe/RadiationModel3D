using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Holmium164m : RadioactiveSubstance
    {
        public override string name { get; } = "Holmium164m";
        public override double halfLife { get; } = 2196.0d;
        public override double atomicWeight { get; } = 163.93039d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00887), new Holmium164() } },

        };
    }
}
    
    