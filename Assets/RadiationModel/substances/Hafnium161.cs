
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hafnium161 : RadioactiveSubstance
    {
        public override string name { get; } = "Hafnium161";
        public override double halfLife { get; } = 18.4d;
        public override double atomicWeight { get; } = 160.95028d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.9971d, new List<RadioactiveSubstance> { new BetaParticle(), new Lutetium161() } },

            { 0.0029d, new List<RadioactiveSubstance> { new AlphaParticle(), new Ytterbium157() } },

        };
    }
}
    
    