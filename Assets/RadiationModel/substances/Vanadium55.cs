using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Vanadium55 : RadioactiveSubstance
    {
        public override string name { get; } = "Vanadium55";
        public override double halfLife { get; } = 6.54d;
        public override double atomicWeight { get; } = 54.94726d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 5985320.0), new Chromium55() } },

        };
    }
}
    
    