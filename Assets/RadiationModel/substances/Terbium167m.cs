using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Terbium167m : RadioactiveSubstance
    {
        public override string name { get; } = "Terbium167m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 166.94022d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((200099.99999, 0.0062)), new Terbium167() } },

        };
    }
}
    
    