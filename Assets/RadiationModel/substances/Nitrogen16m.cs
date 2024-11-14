using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nitrogen16m : RadioactiveSubstance
    {
        public override string name { get; } = "Nitrogen16m";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 16.00623d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.0103), new Nitrogen16() } },
            { 3.89e-06d, new List<RadioactiveSubstance> { new BetaParticle(-1, 10541302.100000001), new Oxygen16() } },

        };
    }
}
    
    