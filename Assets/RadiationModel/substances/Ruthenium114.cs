
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Ruthenium114 : RadioactiveSubstance
    {
        public override string name { get; } = "Ruthenium114";
        public override double halfLife { get; } = 0.54d;
        public override double atomicWeight { get; } = 113.92461d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Rhodium114() } },

        };
    }
}
    
    