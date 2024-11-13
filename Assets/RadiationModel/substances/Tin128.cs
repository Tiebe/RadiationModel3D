
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tin128 : RadioactiveSubstance
    {
        public override string name { get; } = "Tin128";
        public override double halfLife { get; } = 3544.2d;
        public override double atomicWeight { get; } = 127.91051d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Antimony128() } },

        };
    }
}
    
    