using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhenium192m : RadioactiveSubstance
    {
        public override string name { get; } = "Rhenium192m";
        public override double halfLife { get; } = 9e-05d;
        public override double atomicWeight { get; } = 191.96626d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00775, 160000.0), new Rhenium192() } },

        };
    }
}
    
    