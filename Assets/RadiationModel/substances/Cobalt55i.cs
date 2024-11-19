using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cobalt55i : RadioactiveSubstance
    {
        public override string name { get; } = "Cobalt55i";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 54.94707d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((4721400.0, 0.00026)), new Cobalt55() } },

        };
    }
}
    
    