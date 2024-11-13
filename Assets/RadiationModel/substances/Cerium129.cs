
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cerium129 : RadioactiveSubstance
    {
        public override string name { get; } = "Cerium129";
        public override double halfLife { get; } = 210.0d;
        public override double atomicWeight { get; } = 128.9181d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Lanthanum129() } },

        };
    }
}
    
    