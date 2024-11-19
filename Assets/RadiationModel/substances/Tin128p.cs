using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tin128p : RadioactiveSubstance
    {
        public override string name { get; } = "Tin128p";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 127.91491d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((4099000.0, 0.0003)), new Tin128() } },

        };
    }
}
    
    