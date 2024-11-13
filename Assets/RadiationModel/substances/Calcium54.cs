
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Calcium54 : RadioactiveSubstance
    {
        public override string name { get; } = "Calcium54";
        public override double halfLife { get; } = 0.09d;
        public override double atomicWeight { get; } = 53.97299d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Scandium54() } },

        };
    }
}
    
    