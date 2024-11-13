
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nitrogen22 : RadioactiveSubstance
    {
        public override string name { get; } = "Nitrogen22";
        public override double halfLife { get; } = 0.023d;
        public override double atomicWeight { get; } = 22.0341d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Oxygen22() } },

        };
    }
}
    
    