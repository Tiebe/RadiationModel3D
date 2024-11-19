using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rubidium96n : RadioactiveSubstance
    {
        public override string name { get; } = "Rubidium96n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 95.93535d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((1135000.0, 0.00109)), new Rubidium96() } },

        };
    }
}
    
    