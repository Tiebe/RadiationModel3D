using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Samarium142 : RadioactiveSubstance
    {
        public override string name { get; } = "Samarium142";
        public override double halfLife { get; } = 4349.4d;
        public override double atomicWeight { get; } = 141.91521d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 2160100.0), new Promethium142() } },
            { 0.05d, new List<RadioactiveSubstance> { new BetaParticle(1, 2160100.0), new Promethium142() } },

        };
    }
}
    
    