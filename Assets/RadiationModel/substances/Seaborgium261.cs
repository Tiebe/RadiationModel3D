using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Seaborgium261 : RadioactiveSubstance
    {
        public override string name { get; } = "Seaborgium261";
        public override double halfLife { get; } = 0.183d;
        public override double atomicWeight { get; } = 261.11595d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.981d, new List<RadioactiveSubstance> { new AlphaParticle(10734047.4), new Rutherfordium257() } },
            { 0.013000000000000001d, new List<RadioactiveSubstance> { new BetaParticle(1, 3695000.0), new Dubnium261() } },
            { 0.006d, new List<RadioactiveSubstance> {  } },

        };
    }
}
    
    