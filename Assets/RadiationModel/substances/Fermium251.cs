using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Fermium251 : RadioactiveSubstance
    {
        public override string name { get; } = "Fermium251";
        public override double halfLife { get; } = 19080.0d;
        public override double atomicWeight { get; } = 251.08155d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.982d, new List<RadioactiveSubstance> { new BetaParticle(1, 1447000.0), new Einsteinium251() } },
            { 0.018000000000000002d, new List<RadioactiveSubstance> { new AlphaParticle(8445047.4), new Californium247() } },

        };
    }
}
    
    