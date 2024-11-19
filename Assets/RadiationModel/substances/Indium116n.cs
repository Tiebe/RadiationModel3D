using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium116n : RadioactiveSubstance
    {
        public override string name { get; } = "Indium116n";
        public override double halfLife { get; } = 2.18d;
        public override double atomicWeight { get; } = 115.90557d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.0d, new List<RadioactiveSubstance> { new GammaParticle((289660.00001, 0.00428)), new Indium116() } },
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((162390.0, 0.00763)), new Indium116m() } },

        };
    }
}
    
    