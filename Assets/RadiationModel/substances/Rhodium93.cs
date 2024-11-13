
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhodium93 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhodium93";
        public override double halfLife { get; } = 13.9d;
        public override double atomicWeight { get; } = 92.92591d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Ruthenium93() } },

        };
    }
}
    
    