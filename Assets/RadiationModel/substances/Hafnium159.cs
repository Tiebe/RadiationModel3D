using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hafnium159 : RadioactiveSubstance
    {
        public override string name { get; } = "Hafnium159";
        public override double halfLife { get; } = 5.2d;
        public override double atomicWeight { get; } = 158.954d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.65d, new List<RadioactiveSubstance> { new BetaParticle(1, 6857000.0), new Lutetium159() } },
            { 0.35d, new List<RadioactiveSubstance> { new AlphaParticle(6245047.4), new Ytterbium155() } },

        };
    }
}
    
    