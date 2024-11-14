using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tin102 : RadioactiveSubstance
    {
        public override string name { get; } = "Tin102";
        public override double halfLife { get; } = 3.8d;
        public override double atomicWeight { get; } = 101.93029d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 5765000.0), new Indium102() } },

        };
    }
}
    
    