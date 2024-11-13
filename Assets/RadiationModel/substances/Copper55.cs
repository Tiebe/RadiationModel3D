
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Copper55 : RadioactiveSubstance
    {
        public override string name { get; } = "Copper55";
        public override double halfLife { get; } = 0.0559d;
        public override double atomicWeight { get; } = 54.96603d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Nickel55() } },

        };
    }
}
    
    