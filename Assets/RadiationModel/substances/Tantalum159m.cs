
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tantalum159m : RadioactiveSubstance
    {
        public override string name { get; } = "Tantalum159m";
        public override double halfLife { get; } = 0.56d;
        public override double atomicWeight { get; } = 158.9631d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.55d, new List<RadioactiveSubstance> { new AlphaParticle(), new Lutetium155() } },

            { 0.45d, new List<RadioactiveSubstance> { new BetaParticle(), new Hafnium159() } },

        };
    }
}
    
    