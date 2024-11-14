using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Zinc67m : RadioactiveSubstance
    {
        public override string name { get; } = "Zinc67m";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 66.92723d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.01329), new Zinc67() } },

        };
    }
}
    
    