
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rubidium87 : RadioactiveSubstance
    {
        public override string name { get; } = "Rubidium87";
        public override double halfLife { get; } = 1.5683805144e+18d;
        public override double atomicWeight { get; } = 86.90918d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Strontium87() } },

        };
    }
}
    
    