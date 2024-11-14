using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Polonium205 : RadioactiveSubstance
    {
        public override string name { get; } = "Polonium205";
        public override double halfLife { get; } = 6264.0d;
        public override double atomicWeight { get; } = 204.98119d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9995999999999999d, new List<RadioactiveSubstance> { new BetaParticle(1, 3545000.0), new Bismuth205() } },
            { 0.0004d, new List<RadioactiveSubstance> { new AlphaParticle(6345047.4), new Lead201() } },

        };
    }
}
    
    