using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Mercury180 : RadioactiveSubstance
    {
        public override string name { get; } = "Mercury180";
        public override double halfLife { get; } = 2.59d;
        public override double atomicWeight { get; } = 179.97826d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.52d, new List<RadioactiveSubstance> { new BetaParticle(1, 5375000.0), new Gold180() } },
            { 0.48d, new List<RadioactiveSubstance> { new AlphaParticle(7280002.09), new Platinum176() } },

        };
    }
}
    
    