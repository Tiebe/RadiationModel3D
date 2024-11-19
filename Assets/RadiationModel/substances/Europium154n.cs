using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Europium154n : RadioactiveSubstance
    {
        public override string name { get; } = "Europium154n";
        public override double halfLife { get; } = 2778.0d;
        public override double atomicWeight { get; } = 153.92314d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((145300.00001, 0.00853)), new Europium154() } },

        };
    }
}
    
    