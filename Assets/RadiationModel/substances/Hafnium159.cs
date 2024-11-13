
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

            { 0.65d, new List<RadioactiveSubstance> { new BetaParticle(), new Lutetium159() } },

            { 0.35d, new List<RadioactiveSubstance> { new AlphaParticle(), new Ytterbium155() } },

        };
    }
}
    
    