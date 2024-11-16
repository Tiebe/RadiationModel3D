using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium112 : RadioactiveSubstance
    {
        public override string name { get; } = "Indium112";
        public override double halfLife { get; } = 892.8d;
        public override double atomicWeight { get; } = 111.90554d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.62d, new List<RadioactiveSubstance> { new BetaParticle(1, 2584860.0), new Cadmium112() } },
            { 0.38d, new List<RadioactiveSubstance> { new BetaParticle(-1, 665050.0), new Tin112() } },

        };
    }
}
    
    