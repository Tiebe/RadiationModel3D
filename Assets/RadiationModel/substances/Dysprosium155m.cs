
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Dysprosium155m : RadioactiveSubstance
    {
        public override string name { get; } = "Dysprosium155m";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 154.92601d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(), new Dysprosium155() } },

        };
    }
}
    
    