
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Barium129m : RadioactiveSubstance
    {
        public override string name { get; } = "Barium129m";
        public override double halfLife { get; } = 7686.0d;
        public override double atomicWeight { get; } = 128.90869d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Cesium129() } },

        };
    }
}
    
    