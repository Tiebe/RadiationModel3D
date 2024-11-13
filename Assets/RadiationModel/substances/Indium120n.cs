
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium120n : RadioactiveSubstance
    {
        public override string name { get; } = "Indium120n";
        public override double halfLife { get; } = 47.3d;
        public override double atomicWeight { get; } = 119.90829d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Tin120() } },

        };
    }
}
    
    