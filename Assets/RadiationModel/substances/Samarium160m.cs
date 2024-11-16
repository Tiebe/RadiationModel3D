using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Samarium160m : RadioactiveSubstance
    {
        public override string name { get; } = "Samarium160m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 159.9368d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((1361299.99998, 0.00091)), new Samarium160() } },

        };
    }
}
    
    