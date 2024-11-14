using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Samarium164 : RadioactiveSubstance
    {
        public override string name { get; } = "Samarium164";
        public override double halfLife { get; } = 1.43d;
        public override double atomicWeight { get; } = 163.94855d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 5307100.0), new Europium164() } },

        };
    }
}
    
    