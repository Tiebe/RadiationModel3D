
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cesium145m : RadioactiveSubstance
    {
        public override string name { get; } = "Cesium145m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 144.93635d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(), new Cesium145() } },

        };
    }
}
    
    