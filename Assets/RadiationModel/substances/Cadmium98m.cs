using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cadmium98m : RadioactiveSubstance
    {
        public override string name { get; } = "Cadmium98m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 97.92999d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00051, 2430000.0), new Cadmium98() } },

        };
    }
}
    
    