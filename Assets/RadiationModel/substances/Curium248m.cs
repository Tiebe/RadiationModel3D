using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Curium248m : RadioactiveSubstance
    {
        public override string name { get; } = "Curium248m";
        public override double halfLife { get; } = 0.00015d;
        public override double atomicWeight { get; } = 248.07391d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00085), new Curium248() } },

        };
    }
}
    
    