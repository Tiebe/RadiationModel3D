using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nitrogen13i : RadioactiveSubstance
    {
        public override string name { get; } = "Nitrogen13i";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 13.02191d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.049d, new List<RadioactiveSubstance> { new GammaParticle((15065110.0, 8e-05)), new Nitrogen13() } },

        };
    }
}
    
    