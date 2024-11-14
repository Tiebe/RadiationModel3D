using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lutetium179m : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium179m";
        public override double halfLife { get; } = 0.0031d;
        public override double atomicWeight { get; } = 178.94797d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00209), new Lutetium179() } },

        };
    }
}
    
    