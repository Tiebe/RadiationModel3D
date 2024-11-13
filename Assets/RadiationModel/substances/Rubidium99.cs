
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rubidium99 : RadioactiveSubstance
    {
        public override string name { get; } = "Rubidium99";
        public override double halfLife { get; } = 0.054d;
        public override double atomicWeight { get; } = 98.94512d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Strontium99() } },

        };
    }
}
    
    