
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Antimony108 : RadioactiveSubstance
    {
        public override string name { get; } = "Antimony108";
        public override double halfLife { get; } = 7.4d;
        public override double atomicWeight { get; } = 107.92223d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Tin108() } },

        };
    }
}
    
    