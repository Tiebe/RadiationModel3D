using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Samarium155m : RadioactiveSubstance
    {
        public override string name { get; } = "Samarium155m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 154.92466d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.07514, 16500.0), new Samarium155() } },

        };
    }
}
    
    