using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neptunium233 : RadioactiveSubstance
    {
        public override string name { get; } = "Neptunium233";
        public override double halfLife { get; } = 2172.0d;
        public override double atomicWeight { get; } = 233.04074d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 1030900.0000000001), new Uranium233() } },
            { 7e-06d, new List<RadioactiveSubstance> { new AlphaParticle(6648047.4), new Protactinium229() } },

        };
    }
}
    
    