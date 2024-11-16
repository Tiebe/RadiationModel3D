using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium127p : RadioactiveSubstance
    {
        public override string name { get; } = "Indium127p";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 126.92d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((2365000.0, 0.00052)), new Indium127() } },

        };
    }
}
    
    