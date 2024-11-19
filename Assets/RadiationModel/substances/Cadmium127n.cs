using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cadmium127n : RadioactiveSubstance
    {
        public override string name { get; } = "Cadmium127n";
        public override double halfLife { get; } = 2e-05d;
        public override double atomicWeight { get; } = 126.92818d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00067, 1845000.0), new Cadmium127() } },

        };
    }
}
    
    