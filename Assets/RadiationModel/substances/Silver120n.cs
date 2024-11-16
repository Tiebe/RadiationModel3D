using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silver120n : RadioactiveSubstance
    {
        public override string name { get; } = "Silver120n";
        public override double halfLife { get; } = 0.384d;
        public override double atomicWeight { get; } = 119.919d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.68d, new List<RadioactiveSubstance> { new GammaParticle((203000.0, 0.00611)), new Silver120() } },
            { 0.32d, new List<RadioactiveSubstance> { new BetaParticle(-1, 8508000.0), new Cadmium120() } },

        };
    }
}
    
    