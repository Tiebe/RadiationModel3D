
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Terbium147m : RadioactiveSubstance
    {
        public override string name { get; } = "Terbium147m";
        public override double halfLife { get; } = 112.2d;
        public override double atomicWeight { get; } = 146.92411d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Gadolinium147() } },

        };
    }
}
    
    