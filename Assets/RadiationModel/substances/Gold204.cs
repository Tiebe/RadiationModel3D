
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gold204 : RadioactiveSubstance
    {
        public override string name { get; } = "Gold204";
        public override double halfLife { get; } = 38.3d;
        public override double atomicWeight { get; } = 203.97811d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Mercury204() } },

        };
    }
}
    
    