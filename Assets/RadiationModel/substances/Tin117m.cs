
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tin117m : RadioactiveSubstance
    {
        public override string name { get; } = "Tin117m";
        public override double halfLife { get; } = 1204329.6d;
        public override double atomicWeight { get; } = 116.90329d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(), new Tin117() } },

        };
    }
}
    
    