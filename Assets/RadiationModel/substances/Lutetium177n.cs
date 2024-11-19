using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lutetium177n : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium177n";
        public override double halfLife { get; } = 0.00015d;
        public override double atomicWeight { get; } = 176.94438d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00218, 569700.0), new Lutetium177() } },

        };
    }
}
    
    