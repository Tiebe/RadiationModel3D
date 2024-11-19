using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cadmium97m : RadioactiveSubstance
    {
        public override string name { get; } = "Cadmium97m";
        public override double halfLife { get; } = 0.00073d;
        public override double atomicWeight { get; } = 96.93615d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00099, 1250000.0), new Cadmium97() } },

        };
    }
}
    
    