using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium109n : RadioactiveSubstance
    {
        public override string name { get; } = "Indium109n";
        public override double halfLife { get; } = 0.21d;
        public override double atomicWeight { get; } = 108.90941d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00059), new Indium109() } },
            { 0.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00085), new Indium109m() } },

        };
    }
}
    
    