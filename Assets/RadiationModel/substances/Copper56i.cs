using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Copper56i : RadioactiveSubstance
    {
        public override string name { get; } = "Copper56i";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 55.96232d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.51d, new List<RadioactiveSubstance> { new GammaParticle(0.00035), new Copper56() } },
            { 0.49d, new List<RadioactiveSubstance> { new ProtonParticle(), new Nickel55() } },

        };
    }
}
    
    