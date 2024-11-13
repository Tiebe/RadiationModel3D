
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Phosphorus29 : RadioactiveSubstance
    {
        public override string name { get; } = "Phosphorus29";
        public override double halfLife { get; } = 4.102d;
        public override double atomicWeight { get; } = 28.9818d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Silicon29() } },

        };
    }
}
    
    