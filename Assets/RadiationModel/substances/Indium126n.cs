using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium126n : RadioactiveSubstance
    {
        public override string name { get; } = "Indium126n";
        public override double halfLife { get; } = 2e-05d;
        public override double atomicWeight { get; } = 125.91673d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((243000.0, 0.0051)), new Indium126() } },

        };
    }
}
    
    