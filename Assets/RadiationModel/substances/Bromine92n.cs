using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bromine92n : RadioactiveSubstance
    {
        public override string name { get; } = "Bromine92n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 91.94085d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00109), new Bromine92() } },

        };
    }
}
    
    