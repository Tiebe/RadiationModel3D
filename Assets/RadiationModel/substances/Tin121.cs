
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tin121 : RadioactiveSubstance
    {
        public override string name { get; } = "Tin121";
        public override double halfLife { get; } = 97308.0d;
        public override double atomicWeight { get; } = 120.90424d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Antimony121() } },

        };
    }
}
    
    