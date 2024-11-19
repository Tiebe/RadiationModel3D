using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Polonium210n : RadioactiveSubstance
    {
        public override string name { get; } = "Polonium210n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 209.9883d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00025, 5057600.0), new Polonium210() } },

        };
    }
}
    
    