using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Uranium237m : RadioactiveSubstance
    {
        public override string name { get; } = "Uranium237m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 237.04902d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00452, 274000.0), new Uranium237() } },

        };
    }
}
    
    