using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Calcium51 : RadioactiveSubstance
    {
        public override string name { get; } = "Calcium51";
        public override double halfLife { get; } = 10.0d;
        public override double atomicWeight { get; } = 50.961d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 6918100.0), new Scandium51() } },

        };
    }
}
    
    