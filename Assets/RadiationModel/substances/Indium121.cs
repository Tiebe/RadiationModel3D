
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium121 : RadioactiveSubstance
    {
        public override string name { get; } = "Indium121";
        public override double halfLife { get; } = 23.1d;
        public override double atomicWeight { get; } = 120.90785d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Tin121() } },

        };
    }
}
    
    