using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Arsenic79m : RadioactiveSubstance
    {
        public override string name { get; } = "Arsenic79m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 78.92178d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.0016), new Arsenic79() } },

        };
    }
}
    
    