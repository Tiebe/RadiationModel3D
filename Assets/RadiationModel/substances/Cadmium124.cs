using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cadmium124 : RadioactiveSubstance
    {
        public override string name { get; } = "Cadmium124";
        public override double halfLife { get; } = 1.25d;
        public override double atomicWeight { get; } = 123.91766d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 4170600.0000000005), new Indium124() } },

        };
    }
}
    
    