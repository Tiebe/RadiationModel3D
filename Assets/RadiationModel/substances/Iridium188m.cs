using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iridium188m : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium188m";
        public override double halfLife { get; } = 0.00415d;
        public override double atomicWeight { get; } = 187.95987d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((964000.0, 0.00129)), new Iridium188() } },

        };
    }
}
    
    