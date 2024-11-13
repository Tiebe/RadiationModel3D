
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Aluminum31 : RadioactiveSubstance
    {
        public override string name { get; } = "Aluminum31";
        public override double halfLife { get; } = 0.644d;
        public override double atomicWeight { get; } = 30.98395d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Silicon31() } },

        };
    }
}
    
    