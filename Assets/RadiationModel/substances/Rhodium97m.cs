using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhodium97m : RadioactiveSubstance
    {
        public override string name { get; } = "Rhodium97m";
        public override double halfLife { get; } = 2772.0d;
        public override double atomicWeight { get; } = 96.9116d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9440000000000001d, new List<RadioactiveSubstance> { new BetaParticle(1, 3780600.0), new Ruthenium97() } },
            { 0.055999999999999994d, new List<RadioactiveSubstance> { new GammaParticle((260000.0, 0.00477)), new Rhodium97() } },

        };
    }
}
    
    