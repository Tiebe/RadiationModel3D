
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhenium184m : RadioactiveSubstance
    {
        public override string name { get; } = "Rhenium184m";
        public override double halfLife { get; } = 14601600.0d;
        public override double atomicWeight { get; } = 183.95273d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.745d, new List<RadioactiveSubstance> { new GammaParticle(), new Rhenium184() } },

            { 0.255d, new List<RadioactiveSubstance> { new Tungsten184() } },

        };
    }
}
    
    