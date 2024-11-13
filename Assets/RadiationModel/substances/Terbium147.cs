
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Terbium147 : RadioactiveSubstance
    {
        public override string name { get; } = "Terbium147";
        public override double halfLife { get; } = 5904.0d;
        public override double atomicWeight { get; } = 146.92405d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Gadolinium147() } },

        };
    }
}
    
    