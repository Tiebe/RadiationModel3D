
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tin127m : RadioactiveSubstance
    {
        public override string name { get; } = "Tin127m";
        public override double halfLife { get; } = 247.8d;
        public override double atomicWeight { get; } = 126.9104d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Antimony127() } },

        };
    }
}
    
    