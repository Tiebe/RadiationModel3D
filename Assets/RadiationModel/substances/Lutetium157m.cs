
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lutetium157m : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium157m";
        public override double halfLife { get; } = 4.79d;
        public override double atomicWeight { get; } = 156.95017d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.9229999999999999d, new List<RadioactiveSubstance> { new BetaParticle(), new Ytterbium157() } },

            { 0.077d, new List<RadioactiveSubstance> { new AlphaParticle(), new Thulium153() } },

        };
    }
}
    
    