
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium131n : RadioactiveSubstance
    {
        public override string name { get; } = "Indium131n";
        public override double halfLife { get; } = 0.322d;
        public override double atomicWeight { get; } = 130.93099d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Tin131() } },

        };
    }
}
    
    