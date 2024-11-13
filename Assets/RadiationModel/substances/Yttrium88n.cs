
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Yttrium88n : RadioactiveSubstance
    {
        public override string name { get; } = "Yttrium88n";
        public override double halfLife { get; } = 0.01398d;
        public override double atomicWeight { get; } = 87.91023d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(), new Yttrium88() } },

        };
    }
}
    
    