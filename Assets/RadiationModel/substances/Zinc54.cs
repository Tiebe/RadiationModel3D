using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Zinc54 : RadioactiveSubstance
    {
        public override string name { get; } = "Zinc54";
        public override double halfLife { get; } = 0.0018d;
        public override double atomicWeight { get; } = 53.99388d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.87d, new List<RadioactiveSubstance> { new ProtonParticle(), new Nickel52() } },

        };
    }
}
    
    