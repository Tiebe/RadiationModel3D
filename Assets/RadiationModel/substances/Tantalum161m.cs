
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tantalum161m : RadioactiveSubstance
    {
        public override string name { get; } = "Tantalum161m";
        public override double halfLife { get; } = 3.08d;
        public override double atomicWeight { get; } = 160.95844d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.93d, new List<RadioactiveSubstance> { new BetaParticle(), new Hafnium161() } },

            { 0.07d, new List<RadioactiveSubstance> { new AlphaParticle(), new Lutetium157() } },

        };
    }
}
    
    