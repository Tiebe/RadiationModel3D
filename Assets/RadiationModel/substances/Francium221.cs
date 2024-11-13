
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Francium221 : RadioactiveSubstance
    {
        public override string name { get; } = "Francium221";
        public override double halfLife { get; } = 288.06d;
        public override double atomicWeight { get; } = 221.01425d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(), new Astatine217() } },

            { 4.7999999999999994e-05d, new List<RadioactiveSubstance> { new BetaParticle(), new Radium221() } },

            { 8.800000000000001e-13d, new List<RadioactiveSubstance> { new Carbon14(), new Thallium207() } },

        };
    }
}
    
    