
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lanthanum139m : RadioactiveSubstance
    {
        public override string name { get; } = "Lanthanum139m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 138.9083d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(), new Lanthanum139() } },

        };
    }
}
    
    