
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rubidium94 : RadioactiveSubstance
    {
        public override string name { get; } = "Rubidium94";
        public override double halfLife { get; } = 2.702d;
        public override double atomicWeight { get; } = 93.92639d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Strontium94() } },

        };
    }
}
    
    