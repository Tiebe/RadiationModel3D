using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thulium163m : RadioactiveSubstance
    {
        public override string name { get; } = "Thulium163m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 162.93275d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((87000.0, 0.01425)), new Thulium163() } },

        };
    }
}
    
    