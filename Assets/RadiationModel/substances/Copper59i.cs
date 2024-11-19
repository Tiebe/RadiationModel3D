using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Copper59i : RadioactiveSubstance
    {
        public override string name { get; } = "Copper59i";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 58.94367d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((3885500.0, 0.00032)), new Copper59() } },

        };
    }
}
    
    