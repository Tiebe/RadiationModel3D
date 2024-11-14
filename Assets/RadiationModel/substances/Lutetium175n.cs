using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lutetium175n : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium175n";
        public override double halfLife { get; } = 0.00098d;
        public override double atomicWeight { get; } = 174.94227d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00089), new Lutetium175() } },

        };
    }
}
    
    