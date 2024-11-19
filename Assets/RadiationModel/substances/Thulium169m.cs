using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thulium169m : RadioactiveSubstance
    {
        public override string name { get; } = "Thulium169m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 168.93456d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00392, 316100.0), new Thulium169() } },

        };
    }
}
    
    