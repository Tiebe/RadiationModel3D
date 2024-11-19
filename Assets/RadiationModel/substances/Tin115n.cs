using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tin115n : RadioactiveSubstance
    {
        public override string name { get; } = "Tin115n";
        public override double halfLife { get; } = 0.00016d;
        public override double atomicWeight { get; } = 114.90411d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((713636.00001, 0.00174)), new Tin115() } },

        };
    }
}
    
    