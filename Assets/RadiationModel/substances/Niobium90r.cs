using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Niobium90r : RadioactiveSubstance
    {
        public override string name { get; } = "Niobium90r";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 89.91328d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00066, 1880000.0), new Niobium90() } },

        };
    }
}
    
    