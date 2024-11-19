using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rubidium85m : RadioactiveSubstance
    {
        public override string name { get; } = "Rubidium85m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 84.91234d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((514006.00001, 0.00241)), new Rubidium85() } },

        };
    }
}
    
    