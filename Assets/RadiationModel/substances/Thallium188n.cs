using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thallium188n : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium188n";
        public override double halfLife { get; } = 0.041d;
        public override double atomicWeight { get; } = 187.97634d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((296000.0, 0.00419)), new Thallium188() } },

        };
    }
}
    
    