using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cesium126n : RadioactiveSubstance
    {
        public override string name { get; } = "Cesium126n";
        public override double halfLife { get; } = 0.00017d;
        public override double atomicWeight { get; } = 125.91009d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((596000.0, 0.00208)), new Cesium126() } },

        };
    }
}
    
    