
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Samarium133 : RadioactiveSubstance
    {
        public override string name { get; } = "Samarium133";
        public override double halfLife { get; } = 2.89d;
        public override double atomicWeight { get; } = 132.93856d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Promethium133() } },

        };
    }
}
    
    