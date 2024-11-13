
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cesium147m : RadioactiveSubstance
    {
        public override string name { get; } = "Cesium147m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 146.94501d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(), new Cesium147() } },

        };
    }
}
    
    