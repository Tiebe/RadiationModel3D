
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nickel77 : RadioactiveSubstance
    {
        public override string name { get; } = "Nickel77";
        public override double halfLife { get; } = 0.1589d;
        public override double atomicWeight { get; } = 76.9599d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Copper77() } },

        };
    }
}
    
    