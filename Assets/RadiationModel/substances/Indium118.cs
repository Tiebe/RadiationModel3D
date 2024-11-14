using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium118 : RadioactiveSubstance
    {
        public override string name { get; } = "Indium118";
        public override double halfLife { get; } = 5.0d;
        public override double atomicWeight { get; } = 117.90636d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 4424800.0), new Tin118() } },

        };
    }
}
    
    