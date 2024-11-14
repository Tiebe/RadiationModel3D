using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Polonium207 : RadioactiveSubstance
    {
        public override string name { get; } = "Polonium207";
        public override double halfLife { get; } = 20880.0d;
        public override double atomicWeight { get; } = 206.98159d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 2908600.0), new Bismuth207() } },
            { 0.00021d, new List<RadioactiveSubstance> { new AlphaParticle(6235047.4), new Lead203() } },

        };
    }
}
    
    