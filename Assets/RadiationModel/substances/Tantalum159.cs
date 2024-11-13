
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tantalum159 : RadioactiveSubstance
    {
        public override string name { get; } = "Tantalum159";
        public override double halfLife { get; } = 1.04d;
        public override double atomicWeight { get; } = 158.96303d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.66d, new List<RadioactiveSubstance> { new BetaParticle(), new Hafnium159() } },

            { 0.34d, new List<RadioactiveSubstance> { new AlphaParticle(), new Lutetium155() } },

        };
    }
}
    
    