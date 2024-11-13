
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nickel49 : RadioactiveSubstance
    {
        public override string name { get; } = "Nickel49";
        public override double halfLife { get; } = 0.0075d;
        public override double atomicWeight { get; } = 49.00916d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Cobalt49() } },

        };
    }
}
    
    