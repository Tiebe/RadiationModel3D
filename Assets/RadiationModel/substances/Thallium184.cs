using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thallium184 : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium184";
        public override double halfLife { get; } = 9.5d;
        public override double atomicWeight { get; } = 183.98188d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9878d, new List<RadioactiveSubstance> { new BetaParticle(1, 9462000.0), new Mercury184() } },
            { 0.012199999999999999d, new List<RadioactiveSubstance> { new AlphaParticle(7338047.4), new Gold180() } },

        };
    }
}
    
    