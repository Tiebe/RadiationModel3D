
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Phosphorus26 : RadioactiveSubstance
    {
        public override string name { get; } = "Phosphorus26";
        public override double halfLife { get; } = 0.0436d;
        public override double atomicWeight { get; } = 26.01178d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Silicon26() } },

        };
    }
}
    
    