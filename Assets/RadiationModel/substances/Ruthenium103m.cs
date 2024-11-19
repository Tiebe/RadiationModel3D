using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Ruthenium103m : RadioactiveSubstance
    {
        public override string name { get; } = "Ruthenium103m";
        public override double halfLife { get; } = 0.00169d;
        public override double atomicWeight { get; } = 102.90657d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00521, 238200.0), new Ruthenium103() } },

        };
    }
}
    
    