
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silver102 : RadioactiveSubstance
    {
        public override string name { get; } = "Silver102";
        public override double halfLife { get; } = 774.0d;
        public override double atomicWeight { get; } = 101.9117d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Palladium102() } },

        };
    }
}
    
    