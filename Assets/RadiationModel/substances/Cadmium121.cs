
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cadmium121 : RadioactiveSubstance
    {
        public override string name { get; } = "Cadmium121";
        public override double halfLife { get; } = 13.5d;
        public override double atomicWeight { get; } = 120.91296d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Indium121() } },

        };
    }
}
    
    