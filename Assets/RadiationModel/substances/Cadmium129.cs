using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cadmium129 : RadioactiveSubstance
    {
        public override string name { get; } = "Cadmium129";
        public override double halfLife { get; } = 0.147d;
        public override double atomicWeight { get; } = 128.93224d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 9712900.0), new Indium129() } },

        };
    }
}
    
    