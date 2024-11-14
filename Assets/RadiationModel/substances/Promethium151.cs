using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Promethium151 : RadioactiveSubstance
    {
        public override string name { get; } = "Promethium151";
        public override double halfLife { get; } = 102240.0d;
        public override double atomicWeight { get; } = 150.92122d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 1190500.0), new Samarium151() } },

        };
    }
}
    
    