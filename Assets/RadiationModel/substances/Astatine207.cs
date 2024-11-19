using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Astatine207 : RadioactiveSubstance
    {
        public override string name { get; } = "Astatine207";
        public override double halfLife { get; } = 6516.0d;
        public override double atomicWeight { get; } = 206.9858d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9d, new List<RadioactiveSubstance> { new BetaParticle(1, 3919000.0), new Polonium207() } },
            { 0.1d, new List<RadioactiveSubstance> { new AlphaParticle(6895002.09), new Bismuth203() } },

        };
    }
}
    
    