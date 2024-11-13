
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silicon32 : RadioactiveSubstance
    {
        public override string name { get; } = "Silicon32";
        public override double halfLife { get; } = 4954441464.0d;
        public override double atomicWeight { get; } = 31.97415d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Phosphorus32() } },

        };
    }
}
    
    