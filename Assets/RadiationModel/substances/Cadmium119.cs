using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cadmium119 : RadioactiveSubstance
    {
        public override string name { get; } = "Cadmium119";
        public override double halfLife { get; } = 161.4d;
        public override double atomicWeight { get; } = 118.90984d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 3719000.0), new Indium119() } },

        };
    }
}
    
    