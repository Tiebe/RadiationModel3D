using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Holmium147m : RadioactiveSubstance
    {
        public override string name { get; } = "Holmium147m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 146.94303d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((2687000.0, 0.00046)), new Holmium147() } },

        };
    }
}
    
    