
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rubidium103 : RadioactiveSubstance
    {
        public override string name { get; } = "Rubidium103";
        public override double halfLife { get; } = 0.026d;
        public override double atomicWeight { get; } = 102.9644d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Strontium103() } },

        };
    }
}
    
    