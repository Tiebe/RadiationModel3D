using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gadolinium155m : RadioactiveSubstance
    {
        public override string name { get; } = "Gadolinium155m";
        public override double halfLife { get; } = 0.03197d;
        public override double atomicWeight { get; } = 154.92276d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.01024), new Gadolinium155() } },

        };
    }
}
    
    