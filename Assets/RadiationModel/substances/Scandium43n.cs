using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Scandium43n : RadioactiveSubstance
    {
        public override string name { get; } = "Scandium43n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 42.9645d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.0004, 3123700.0), new Scandium43() } },

        };
    }
}
    
    