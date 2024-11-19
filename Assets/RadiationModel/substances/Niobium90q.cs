using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Niobium90q : RadioactiveSubstance
    {
        public override string name { get; } = "Niobium90q";
        public override double halfLife { get; } = 0.00619d;
        public override double atomicWeight { get; } = 89.91167d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.0d, new List<RadioactiveSubstance> { new GammaParticle((382000.0, 0.00325)), new Niobium90() } },
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((260000.0, 0.00477)), new Niobium90m() } },

        };
    }
}
    
    