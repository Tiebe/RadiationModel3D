
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nickel70 : RadioactiveSubstance
    {
        public override string name { get; } = "Nickel70";
        public override double halfLife { get; } = 6.0d;
        public override double atomicWeight { get; } = 69.93643d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Copper70() } },

        };
    }
}
    
    