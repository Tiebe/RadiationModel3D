
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nickel55 : RadioactiveSubstance
    {
        public override string name { get; } = "Nickel55";
        public override double halfLife { get; } = 0.2039d;
        public override double atomicWeight { get; } = 54.95133d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Cobalt55() } },

        };
    }
}
    
    