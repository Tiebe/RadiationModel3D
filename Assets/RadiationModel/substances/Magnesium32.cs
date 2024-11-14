using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Magnesium32 : RadioactiveSubstance
    {
        public override string name { get; } = "Magnesium32";
        public override double halfLife { get; } = 0.0804d;
        public override double atomicWeight { get; } = 31.99911d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 10270000.0), new Aluminum32() } },

        };
    }
}
    
    