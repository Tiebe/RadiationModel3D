using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Astatine205m : RadioactiveSubstance
    {
        public override string name { get; } = "Astatine205m";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 204.98857d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00053, 2340000.0), new Astatine205() } },

        };
    }
}
    
    