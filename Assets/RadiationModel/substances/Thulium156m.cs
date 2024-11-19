using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thulium156m : RadioactiveSubstance
    {
        public override string name { get; } = "Thulium156m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 155.93942d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((404000.0, 0.00307)), new Thulium156() } },

        };
    }
}
    
    