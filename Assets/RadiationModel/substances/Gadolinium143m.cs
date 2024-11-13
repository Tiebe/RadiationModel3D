
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gadolinium143m : RadioactiveSubstance
    {
        public override string name { get; } = "Gadolinium143m";
        public override double halfLife { get; } = 110.0d;
        public override double atomicWeight { get; } = 142.92691d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Europium143() } },

        };
    }
}
    
    