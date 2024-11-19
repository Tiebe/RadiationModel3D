using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhodium100n : RadioactiveSubstance
    {
        public override string name { get; } = "Rhodium100n";
        public override double halfLife { get; } = 276.0d;
        public override double atomicWeight { get; } = 99.90823d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.983d, new List<RadioactiveSubstance> { new GammaParticle(0.01148, 108000.0), new Rhodium100() } },
            { 0.017d, new List<RadioactiveSubstance> { new BetaParticle(1, 3744400.0), new Ruthenium100() } },

        };
    }
}
    
    