using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium118n : RadioactiveSubstance
    {
        public override string name { get; } = "Indium118n";
        public override double halfLife { get; } = 8.5d;
        public override double atomicWeight { get; } = 117.90661d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00521), new Indium118() } },
            { 0.972196d, new List<RadioactiveSubstance> { new GammaParticle(0.00886), new Indium118m() } },
            { 0.013999999999999999d, new List<RadioactiveSubstance> { new BetaParticle(-1, 4662800.0), new Tin118() } },

        };
    }
}
    
    