
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silver118n : RadioactiveSubstance
    {
        public override string name { get; } = "Silver118n";
        public override double halfLife { get; } = 2.0d;
        public override double atomicWeight { get; } = 117.91473d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.59d, new List<RadioactiveSubstance> { new BetaParticle(), new Cadmium118() } },

            { 0.41d, new List<RadioactiveSubstance> { new GammaParticle(), new Silver118() } },

        };
    }
}
    
    