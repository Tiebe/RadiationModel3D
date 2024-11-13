
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Yttrium85 : RadioactiveSubstance
    {
        public override string name { get; } = "Yttrium85";
        public override double halfLife { get; } = 9648.0d;
        public override double atomicWeight { get; } = 84.91643d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Strontium85() } },

        };
    }
}
    
    