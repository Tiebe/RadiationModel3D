
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Niobium106 : RadioactiveSubstance
    {
        public override string name { get; } = "Niobium106";
        public override double halfLife { get; } = 0.9d;
        public override double atomicWeight { get; } = 105.92893d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Molybdenum106() } },

        };
    }
}
    
    