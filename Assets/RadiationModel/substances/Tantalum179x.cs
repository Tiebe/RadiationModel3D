using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tantalum179x : RadioactiveSubstance
    {
        public override string name { get; } = "Tantalum179x";
        public override double halfLife { get; } = 0.0541d;
        public override double atomicWeight { get; } = 178.94877d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00047), new Tantalum179() } },

        };
    }
}
    
    