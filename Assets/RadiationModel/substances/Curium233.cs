using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Curium233 : RadioactiveSubstance
    {
        public override string name { get; } = "Curium233";
        public override double halfLife { get; } = 27.0d;
        public override double atomicWeight { get; } = 233.05077d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.2d, new List<RadioactiveSubstance> { new AlphaParticle(8497002.09), new Plutonium229() } },
            { 0.8d, new List<RadioactiveSubstance> { new BetaParticle(1, 4000000.0), new Americium233() } },

        };
    }
}
    
    