using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Ytterbium175m : RadioactiveSubstance
    {
        public override string name { get; } = "Ytterbium175m";
        public override double halfLife { get; } = 0.0682d;
        public override double atomicWeight { get; } = 174.94183d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00241, 514870.0), new Ytterbium175() } },

        };
    }
}
    
    