using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iridium195n : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium195n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 194.9685d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((2354300.00001, 0.00053)), new Iridium195() } },

        };
    }
}
    
    