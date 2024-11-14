using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neodymium147 : RadioactiveSubstance
    {
        public override string name { get; } = "Neodymium147";
        public override double halfLife { get; } = 948672.0d;
        public override double atomicWeight { get; } = 146.91611d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 895200.0), new Promethium147() } },

        };
    }
}
    
    