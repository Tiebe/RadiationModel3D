using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thulium152n : RadioactiveSubstance
    {
        public override string name { get; } = "Thulium152n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 151.94711d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00051, 2450000.0), new Thulium152() } },

        };
    }
}
    
    