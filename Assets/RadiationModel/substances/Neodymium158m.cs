using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neodymium158m : RadioactiveSubstance
    {
        public override string name { get; } = "Neodymium158m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 157.94397d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((1648099.99999, 0.00075)), new Neodymium158() } },

        };
    }
}
    
    