using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gallium81 : RadioactiveSubstance
    {
        public override string name { get; } = "Gallium81";
        public override double halfLife { get; } = 1.217d;
        public override double atomicWeight { get; } = 80.93813d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 8663700.0), new Germanium81() } },

        };
    }
}
    
    