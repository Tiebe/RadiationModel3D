
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cesium116m : RadioactiveSubstance
    {
        public override string name { get; } = "Cesium116m";
        public override double halfLife { get; } = 3.85d;
        public override double atomicWeight { get; } = 115.9335d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Xenon116() } },

        };
    }
}
    
    