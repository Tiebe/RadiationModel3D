
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Americium236m : RadioactiveSubstance
    {
        public override string name { get; } = "Americium236m";
        public override double halfLife { get; } = 174.0d;
        public override double atomicWeight { get; } = 236.04948d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Plutonium236() } },

        };
    }
}
    
    