
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Xenon127m : RadioactiveSubstance
    {
        public override string name { get; } = "Xenon127m";
        public override double halfLife { get; } = 69.2d;
        public override double atomicWeight { get; } = 126.9055d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(), new Xenon127() } },

        };
    }
}
    
    