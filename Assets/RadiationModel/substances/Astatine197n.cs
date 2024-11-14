using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Astatine197n : RadioactiveSubstance
    {
        public override string name { get; } = "Astatine197n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 196.99351d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00399), new Astatine197() } },

        };
    }
}
    
    