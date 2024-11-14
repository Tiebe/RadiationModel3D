using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bismuth212 : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth212";
        public override double halfLife { get; } = 3633.0d;
        public override double atomicWeight { get; } = 211.99129d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.6406000000000001d, new List<RadioactiveSubstance> { new BetaParticle(-1, 2251500.0), new Polonium212() } },
            { 0.3594d, new List<RadioactiveSubstance> { new AlphaParticle(7227247.4), new Thallium208() } },

        };
    }
}
    
    