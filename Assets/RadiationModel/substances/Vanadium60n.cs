
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Vanadium60n : RadioactiveSubstance
    {
        public override string name { get; } = "Vanadium60n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 59.96469d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(), new Vanadium60() } },

        };
    }
}
    
    