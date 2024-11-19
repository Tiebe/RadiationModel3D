using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thulium160n : RadioactiveSubstance
    {
        public override string name { get; } = "Thulium160n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 159.93549d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.0059, 210000.0), new Thulium160() } },

        };
    }
}
    
    