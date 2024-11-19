using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhenium161m : RadioactiveSubstance
    {
        public override string name { get; } = "Rhenium161m";
        public override double halfLife { get; } = 0.0147d;
        public override double atomicWeight { get; } = 160.97776d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.93d, new List<RadioactiveSubstance> { new AlphaParticle(7477002.09), new Tantalum157() } },
            { 0.07d, new List<RadioactiveSubstance> { new ProtonParticle(), new Tungsten160() } },

        };
    }
}
    
    