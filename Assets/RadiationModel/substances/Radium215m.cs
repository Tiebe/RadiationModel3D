using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radium215m : RadioactiveSubstance
    {
        public override string name { get; } = "Radium215m";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 215.00473d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00066, 1878000.0), new Radium215() } },

        };
    }
}
    
    