using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Actinium215m : RadioactiveSubstance
    {
        public override string name { get; } = "Actinium215m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 215.0084d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00069), new Actinium215() } },

        };
    }
}
    
    