
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nickel71m : RadioactiveSubstance
    {
        public override string name { get; } = "Nickel71m";
        public override double halfLife { get; } = 2.3d;
        public override double atomicWeight { get; } = 70.94052d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Copper71() } },

        };
    }
}
    
    