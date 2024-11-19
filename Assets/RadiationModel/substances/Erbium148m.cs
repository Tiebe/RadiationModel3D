using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Erbium148m : RadioactiveSubstance
    {
        public override string name { get; } = "Erbium148m";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 147.94786d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((2913000.0, 0.00043)), new Erbium148() } },

        };
    }
}
    
    