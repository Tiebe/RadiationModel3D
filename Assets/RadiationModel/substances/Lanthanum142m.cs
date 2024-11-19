using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lanthanum142m : RadioactiveSubstance
    {
        public override string name { get; } = "Lanthanum142m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 141.91425d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((146000.0, 0.00849)), new Lanthanum142() } },

        };
    }
}
    
    