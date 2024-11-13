
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Antimony109 : RadioactiveSubstance
    {
        public override string name { get; } = "Antimony109";
        public override double halfLife { get; } = 17.2d;
        public override double atomicWeight { get; } = 108.91814d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Tin109() } },

        };
    }
}
    
    