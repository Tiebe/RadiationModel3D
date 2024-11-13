
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iridium175n : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium175n";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 174.96425d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(), new Iridium175() } },

        };
    }
}
    
    