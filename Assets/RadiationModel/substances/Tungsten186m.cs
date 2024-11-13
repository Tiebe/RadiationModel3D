
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tungsten186m : RadioactiveSubstance
    {
        public override string name { get; } = "Tungsten186m";
        public override double halfLife { get; } = 2e-05d;
        public override double atomicWeight { get; } = 185.95599d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(), new Tungsten186() } },

        };
    }
}
    
    