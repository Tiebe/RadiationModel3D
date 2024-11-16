using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radon206 : RadioactiveSubstance
    {
        public override string name { get; } = "Radon206";
        public override double halfLife { get; } = 340.2d;
        public override double atomicWeight { get; } = 205.9902d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.62d, new List<RadioactiveSubstance> { new AlphaParticle(7404047.4), new Polonium202() } },
            { 0.38d, new List<RadioactiveSubstance> { new BetaParticle(1, 3306000.0), new Astatine206() } },

        };
    }
}
    
    