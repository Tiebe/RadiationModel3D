using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cadmium128 : RadioactiveSubstance
    {
        public override string name { get; } = "Cadmium128";
        public override double halfLife { get; } = 0.246d;
        public override double atomicWeight { get; } = 127.92782d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 6952100.0), new Indium128() } },

        };
    }
}
    
    