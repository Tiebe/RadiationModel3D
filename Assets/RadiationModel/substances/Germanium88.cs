
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Germanium88 : RadioactiveSubstance
    {
        public override string name { get; } = "Germanium88";
        public override double halfLife { get; } = 0.061d;
        public override double atomicWeight { get; } = 87.95757d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Arsenic88() } },

        };
    }
}
    
    