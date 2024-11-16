using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silver115m : RadioactiveSubstance
    {
        public override string name { get; } = "Silver115m";
        public override double halfLife { get; } = 18.0d;
        public override double atomicWeight { get; } = 114.90881d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.79d, new List<RadioactiveSubstance> { new BetaParticle(-1, 3142500.0), new Cadmium115() } },
            { 0.21d, new List<RadioactiveSubstance> { new GammaParticle((41000.0, 0.03024)), new Silver115() } },

        };
    }
}
    
    