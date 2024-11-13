
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Palladium128m : RadioactiveSubstance
    {
        public override string name { get; } = "Palladium128m";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 127.95465d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(), new Palladium128() } },

        };
    }
}
    
    