
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Molybdenum88 : RadioactiveSubstance
    {
        public override string name { get; } = "Molybdenum88";
        public override double halfLife { get; } = 480.0d;
        public override double atomicWeight { get; } = 87.92197d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Niobium88() } },

        };
    }
}
    
    