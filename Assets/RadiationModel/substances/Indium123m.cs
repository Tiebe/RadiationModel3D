
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium123m : RadioactiveSubstance
    {
        public override string name { get; } = "Indium123m";
        public override double halfLife { get; } = 47.4d;
        public override double atomicWeight { get; } = 122.91079d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Tin123() } },

        };
    }
}
    
    