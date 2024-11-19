using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Antimony127n : RadioactiveSubstance
    {
        public override string name { get; } = "Antimony127n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 126.90942d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((2325000.0, 0.00053)), new Antimony127() } },

        };
    }
}
    
    