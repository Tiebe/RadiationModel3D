using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Scandium44 : RadioactiveSubstance
    {
        public override string name { get; } = "Scandium44";
        public override double halfLife { get; } = 14551.56d;
        public override double atomicWeight { get; } = 43.9594d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 3652700.0), new Calcium44() } },

        };
    }
}
    
    