using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Promethium148m : RadioactiveSubstance
    {
        public override string name { get; } = "Promethium148m";
        public override double halfLife { get; } = 3567456.0d;
        public override double atomicWeight { get; } = 147.91763d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.958d, new List<RadioactiveSubstance> { new BetaParticle(-1, 2608100.0), new Samarium148() } },
            { 0.042d, new List<RadioactiveSubstance> { new GammaParticle(0.00898), new Promethium148() } },

        };
    }
}
    
    