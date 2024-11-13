
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nickel50 : RadioactiveSubstance
    {
        public override string name { get; } = "Nickel50";
        public override double halfLife { get; } = 0.0185d;
        public override double atomicWeight { get; } = 49.99629d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Cobalt50() } },

        };
    }
}
    
    