
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Krypton76 : RadioactiveSubstance
    {
        public override string name { get; } = "Krypton76";
        public override double halfLife { get; } = 53280.0d;
        public override double atomicWeight { get; } = 75.92591d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Bromine76() } },

        };
    }
}
    
    